using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using System;

public class BodyPartControllerMaleBackup2 : MonoBehaviour
{
    GameObject bodyShape;
    SkinnedMeshRenderer skinnedMeshRenderer;
    Mesh skinnedMesh;

    public float changeSpeed = 10f;
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

    // Start is called before the first frame update
    private void Awake()
    {
        controls = new PlayerControls();

        bodyShape = gameObject.transform.Find("G3M").gameObject;
        skinnedMeshRenderer = bodyShape.GetComponent<SkinnedMeshRenderer>();
        skinnedMesh = skinnedMeshRenderer.sharedMesh;

        meshNumber = skinnedMesh.blendShapeCount;


        //create a list of mesh values
        blendShapeValueList = new List<float>();
        for (int i = 0; i < meshNumber; i++)
        {
            blendShapeValueList.Add(skinnedMeshRenderer.GetBlendShapeWeight(i));
        }


        //controls.GamePlay.BodyShapeAddition.performed += ctx => BodyShapeAdd();

        controls.GamePlay.BodyShapeAddition.performed += ctx => meshValue = ctx.ReadValue<float>();
        controls.GamePlay.BodyShapeAddition.canceled += ctx => meshValue = 0f;

        controls.GamePlay.BlendShapeSwitch.performed += ctx => switchSpeed = ctx.ReadValue<float>();
        controls.GamePlay.BlendShapeSwitch.canceled += ctx => switchSpeed = 0f;
    }


    private void OnEnable()
    {
        //controls.GamePlay.BodyShapeAddition.performed += bodyShapeadd;
        //controls.GamePlay.BodyShapeAddition.Enable();

        //controls.GamePlay.BlendShapeSwitch.performed += blendSwitch;
        //controls.GamePlay.BlendShapeSwitch.Enable();

        controls.GamePlay.Enable();

    }


    private void OnDisable()
    {
        //controls.GamePlay.BodyShapeAddition.performed -= bodyShapeadd;
        //controls.GamePlay.BodyShapeAddition.Disable();

        //controls.GamePlay.BlendShapeSwitch.performed -= blendSwitch;
        //controls.GamePlay.BlendShapeSwitch.Disable();

        controls.GamePlay.Disable();
    }

    //private void bodyShapeadd(InputAction.CallbackContext context)
    //{
    //    meshValue = context.ReadValue<float>();       
    //}

    //private void blendSwitch(InputAction.CallbackContext context)
    //{
    //    switchSpeed = context.ReadValue<float>();
    //}


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
        float timeCompare = Time.time - timeRecord;
        
        if (timeCompare >= timeCounts && switchSpeed != 0) 
        {
            changeIndexTimer();

            timeRecord = Time.time;
            timeCounts = 1f + changeIndexSpeed - Math.Abs(switchSpeed);

            Debug.Log(meshIndex);
            Debug.Log(switchSpeed);
        }

        indexName.text = skinnedMesh.GetBlendShapeName(meshIndex);
        indexValue.text = "Value:" + (int)skinnedMeshRenderer.GetBlendShapeWeight(meshIndex);

        blendShapeValueList[meshIndex] += meshValue * changeSpeed;
        skinnedMeshRenderer.SetBlendShapeWeight(meshIndex, blendShapeValueList[meshIndex]);

    }

}