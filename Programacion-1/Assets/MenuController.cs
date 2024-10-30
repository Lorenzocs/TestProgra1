using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
public class MenuController : MonoBehaviour
{
    public CanvasGroup panelCredits;
    public CanvasGroup panelMenu;
    public TextMeshProUGUI title;

    private void Start()
    {
        DOTween.Init();
    }

    public void GoToMenu()
    {
        panelCredits.DOFade(0, 1).OnComplete(() => ActiveObject(panelCredits.gameObject, false));
        panelMenu.gameObject.SetActive(true);
        panelMenu.DOFade(1, 1).SetDelay(1);
        title.text = "Menu";
    }

    public void GoToCredits()
    {
        panelMenu.DOFade(0, 1).OnComplete(  ()=> ActiveObject(panelMenu.gameObject,false));
        panelCredits.gameObject.SetActive(true);
        panelCredits.DOFade(1, 1).SetDelay(1);
        title.text = "Credits";
    }

    public void ActiveObject(GameObject go,bool state)
    {
        go.SetActive(state);
    }



    public void GoToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void GoToSceneInt(int sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
