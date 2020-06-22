using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;
using System;

public class CameraOrbit : MonoBehaviour
{

    protected Transform _XForm_Camera;
    protected Transform _XForm_Parent;

    protected Vector3 _LocalRotation;
    protected float _CameraDistance = 4f;

    public float joystickSensitivity = 4f;
    public float ScrollSensitvity = 2f;
    public float OrbitDampening = 10f;
    public float ScrollDampening = 6f;

    Vector2 joystickMove;
    float cameraZoomValue;

    PlayerControls controls;

    private void Awake()
    {
        controls = new PlayerControls();

        controls.GamePlay.CameraMove.performed += ctx => joystickMove = ctx.ReadValue<Vector2>();
        controls.GamePlay.CameraMove.canceled += ctx => joystickMove = Vector2.zero;

        controls.GamePlay.CameraZoomIn.performed += ctx => cameraZoomValue = -1;
        controls.GamePlay.CameraZoomIn.canceled += ctx => cameraZoomValue = 0;

        controls.GamePlay.CameraZoomOut.performed += ctx => cameraZoomValue = 1;
        controls.GamePlay.CameraZoomOut.canceled += ctx => cameraZoomValue = 0;
    }

    private void OnEnable()
    {
        controls.GamePlay.Enable();
    }


    private void OnDisable()
    {
        controls.GamePlay.Disable();
    }


    // Use this for initialization
    void Start()
    {
        this._XForm_Camera = this.transform;
        this._XForm_Parent = this.transform.parent;
    }


    void LateUpdate()
    {

        //Rotation of the Camera based on Mouse Coordinates
        if (joystickMove != Vector2.zero)
        {
            _LocalRotation.x += joystickMove.x * joystickSensitivity;
            _LocalRotation.y += joystickMove.y * joystickSensitivity;


            //Clamp the y Rotation to horizon and not flipping over at the top
            if (_LocalRotation.y < 0f)
                _LocalRotation.y = 0f;
            else if (_LocalRotation.y > 90f)
                _LocalRotation.y = 90f;
        }
        //Zooming Input from our Mouse Scroll Wheel
        if (cameraZoomValue != 0f)
        {
            float ScrollAmount = cameraZoomValue * ScrollSensitvity;

            ScrollAmount *= (this._CameraDistance * 0.3f);

            this._CameraDistance += ScrollAmount * -1f;

            this._CameraDistance = Mathf.Clamp(this._CameraDistance, 1.5f, 100f);
        }

        //Actual Camera Rig Transformations
        Quaternion QT = Quaternion.Euler(_LocalRotation.y, _LocalRotation.x, 0);
        this._XForm_Parent.rotation = Quaternion.Lerp(this._XForm_Parent.rotation, QT, Time.deltaTime * OrbitDampening);

        if (this._XForm_Camera.localPosition.z != this._CameraDistance * -1f)
        {
            this._XForm_Camera.localPosition = new Vector3(0f, 0f, Mathf.Lerp(this._XForm_Camera.localPosition.z, this._CameraDistance * -1f, Time.deltaTime * ScrollDampening));
        }
    }
}
