using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_trap: MonoBehaviour
{
    public Transform attackPointer;
    public float attackRange = 0.5f;
    public LayerMask layer;
    public int attackDamage;
    
    

    public void TrapDisabler(){
        gameObject.SetActive(false);
    }
    public void Attack(){
        Collider2D[] hitPlayers = Physics2D.OverlapCircleAll(attackPointer.position,attackRange,layer);

        foreach (Collider2D player in hitPlayers)
        {
            player.GetComponent<PleaseWork>().TakeDamage(20);
        }
    }

    void OnDrawGizmosSelected(){
        if (attackPointer == null){
            return;
        }
        Gizmos.DrawWireSphere(attackPointer.position, attackRange);
    }
   
}
