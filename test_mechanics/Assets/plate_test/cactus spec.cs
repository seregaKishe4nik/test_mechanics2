using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cactusspec : Test_trap {

    
    public float attackRate = 0.5f;
    public float nextattackTime = 0f;    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= nextattackTime){
            Attack();
            nextattackTime = Time.time +attackRate;
        }
    }
}
