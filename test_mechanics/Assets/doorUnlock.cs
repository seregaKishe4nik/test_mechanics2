using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class doorUnlock : MonoBehaviour
{
    public Collider2D Colider;
    public GameObject Fox;
    
    public GameObject Vulture;


    void OnTriggerEnter(Collider other)
    {
        Debug.Log("hello");
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
