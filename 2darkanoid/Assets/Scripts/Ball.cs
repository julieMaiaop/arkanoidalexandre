using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public static Ball instance;  // Singleton para f�cil acesso
    private Rigidbody2D rb;
    public float speedMultiplier = 1.5f;

    void Awake()
    {
        // Inicializa o singleton
        if (instance == null)
        {
            instance = this;
        }
        rb = GetComponent<Rigidbody2D>();
    }

    // M�todo para aumentar a velocidade da bola
    public void SpeedUp()
    {
        rb.velocity *= speedMultiplier;
    }
}
