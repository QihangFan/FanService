using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using System;

public class cameraMovement : MonoBehaviour
{
    PlayerControls controls;
    Vector2 moveValue;
    public GameObject cam;
    Vector3 movementDirection;
    public float moveSpeed = 1f;

    private void Awake()
    {
        controls = new PlayerControls();

        controls.GamePlay.Movement.performed += ctx => moveValue = ctx.ReadValue<Vector2>();
        controls.GamePlay.Movement.canceled += ctx => moveValue = Vector2.zero;

        controls.GamePlay.MaleSpawn.performed += _ => cameraPosReset();
        controls.GamePlay.FemaleSpawn.performed += _ => cameraPosReset();
    }

    private void cameraPosReset()
    {
        transform.position = new Vector3(0f, 0.8f, 0f);
    }

    private void OnEnable()
    {
        controls.GamePlay.Enable();
    }

    private void OnDisable()
    {
        controls.GamePlay.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 camright = Vector3.ProjectOnPlane(cam.transform.right, Vector3.up);
        Vector3 camforward = Vector3.ProjectOnPlane(cam.transform.forward, Vector3.up);
        movementDirection = camforward * moveValue.y + camright * moveValue.x;

        if (movementDirection != Vector3.zero)
        {
            //rig.velocity = new Vector3(movementDirection.x * moveSpeed, rig.velocity.y, movementDirection.z * moveSpeed);
            transform.position += movementDirection * 0.01f;
        }
    }
}
