using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class doorUnlock : MonoBehaviour
{
    public int enter = 0;
    public bool foxEntered = false;
    public bool VultureEntered = false;
    public GameObject door;
    public Collider2D Colider;
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Fox")
        {
            foxEntered = true;
 
        }
        if(other.gameObject.tag == "Vulture" )
        {
            VultureEntered = true;

        }
        
    }
    void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.tag == "Fox")
        {
            foxEntered = false;

        }
        if(other.gameObject.tag == "Vulture")
        {
            VultureEntered = false;
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(foxEntered ==true && VultureEntered == true)
        {
        Destroy(door);
        }
        
    }
}
