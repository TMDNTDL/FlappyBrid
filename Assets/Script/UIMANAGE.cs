using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Security.Principal;
public class UIMANAGE : MonoBehaviour
{
    public CanvasGroup cGroup;
    public float time = 0.5f;
    public void ShowUI()
    {
        cGroup.DOFade(1, time);
    }
    public void HideUI()
    {
        cGroup.DOFade(0, time).onComplete =() =>
        {
            gameObject.SetActive(false);
        };

    }
}
