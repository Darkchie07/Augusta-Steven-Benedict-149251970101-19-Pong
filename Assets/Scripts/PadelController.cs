using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadelController : MonoBehaviour
{
    public BallController bola;
    public LeftPadController padelKiri;
    public RightPadController padelKanan;
    public int speed;
    private Rigidbody2D rig;
    public GameObject rightPad;
    public GameObject leftPad;
    Vector3 rightScale;
    Vector3 leftScale;
    Vector3 resetScale;
    private float leftTimer;
    private float rightTimer;
    
    private void Start() {
        resetScale = leftPad.transform.localScale;
    }

    private void Update()
    {
        leftScale = leftPad.transform.localScale;
        rightScale = rightPad.transform.localScale;
    }

    public void resetPad(){
        padelKiri.speed = 4;
        padelKanan.speed = 4;
        leftPad.transform.localScale = resetScale;
        rightPad.transform.localScale = resetScale;
    }

    public void ActivatePULong(){
        if(bola.isLeft && bola.nabrak > 0){
            if(leftScale.y < 3){
                leftScale.y *= 2;
                leftPad.transform.localScale = leftScale;
            }
        }else if(!bola.isLeft && bola.nabrak > 0){
            if(rightScale.y < 3){
                rightScale.y *= 2;
                rightPad.transform.localScale = rightScale;
            }
        }
    }

    public void ActivatePUSpeed(){
        if(bola.isLeft && bola.nabrak > 0){
            if(padelKiri.speed <= 15){
            padelKiri.speed *= 2;
            }
        }else if(!bola.isLeft && bola.nabrak > 0){
            if(padelKanan.speed <= 15){
            padelKanan.speed *= 2;
            }
        }
    }
}
