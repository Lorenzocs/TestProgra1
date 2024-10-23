using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform player;  // El objeto jugador que la cámara seguirá
    public float smoothSpeed = 0.125f;  // Velocidad de suavizado para el movimiento de la cámara
    public Vector3 offset;  // Desplazamiento de la cámara con respecto al jugador

    void LateUpdate()
    {
        // Posición deseada de la cámara basada en la posición del jugador y el offset
        Vector3 desiredPosition = player.position + offset;

        // Suavizar el movimiento de la cámara usando Lerp para un efecto más suave
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Actualizar la posición de la cámara
        transform.position = smoothedPosition;
    }
}
