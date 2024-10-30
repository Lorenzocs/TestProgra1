using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FADE : MonoBehaviour
{
    public CanvasGroup canvasGroup;  // Referencia al CanvasGroup
    public float fadeSpeed = 2.0f;   // Velocidad de transición
    private float targetAlpha = 1.0f;  // Opacidad objetivo

    void Update()
    {
        // Usar Lerp para suavizar la transición de opacidad
        canvasGroup.alpha = Mathf.Lerp(canvasGroup.alpha, targetAlpha, Time.deltaTime * fadeSpeed);
    }

    // Método para hacer un fade-in
    public void FadeIn()
    {
        canvasGroup.gameObject.SetActive(true);
        targetAlpha = 1.0f;  // Objetivo: opacidad máxima
        canvasGroup.interactable = true;
        canvasGroup.blocksRaycasts = true;
    }

    // Método para hacer un fade-out
    public void FadeOut()
    {
        targetAlpha = 0.0f;  // Objetivo: opacidad mínima
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;
    }
}
