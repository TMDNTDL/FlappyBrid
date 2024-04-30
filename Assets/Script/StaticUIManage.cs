using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;

public class StaticUIManage : MonoBehaviour
{
    public GameObject tut;
    public GameObject score;
    public GameObject main;
    public GameObject bird;
    public bool GameReady = false;
    public bool startGame = false;
    public void PlayBtnClick()
    {
        main.GetComponent<UIMANAGE>().HideUI();
        tut.GetComponent<UIMANAGE>().ShowUI();
        score.GetComponent<UIMANAGE>().ShowUI();
        GameReady = true;
    }
    private void Update()
    {
       if(Input.GetMouseButtonDown(0) && GameReady)
        {
            if (startGame) return;
            startGame = true;
            tut.GetComponent<UIMANAGE>().HideUI();
            bird.GetComponent<NewBehaviourScript>().changeState(true);
        }
    }
}
