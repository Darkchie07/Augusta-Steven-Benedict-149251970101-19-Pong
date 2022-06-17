using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PULongController : MonoBehaviour
{
    public PadelController padelController;
    public PowerUpManager manager;
    public Collider2D ball;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision == ball)
        {
            padelController.ActivatePULong();
            manager.RemovePowerUp(gameObject);
        }
    }
}
