using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{


    public float velocidadeDaBola;
    public Rigidbody2D oRigidbody2D;
    public bool jogoIniciou;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(jogoIniciou == false)
        {
            //parei na aula 3 minuto 20
        }
    }

    private void MovimentarBolinha()
    {
        oRigidbody2D.velocity = Vector2.up * velocidadeDaBola;
    }
}
