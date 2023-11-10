using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ButtonMenu : MonoBehaviour
{

    [SerializeField] private float timeHighlight;
    [SerializeField] private float scaleAfterClick;


    public void ButtonClicked(string _scene)
    {
        if (MenuManager.Instance.GetUIBlocked()) return;

        MenuManager.Instance.SetNextScene(_scene);
        MenuManager.Instance.LockUI();

        StartCoroutine(HighLightButton());

    }

    IEnumerator HighLightButton()
    {
        transform.DOScale(scaleAfterClick, timeHighlight / 2);
        yield return new WaitForSeconds(timeHighlight / 2);
        transform.DOScale(1, timeHighlight / 2).SetEase(Ease.OutBounce);
        yield return new WaitForSeconds(timeHighlight / 2);

        MenuManager.Instance.ExitAnimation();
    }
}
