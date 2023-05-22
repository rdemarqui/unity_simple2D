using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootTrap : MonoBehaviour
{
    public GameObject tiro;
    private float tempoTiro;

    private void FixedUpdate()
    {
        tempoTiro = tempoTiro + Time.deltaTime;
        if (tempoTiro > 2)
        {
            Instantiate(tiro, transform.position, Quaternion.Euler(0, 0, 270));
            tempoTiro = 0;
        }
    }
}
