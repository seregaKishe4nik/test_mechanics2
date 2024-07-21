using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PleaseWork : MonoBehaviour
{
    public CharacterController2D controller;

    public GameObject camera1;

    public float runSpeed = 40f;
    float horizontalMove = 0f;
    public Transform GrabPoint;
    public Transform LetGoPoint;
    public Animator animator;
    bool jump = false;
    bool crouch = false;
    public bool change = true;
    public int hp = 100;
    public bool JessieIsGrabbed = false;
    public LayerMask JessieLayer;
    Collider2D current_state;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("change") && JessieIsGrabbed == false){
            change =! change;
        }
        if(Input.GetButtonDown("JessieGrab")){
            if(JessieIsGrabbed){
                current_state.gameObject.SetActive(true);
                current_state.transform.position = LetGoPoint.position;
                JessieIsGrabbed = false;
                
            animator.SetBool("JessieIsGrabbed",false);
            }
            current_state = GrabPlayer();

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
    Collider2D GrabPlayer(){
        Collider2D[] JessieCheck = Physics2D.OverlapCircleAll(GrabPoint.position, 0.5f,JessieLayer);

        foreach(Collider2D jessie in JessieCheck){
            
            JessieIsGrabbed = !JessieIsGrabbed;
            jessie.gameObject.SetActive(false);
            animator.SetBool("JessieIsGrabbed",true);
            return jessie;
        }
        return null;;
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
