using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    // Start is called before the first frame update
    public Animator animator;
    public StaticUIManage manager;
    public float dynamic = 4f;
    public Transform birdImgRotate;
    public float birdSpeed = 5f;
    public float rotateTime = 0.3f;
 
    void Start()
    {
        animator.SetInteger("state", 1);
        //we could edit the objects transform data automatically 
        // new Vector3 is to create a new position coordinates
        //transform.position = new Vector3(0, transform.position.y + 0.02f, 0);

    }

    // Update is called once per frame
    void Update()
    {
        // get mouse event, 0 is left click, 1 is right click
        //Input.GetMouseButton(0) 
        // Input.GetMouseButtonDown(0) is method for only one click
        //GetComponent is to get this.Object's other component
        if (Input.GetMouseButtonDown(0)&& manager.startGame)
        {
            // We could get the component by using unity
            //Rigidbody2D rigidbody2D = this.GetComponent<Rigidbody2D>();
            //this is change the instantenous velocity to 4m/s upward
            Fly();
        }
        birdImgRotate.DORotateQuaternion(Quaternion.Euler(0, 0, rigidbody2D.velocity.y * dynamic), rotateTime);
        /*birdImgRotate.transform.rotation = Quaternion.Euler(0,0,rigidbody2D.velocity.y * dynamic);*/
    }
    public void Fly()
    {
        rigidbody2D.velocity = new Vector2(0, birdSpeed);
    }
    public void changeState(Boolean isFly, Boolean isSimulated)
    {
        if (isFly)
        {
            animator.SetInteger("state", 0);
            rigidbody2D.simulated = isSimulated;
        }
        else
        {
            animator.SetInteger("state", 1);
            rigidbody2D.simulated= isSimulated;
        }
    }
}
