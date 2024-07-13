using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PleaseWork : MonoBehaviour
{
    public CharacterController2D controller;

    public GameObject camera1;

    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;
    public bool change = true;
    public int hp = 100;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("change")){
            change =! change;
            
        }
            if(change){
                camera1.SetActive(true);
                horizontalMove = Input.GetAxisRaw("Horizontal")* runSpeed;
                if (Input.GetButtonDown("Jump"))
                {
                    jump = true;
                }
        }
    } 

    public void OnLanding(){
    }

    void FixedUpdate(){
        
        controller.Move(horizontalMove* Time.fixedDeltaTime, false, jump);
        jump = false;
    }
    public void TakeDamage(int damage){
        hp -= damage;
    }
    
}
