using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using System;

public class BodyPartControllerMale : MonoBehaviour
{
    GameObject bodyShape;
    SkinnedMeshRenderer skinnedMeshRenderer;
    Mesh skinnedMesh;

    public float changeValueSpeed = 10f;
    public float changeIndexSpeed = 0.2f;
    int meshNumber;

    List<float> blendShapeValueList;
    int meshIndex = 0; //locate a mesh in the list

    PlayerControls controls;

    float meshValue;
    float switchSpeed;
    float timeRecord = 0f;
    float timeCounts = 0f;

    public Text indexName;
    public Text indexValue;

    Vector2 moveValue;
    Rigidbody rig;
    public GameObject cam;
    Vector3 movementDirection;
    public float moveSpeed = 1f;

    float resetValue;

    private void Awake()
    {
        controls = new PlayerControls();

        //find the mesh target list
        bodyShape = gameObject.transform.Find("G3M").gameObject;
        skinnedMeshRenderer = bodyShape.GetComponent<SkinnedMeshRenderer>();
        skinnedMesh = skinnedMeshRenderer.sharedMesh;

        //get int of the list
        meshNumber = skinnedMesh.blendShapeCount;

        //create a list of mesh values
        blendShapeValueList = new List<float>();
        for (int i = 0; i < meshNumber; i++)
        {
            blendShapeValueList.Add(skinnedMeshRenderer.GetBlendShapeWeight(i));
        }

        //movement assets
        rig = gameObject.GetComponent<Rigidbody>();
        cam = Camera.main.gameObject;

        //input controller
        controls.GamePlay.BodyShapeAddition.performed += ctx => meshValue = ctx.ReadValue<float>();
        controls.GamePlay.BodyShapeAddition.canceled += ctx => meshValue = 0f;

        controls.GamePlay.BlendShapeSwitch.performed += ctx => switchSpeed = ctx.ReadValue<float>();
        controls.GamePlay.BlendShapeSwitch.canceled += ctx => switchSpeed = 0f;

        controls.GamePlay.Movement.performed += ctx => moveValue = ctx.ReadValue<Vector2>();
        controls.GamePlay.Movement.canceled += ctx => moveValue = Vector2.zero;

        //controls.GamePlay.Reset.performed += _ => resetListValue();
    }

    private void resetListValue()
    {
        for (int i = 0; i < meshNumber; i++)
        {
            blendShapeValueList[i] = 0;
            skinnedMeshRenderer.SetBlendShapeWeight(i, 0);
        }
        Debug.Log("ValueReset");
    }        

    private void OnEnable()
    {
        controls.GamePlay.Enable();
    }


    private void OnDisable()
    {
        controls.GamePlay.Disable();
    }


    void changeIndexTimer()
    {
        if (switchSpeed > 0)
        {
            meshIndex += 1;
        }
        else if(switchSpeed < 0)
        {
            meshIndex -= 1;
        }

        if (meshIndex >= meshNumber - 1)
        {
            meshIndex = meshNumber - 1;
        }
        else if (meshIndex <= 0)
        {
            meshIndex = 0;
        }
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //update mesh index
        float timeCompare = Time.time - timeRecord;

        if (timeCompare >= timeCounts && switchSpeed != 0)
        {
            changeIndexTimer();

            timeRecord = Time.time;
            timeCounts = 1f + changeIndexSpeed - Math.Abs(switchSpeed);
        }

        //text in canvas
        indexName.text = skinnedMesh.GetBlendShapeName(meshIndex);
        indexValue.text = "Value:" + (int)skinnedMeshRenderer.GetBlendShapeWeight(meshIndex);

        //change mesh value
        blendShapeValueList[meshIndex] += meshValue * changeValueSpeed;
        skinnedMeshRenderer.SetBlendShapeWeight(meshIndex, blendShapeValueList[meshIndex]);

        //movement
        Vector3 camright = Vector3.ProjectOnPlane(cam.transform.right, Vector3.up);
        Vector3 camforward = Vector3.ProjectOnPlane(cam.transform.forward, Vector3.up);
        movementDirection = camforward * moveValue.y + camright * moveValue.x;

        if (movementDirection != Vector3.zero)
        {
            //rig.velocity = new Vector3(movementDirection.x * moveSpeed, rig.velocity.y, movementDirection.z * moveSpeed);
            transform.position += movementDirection * 0.01f;
            transform.rotation = Quaternion.LookRotation(movementDirection);

            Debug.Log(camright);
            Debug.Log(camforward);
        }
    }
}