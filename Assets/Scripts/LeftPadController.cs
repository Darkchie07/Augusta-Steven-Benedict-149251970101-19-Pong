using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPadController : MonoBehaviour
{
    private Rigidbody2D rig;
    public float timer;
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;

    private void Start() {
        rig = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(speed != 4){
            timer += Time.deltaTime;
            if(timer >= 5){
                speed /= 2;
                timer = 0;
            }
        }
        moveObject(GetInput());
    }
    
    private Vector2 GetInput(){
        if(Input.GetKey(upKey)){
            return Vector2.up * speed;
        }else if(Input.GetKey(downKey)){
            return Vector2.down * speed;
        }

        return Vector2.zero;
    }

    private void moveObject(Vector2 movement){
        Debug.Log("Kecepatan Pedal : " + movement);
        rig.velocity = movement;
    }
}
