using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menuprincipal : MonoBehaviour
{

    [SerializeField] private string julieCena;
    public void play()
    {
        SceneManager.LoadScene("julieCena");

    }
}
