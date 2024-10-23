using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform player;  // El objeto jugador que la c�mara seguir�
    public float smoothSpeed = 0.125f;  // Velocidad de suavizado para el movimiento de la c�mara
    public Vector3 offset;  // Desplazamiento de la c�mara con respecto al jugador

    void LateUpdate()
    {
        // Posici�n deseada de la c�mara basada en la posici�n del jugador y el offset
        Vector3 desiredPosition = player.position + offset;

        // Suavizar el movimiento de la c�mara usando Lerp para un efecto m�s suave
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Actualizar la posici�n de la c�mara
        transform.position = smoothedPosition;
    }
}
