using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarMovement : MonoBehaviour
{
    public GameObject Prefix;
    public Transform PillarParent;
    public StaticUIManage coltroller;
    public float SpawnTime = 2f;
    private List<GameObject> GP = new List<GameObject>();
    public bool moved = true;
    public void Start()
    {
        StartCoroutine(SpawnPillar());
    }
    public void StartMove()
    {
        moved = true;
        foreach (GameObject item in GP)
        {
            item.GetComponent<SinglePillar>().canMove = true;
        }
    }
    public void StopMove()
    {
        moved = false;
        foreach(GameObject item in GP)
        {
            item.GetComponent<SinglePillar>().canMove = false;
        }
    }
    public void SpwanOnePillar()
    {
        GameObject pillar = GameObject.Instantiate(Prefix,PillarParent);
        pillar.GetComponent<SinglePillar>().RandomHeight();
        
        GP.Add(pillar);
    }
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.K)) { 
            StopMove();
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            StartMove();
        }
        
    }
    IEnumerator SpawnPillar()
    {
        while (true)
        {
            yield return new WaitForSeconds(SpawnTime);
            if (!coltroller.startGame || !moved) continue;
            SpwanOnePillar();
        }
    }
}
