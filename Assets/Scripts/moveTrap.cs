using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTrap : MonoBehaviour
{
    public float rotationSpeed = 10f; // Velocidade de rota��o em graus por segundo
    public float moveSpeed = 2f; // Velocidade de deslocamento no eixo X
    public float moveDistance = 1.60f; // Dist�ncia total de deslocamento no eixo X

    private void Update()
    {
        // Rota��o em torno do eixo Z
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);

        // Deslocamento no eixo X usando Mathf.PingPong
        float newX = Mathf.PingPong(Time.time * moveSpeed, moveDistance * 2f) - moveDistance;

        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }

}
