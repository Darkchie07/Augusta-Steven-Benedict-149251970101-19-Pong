using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 speed;
    public Vector2 resetPosition;
    private Rigidbody2D rig;
    private float timer;
    public int nabrak;
    public bool isLeft;

    private void Start() {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
        nabrak = 0;
    }

    private void Update() {
        if(gameObject.GetComponent<Renderer>().enabled == false){
            timer += Time.deltaTime;
            if(timer > 5){
                gameObject.GetComponent<Renderer>().enabled = true;
                timer = 0;
            }
        }
    }

    public void ResetBall(){  
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 2);
        rig.velocity = speed;
        gameObject.GetComponent<Renderer>().enabled = true;
        nabrak = 0;
    }

    public void ActivatePUSpeedUp(float magnitude){
        rig.velocity *= magnitude;
    }

    public void ActivatePUInvisible(){
        gameObject.GetComponent<Renderer>().enabled = false;
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "RightPad")
        {
            isLeft = false;
            nabrak += 1;
        }else if(collision.gameObject.tag == "LeftPad"){
            isLeft = true;
            nabrak += 1;
        }
    }
}
