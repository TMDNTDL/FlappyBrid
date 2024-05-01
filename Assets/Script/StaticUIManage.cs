using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using TMPro;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StaticUIManage : MonoBehaviour
{
    public GameObject tut;
    public GameObject score;
    public GameObject main;
    public GameObject bird;
    public bool GameReady = false;
    public bool startGame = false;
    public TMP_Text ScoreRecord;
    public void PlayBtnClick()
    {
        main.GetComponent<UIMANAGE>().HideUI();
        tut.GetComponent<UIMANAGE>().ShowUI();
        score.GetComponent<UIMANAGE>().ShowUI();
        bird.GetComponent<NewBehaviourScript>().changeState(true,false);
        GameReady = true;
    }
    private void Update()
    {
       if(Input.GetMouseButtonDown(0) && GameReady)
        {
            if (startGame) return;
            startGame = true;
            tut.GetComponent<UIMANAGE>().HideUI();
            bird.GetComponent<NewBehaviourScript>().changeState(true, true);

        }
    }
    //over when collide the pillar
    public void GameOver()
    {
        if (!startGame) return;
        GameReady = false ;
        startGame = false ;
        GameObject.Find("bgs").GetComponent<bgController>().StopMove();
        GameObject.Find("Lands").GetComponent<bgController>().StopMove();
    }
    public void Gainscore()
    {

        ScoreRecord.text = (int.Parse(ScoreRecord.text)+1).ToString();
    }
}
