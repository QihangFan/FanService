using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionController : MonoBehaviour
{
    public float speed1;
    public Vector3 direction1;
    public float speed2;
    public Vector3 direction2;
    public float timeLimit;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(1f, 0.5f, 0.3f);
        if(Time.time < timeLimit)
        {
            transform.position += direction1 * speed1;
        }
        else
        {
            transform.position += direction2 * speed2;
        }
        

    }
}
