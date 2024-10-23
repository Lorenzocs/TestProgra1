using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UiController : MonoBehaviour
{
    public GameObject[] stars;
    public Image bar;

    public void UpdateLifes(int lifes)
    {
        for (int i = 0; i < stars.Length; i++)
        {
            if (i < lifes)
            {
                stars[i].SetActive(true);
            }
            else
            {
                stars[i].SetActive(false);
            }
        }
    }

    public void UpdateBar(float lifes)
    {
        print(lifes);
        bar.fillAmount = lifes;
    }

    public void Reset()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);

    }

}
