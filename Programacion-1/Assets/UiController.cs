using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;
public class UiController : MonoBehaviour
{
    public GameObject[] stars;
    public Image bar;
    public RectTransform panelPause;
    public CanvasGroup fondoPausa;

    private void Start()
    {
        DOTween.Init();
       
    }


    public  void ShowPause()
    {
        panelPause.DOAnchorPosY(0,1).SetEase(Ease.InBounce);
        fondoPausa.DOFade(1, 1);
    }

    public  void HidePause()
    {
        panelPause.DOAnchorPosY(1200, 1).SetEase(Ease.InBounce);
        fondoPausa.DOFade(0, 0.5f);
    }


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
