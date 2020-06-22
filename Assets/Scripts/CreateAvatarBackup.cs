using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using System;

public class CreateAvatarBackup : MonoBehaviour
{
    //spawn avatar as a list
    public GameObject maleAvatar;
    public GameObject femaleAvater;
    GameObject avatarGameObject;

    //avatar generate
    PlayerControls controls;
    int avatarControlIndex = -1;

    //blend shape
    GameObject bodyShape;
    SkinnedMeshRenderer skinnedMeshRenderer;
    Mesh skinnedMesh;

    //shape changing attribute
    public float changeValueSpeed = 10f;
    public float changeIndexSpeed = 0.2f;
    int meshNumber;

    List<float> blendShapeValueList;
    int meshIndex = 0;

    float meshValue;
    float switchSpeed;
    float timeRecord = 0f;
    float timeCounts = 0f;

    //interfact
    public Text indexName;
    public Text indexValue;

    //movement value
    Vector2 moveValue;
    public GameObject cam;
    Vector3 movementDirection;
    public float moveSpeed = 1f;

    private void Awake()
    {
        //avatar gameobject and list
        avatarGameObject = new GameObject("AvatarGameObejct");

        //create a list of mesh values
        blendShapeValueList = new List<float>();

        //create a avatar
        maleSpawn();

        //movement assets
        cam = Camera.main.gameObject;

        //input controller
        controls = new PlayerControls();
        controls.GamePlay.MaleSpawn.performed += _ => maleSpawn();
        controls.GamePlay.FemaleSpawn.performed += _ => femaleSpawn();

        controls.GamePlay.BodyShapeAddition.performed += ctx => meshValue = ctx.ReadValue<float>();
        controls.GamePlay.BodyShapeAddition.canceled += ctx => meshValue = 0f;

        controls.GamePlay.BlendShapeSwitch.performed += ctx => switchSpeed = ctx.ReadValue<float>();
        controls.GamePlay.BlendShapeSwitch.canceled += ctx => switchSpeed = 0f;

        controls.GamePlay.Movement.performed += ctx => moveValue = ctx.ReadValue<Vector2>();
        controls.GamePlay.Movement.canceled += ctx => moveValue = Vector2.zero;

        //controls.GamePlay.Reset.performed += _ => resetListValue();
    }

    private void maleSpawn()
    {
        avatarGameObject = Instantiate(maleAvatar, new Vector3(0, 0, 0), Quaternion.identity);

        //find the mesh target list
        bodyShape = avatarGameObject.transform.Find("G3M").gameObject;
        skinnedMeshRenderer = bodyShape.GetComponent<SkinnedMeshRenderer>();
        skinnedMesh = skinnedMeshRenderer.sharedMesh;

        //get int of the list
        meshNumber = skinnedMesh.blendShapeCount;

        //reset a list of mesh values
        blendShapeValueList.Clear();
        for (int i = 0; i < meshNumber; i++)
        {
            blendShapeValueList.Add(skinnedMeshRenderer.GetBlendShapeWeight(i));
        }

        //reset meshindex
        meshIndex = 0;
    }

    private void femaleSpawn()
    {
        avatarGameObject = Instantiate(femaleAvater, new Vector3(0, 0, 0), Quaternion.identity);

        //find the mesh target list
        bodyShape = avatarGameObject.transform.Find("G3M").gameObject;
        skinnedMeshRenderer = bodyShape.GetComponent<SkinnedMeshRenderer>();
        skinnedMesh = skinnedMeshRenderer.sharedMesh;

        //get int of the list
        meshNumber = skinnedMesh.blendShapeCount;

        //reset a list of mesh values
        blendShapeValueList.Clear();
        for (int i = 0; i < meshNumber; i++)
        {
            blendShapeValueList.Add(skinnedMeshRenderer.GetBlendShapeWeight(i));
        }

        //reset meshindex
        meshIndex = 0;
    }

    private void resetListValue()
    {
        for (int i = 0; i < meshNumber; i++)
        {
            blendShapeValueList[i] = 0;
            skinnedMeshRenderer.SetBlendShapeWeight(i, 0);
        }
    }

    void changeIndexTimer()
    {
        if (switchSpeed > 0)
        {
            meshIndex += 1;
        }
        else if (switchSpeed < 0)
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
            avatarGameObject.transform.position += movementDirection * 0.01f;
            avatarGameObject.transform.rotation = Quaternion.LookRotation(movementDirection);
        }

    }


}
