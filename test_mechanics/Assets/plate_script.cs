using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class plate_script : MonoBehaviour
{
    public GameObject[] disabled_list;

    void Start()
    {
        
    }

    public void OnTriggerEnter2D(){
        for (int i = 0; i < disabled_list.Length; i++)
        {
            Test_trap trap_aliksiy =  disabled_list[i].GetComponent<Test_trap>();
            trap_aliksiy.TrapDisabler();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
