using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDoJogador : MonoBehaviour
{

    public float velocidadeDoJogador;

    public float xMinimo;
    public float xMaximo;
    

    // Update is called once per frame
    void Update()
    {
        MovimentarJogador(GetTransform());
        
    }

    private Transform GetTransform()
    {
        return transform;
    }

    private void MovimentarJogador(Transform transform)



        
        {
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, xMinimo, xMaximo), transform.position.y);
        {

        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * velocidadeDoJogador * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * velocidadeDoJogador * Time.deltaTime);
        }
          }

}
