using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUInvisibleController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public float timer;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision == ball)
        {
            ball.GetComponent<BallController>().ActivatePUInvisible();
            manager.RemovePowerUp(gameObject);
        }
    }
}
