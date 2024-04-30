using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;

public class StaticUIManage : MonoBehaviour
{
    public GameObject tut;
    public GameObject score;
    public GameObject main;
    public void PlayBtnClick()
    {
        main.GetComponent<UIMANAGE>().HideUI();
        tut.GetComponent<UIMANAGE>().ShowUI();
        score.GetComponent<UIMANAGE>().ShowUI();
    }
}
