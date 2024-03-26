using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgController : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 startPos;
    public float speed = -0.2f;
    public float transition = 0f;
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
           if(transform.position.x < -16.23f + transition)
        {
            transform.position = startPos;
        }
        transform.Translate(speed, 0, 0);
    }
}
