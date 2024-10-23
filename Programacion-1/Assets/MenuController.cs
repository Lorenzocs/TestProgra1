using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject panelCredits;
    public GameObject panelMenu;
    public TextMeshProUGUI title;

    public void GoToMenu()
    {
        panelCredits.SetActive(false);
        panelMenu.SetActive(true);
        title.text = "Menu";
    }

    public void GoToCredits()
    {
        panelCredits.SetActive(true);
        panelMenu.SetActive(false);
        title.text = "Credits";
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
