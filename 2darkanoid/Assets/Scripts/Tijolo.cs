using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tijolo : MonoBehaviour
{
    public GameObject[] powerUps; // Array com os prefabs dos power-ups
    public float dropChance = 0.2f; // 20% de chance de dropar um power-up

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Verifica se o objeto colidido é a bola
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (Random.value <= dropChance)
            {
                // Dropar power-up aleatório
                int randomIndex = Random.Range(0, powerUps.Length);
                Instantiate(powerUps[randomIndex], transform.position, Quaternion.identity);
            }
            Destroy(gameObject); // Destrói o tijolo
        }
    }
}
