using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BodyPartControllerFemale : MonoBehaviour
{
    GameObject bodyShape;
    SkinnedMeshRenderer skinnedMeshRenderer;
    public float changeSpeed = 1f;
    float changeValue;
    public string blendShapeName;
    public AnimationCurve curveX;
    Mesh skinnedMesh;
    public float restriction = 150;
    public float delayTime = 0f;
    float timeRecord;

    // Start is called before the first frame update

    void Start()
    {
        bodyShape = gameObject.transform.Find("G3F").gameObject;
        skinnedMeshRenderer = bodyShape.GetComponent<SkinnedMeshRenderer>();
        skinnedMesh = skinnedMeshRenderer.sharedMesh;

        changeValue = 0f;

        curveX.postWrapMode = WrapMode.PingPong;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= delayTime)
        {
            if (changeValue > restriction || changeValue < 0)
            {
                changeSpeed *= -1;
            }

            skinnedMeshRenderer.SetBlendShapeWeight(skinnedMesh.GetBlendShapeIndex(blendShapeName), changeValue * curveX.Evaluate(Time.time - delayTime));
            changeValue += changeSpeed;
        }

    }
}
