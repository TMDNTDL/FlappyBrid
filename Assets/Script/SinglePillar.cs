using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinglePillar : MonoBehaviour
{
    public float moveSpeed = 1.5f;
    public bool canMove = true;
    public void FixedUpdate()
    {
        if (!canMove) return;
        transform.Translate(-moveSpeed,0,0);
    }
    public void RandomHeight()
    {
        //-0.36
        //-3
        float r = Random.Range(-3f, -0.35f);
        /*float currrentY = transform.position.y;
        Debug.Log("Current Y: " + currrentY);
        Debug.Log("Random value: " + r);
        float differnce = -(currrentY - r);*/
        /*transform.position.Set(transform.position.x, r, transform.position.z);*/

        /*transform.Translate(0, differnce, 0);
        Debug.Log("Difference: " + differnce);*/
        Debug.Log("Current Y: " + transform.position.y);
        Debug.Log("Random value: " + r);
        /*transform.SetPositionAndRotation(new Vector3(transform.position.x,r,transform.position.z),transform.rotation);*/
        Vector2 v = transform.localPosition;
        v.y = r;
        transform.localPosition = v;
        Debug.Log("after Current Y: " + transform.position.y);
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // stop the background movement
        GameObject.Find("UIController").GetComponent<StaticUIManage>().GameOver();
        //stop the pillar
        GameObject.Find("PillarController").GetComponent<PillarMovement>().StopMove();
    }
}
