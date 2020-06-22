using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using System;

public class CreateAvatarBackup2 : MonoBehaviour
{
    //spawn avatar as a list
    public GameObject maleAvatar;
    public GameObject femaleAvater;
    GameObject avatarGameObject;
    List<GameObject> avatarList;

    //score systemn
    List<int> avatarScore;
    GameObject bestAvatar;

    //avatar generate
    PlayerControls controls;
    int avatarControlIndex;
    float spawnMale;
    float spawnFemale;

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
    public Text logo;

    //movement value
    Vector2 moveValue;
    public GameObject cam;
    Vector3 movementDirection;
    public float moveSpeed = 1f;

    //game state control
    int gameState = 0;
    public Text startInstruction;
    public Text timerAndScore;

    float gameTimeStart;
    public float gameTime = 30f;
    float returnToMenu;

    //animationController
    Animator animatorObejct;
    float animationOne;
    float animationTwo;
    bool animationGenderSwitch;

    public GameObject maleList;
    public GameObject femaleList;

    private void Awake()
    {
        //logo
        logo.text = "Fan Service";

        //avatar gameobject and list
        avatarGameObject = new GameObject("AvatarGameObejct");
        avatarList = new List<GameObject>();
        avatarScore = new List<int>();

        //create a list of mesh values
        blendShapeValueList = new List<float>();

        //movement assets
        cam = Camera.main.gameObject;


        //spawn default avatar
        GameObject avatarClone = Instantiate(maleAvatar, new Vector3(0, 0, 0), Quaternion.identity, avatarGameObject.transform);
        //avatarClone.transform.Rotate(0f, 180f, 0f, Space.Self);
        avatarClone.SetActive(false);
        avatarList.Add(avatarClone);
        avatarScore.Add(0);
        avatarControlIndex = 0;

        //find the mesh target list
        bodyShape = avatarClone.transform.Find("G3M").gameObject;
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

        //animation is male
        animationGenderSwitch = true;

        maleList.SetActive(false);
        femaleList.SetActive(false);

        //input controller
        controls = new PlayerControls();
        controls.GamePlay.MaleSpawn.performed += ctx => spawnMale = ctx.ReadValue<float>(); //X
        controls.GamePlay.MaleSpawn.canceled += ctx => spawnMale = 0f;

        controls.GamePlay.FemaleSpawn.performed += ctx => spawnFemale = ctx.ReadValue<float>(); //B
        controls.GamePlay.FemaleSpawn.canceled += ctx => spawnFemale = 0f;

        controls.GamePlay.BodyShapeAddition.performed += ctx => meshValue = ctx.ReadValue<float>();
        controls.GamePlay.BodyShapeAddition.canceled += ctx => meshValue = 0f;

        controls.GamePlay.BlendShapeSwitch.performed += ctx => switchSpeed = ctx.ReadValue<float>();
        controls.GamePlay.BlendShapeSwitch.canceled += ctx => switchSpeed = 0f;

        controls.GamePlay.ReturnToMenu.performed += ctx => returnToMenu = ctx.ReadValue<float>();
        controls.GamePlay.ReturnToMenu.canceled += ctx => returnToMenu = 0f;

        controls.GamePlay.Movement.performed += ctx => moveValue = ctx.ReadValue<Vector2>();
        controls.GamePlay.Movement.canceled += ctx => moveValue = Vector2.zero;

        controls.GamePlay.AnimationOne.performed += ctx => animationOne = ctx.ReadValue<float>(); //Y
        controls.GamePlay.AnimationOne.canceled += ctx => animationOne = 0f;

        controls.GamePlay.AnimationTwo.performed += ctx => animationTwo = ctx.ReadValue<float>(); //A
        controls.GamePlay.AnimationTwo.canceled += ctx => animationTwo = 0f;

        controls.GamePlay.MaleListControl.performed += _ => maleList.SetActive(true);
        controls.GamePlay.MaleListControl.canceled += _ => maleList.SetActive(false);

        controls.GamePlay.FemaleListControl.performed += _ => femaleList.SetActive(true);
        controls.GamePlay.FemaleListControl.canceled += _ => femaleList.SetActive(false);

    }

    private void maleSpawn()
    {
        GameObject avatarClone = Instantiate(maleAvatar, new Vector3(0, 0, 0), Quaternion.identity, avatarGameObject.transform);
        avatarClone.transform.Rotate(0f, 180f, 0f, Space.Self);
        avatarList.Add(avatarClone);
        avatarList[avatarControlIndex].SetActive(false);
        avatarScore.Add(0);
        avatarControlIndex += 1;
        

        //find the mesh target list
        bodyShape = avatarClone.transform.Find("G3M").gameObject;
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
        meshIndex = (int)UnityEngine.Random.Range(meshNumber * 0.2f, meshNumber * 0.8f);

        //set animator
        animationGenderSwitch = true;
    }

    private void femaleSpawn()
    {
        GameObject avatarClone = Instantiate(femaleAvater, new Vector3(0, 0, 0), Quaternion.identity, avatarGameObject.transform);
        avatarClone.transform.Rotate(0f, 180f, 0f, Space.Self);
        avatarList.Add(avatarClone);
        avatarList[avatarControlIndex].SetActive(false);
        avatarScore.Add(0);
        avatarControlIndex += 1;

        //find the mesh target list
        bodyShape = avatarClone.transform.Find("G3M").gameObject;
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
        meshIndex = (int)UnityEngine.Random.Range(meshNumber * 0.2f, meshNumber * 0.8f);

        //set animator
        animationGenderSwitch = false;
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
        //state 0 => startmanu
        //state 1 => paly mode
        //state 2 => time is up. look at the finished avater
        //state 3 => return to the main manu

        movementController();
        animationController();

        if (gameState == 0)
        {
            //Start UI (male and female) + highest score + related avater
            startInstruction.text = "Press X to spawn a male avatar" + "\n" + "Press B to spawn a female avatar";
            indexName.text = null;
            indexValue.text = null;

            int highestValue = Mathf.Max(avatarScore.ToArray());
            int highestValueIndex = avatarScore.IndexOf(highestValue);
            bestAvatar = avatarList[highestValueIndex];

            bestAvatar.SetActive(true);
            timerAndScore.text = "Best Record:  " + highestValue;

            if (spawnMale != 0)
            {
                maleSpawn();
                gameState = 1;
                gameTimeStart = Time.time;
            }

            if(spawnFemale != 0)
            {
                femaleSpawn();
                gameState = 1;
                gameTimeStart = Time.time;
            }
        }
        else if (gameState == 1)
        {
            logo.text = null;
            bestAvatar.SetActive(false);
            startInstruction.text = null;
            //text in canvas
            indexName.text = skinnedMesh.GetBlendShapeName(meshIndex);
            indexValue.text = "Value:" + (int)skinnedMeshRenderer.GetBlendShapeWeight(meshIndex);

            blendShapeIndexControl();
            blendShapeValueControl();

            float timeLeft = gameTime - Time.time + gameTimeStart;
            timerAndScore.text = "Time Left:" + (int)timeLeft;
            if (timeLeft <= 0)
            {
                float valueSum = 0f;
                for (int i = 0; i < meshNumber; i++)
                {
                    if(blendShapeValueList[i] >= 0)
                    {
                        valueSum += blendShapeValueList[i];
                    }
                    else if(blendShapeValueList[i] < 0)
                    {
                        valueSum += Math.Abs(blendShapeValueList[i]) * 2;
                    }
                }
                avatarScore[avatarControlIndex] += (int)(valueSum * 0.1f);
                gameState = 2;
            }
        }
        else if(gameState == 2)
        {
            timerAndScore.text = "Your score: " + avatarScore[avatarControlIndex];
            indexName.text = null;
            indexValue.text = null;
            startInstruction.text = "Press MENU to return to the start menu";
            if (returnToMenu != 0)
            {
                gameState = 0;
                avatarList[avatarControlIndex].SetActive(false);
            }
        }

    }

    private void blendShapeIndexControl()
    {
        //update mesh index
        float timeCompare = Time.time - timeRecord;

        if (timeCompare >= timeCounts && switchSpeed != 0)
        {
            changeIndexTimer();

            timeRecord = Time.time;
            timeCounts = 1f + changeIndexSpeed - Math.Abs(switchSpeed);
            avatarScore[avatarControlIndex] += 5;
        }
    }

    private void blendShapeValueControl()
    {
        //change mesh value
        blendShapeValueList[meshIndex] += meshValue * changeValueSpeed;
        skinnedMeshRenderer.SetBlendShapeWeight(meshIndex, blendShapeValueList[meshIndex]);
    }

    private void movementController()
    {
        //movement 
        Vector3 camright = Vector3.ProjectOnPlane(cam.transform.right, Vector3.up);
        Vector3 camforward = Vector3.ProjectOnPlane(cam.transform.forward, Vector3.up);
        movementDirection = camforward * moveValue.y + camright * moveValue.x;

        if (movementDirection != Vector3.zero)
        {
            avatarList[avatarControlIndex].transform.position += movementDirection * 0.01f;
            avatarList[avatarControlIndex].transform.rotation = Quaternion.LookRotation(movementDirection);
        }
    }

    private void animationController()
    {
        animatorObejct = avatarList[avatarControlIndex].GetComponent<Animator>();
        if (animationGenderSwitch)
        {
            if(spawnMale != 0f)
            {
                animatorObejct.SetTrigger("Fight");
            }
            else if(spawnFemale != 0f)
            {
                animatorObejct.SetTrigger("Dance");
            }
            else if (animationOne != 0f)
            {
                animatorObejct.SetTrigger("Beer");
            }
            else if (animationTwo != 0f)
            {
                animatorObejct.SetTrigger("Stalker");
            }
        }
        else if (!animationGenderSwitch)
        {
            if (spawnFemale != 0f)
            {
                animatorObejct.SetTrigger("Fight");
            }
            else if (spawnMale != 0f)
            {
                animatorObejct.SetTrigger("Dance");
            }
            else if (animationOne != 0f)
            {
                animatorObejct.SetTrigger("Beer");
            }
            else if (animationTwo != 0f)
            {
                animatorObejct.SetTrigger("Idle");
            }
        }
    }

}
