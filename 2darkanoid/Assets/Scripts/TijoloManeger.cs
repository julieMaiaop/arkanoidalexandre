using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TijoloManeger : MonoBehaviour
{
    public GameObject brickPrefab;
    public int rows = 5;
    public int cols = 10;
    public Color[] brickColors;

    void Start()
    {
        GenerateBricks();
    }

    void GenerateBricks()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (Random.value > 0.5f) // Controla a aleatoriedade dos tijolos
                {
                    Vector3 position = new Vector3(j * 1.1f, i * 0.6f, 0);
                    GameObject brick = Instantiate(brickPrefab, position, Quaternion.identity);
                    Renderer brickRenderer = brick.GetComponent<Renderer>();
                    brickRenderer.material.color = brickColors[Random.Range(0, brickColors.Length)];
                }
            }
        }
    }
}
