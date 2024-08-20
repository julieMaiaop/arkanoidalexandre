using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public enum PowerUpType { ExpandPaddle, SpeedUpBall, ExtraBall }
    public PowerUpType powerUpType;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Paddle"))
        {
            switch (powerUpType)
            {
                case PowerUpType.ExpandPaddle:
                    collision.gameObject.transform.localScale += new Vector3(1, 0, 0);
                    break;
                case PowerUpType.SpeedUpBall:
                    if (Ball.instance != null)
                    {
                        Ball.instance.SpeedUp();
                    }
                    break;
                case PowerUpType.ExtraBall:
                    if (Ball.instance != null)
                    {
                        Instantiate(Ball.instance, Ball.instance.transform.position, Quaternion.identity);
                    }
                    break;
            }
            Destroy(gameObject); // Remove o power-up após a coleta
        }
    }
}
