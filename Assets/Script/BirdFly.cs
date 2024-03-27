using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    // Start is called before the first frame update
    public Animator animator;
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
        if ((Input.GetMouseButtonDown(0)))
        {
            // We could get the component by using unity
            //Rigidbody2D rigidbody2D = this.GetComponent<Rigidbody2D>();
            //this is change the instantenous velocity to 4m/s upward
            rigidbody2D.velocity = new Vector2(0, 4);
        }
    }
}
