using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FADE : MonoBehaviour
{
    public CanvasGroup canvasGroup;  // Referencia al CanvasGroup
    public float fadeSpeed = 2.0f;   // Velocidad de transici�n
    private float targetAlpha = 1.0f;  // Opacidad objetivo

    void Update()
    {
        // Usar Lerp para suavizar la transici�n de opacidad
        canvasGroup.alpha = Mathf.Lerp(canvasGroup.alpha, targetAlpha, Time.deltaTime * fadeSpeed);
    }

    // M�todo para hacer un fade-in
    public void FadeIn()
    {
        canvasGroup.gameObject.SetActive(true);
        targetAlpha = 1.0f;  // Objetivo: opacidad m�xima
        canvasGroup.interactable = true;
        canvasGroup.blocksRaycasts = true;
    }

    // M�todo para hacer un fade-out
    public void FadeOut()
    {
        targetAlpha = 0.0f;  // Objetivo: opacidad m�nima
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;
    }
}
