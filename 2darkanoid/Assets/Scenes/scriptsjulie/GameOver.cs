using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bola"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }


}
