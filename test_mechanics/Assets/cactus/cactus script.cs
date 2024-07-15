using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class cactus_script : MonoBehaviour
{

    public Transform attackPoint;
    public Transform attackPoint2;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    public int playerDamage = 20;

    
    public float attackRate = 2f;
    float nextAttackTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {if(Time.time >= nextAttackTime){

            Attack();
            nextAttackTime = Time.time + 1f/attackRate;
        }
    }

    public void Attack(){
        Collider2D[] hitPlayers = Physics2D.OverlapAreaAll(attackPoint.position,attackPoint2.position,enemyLayers);
        
        
        foreach(Collider2D player in hitPlayers){
            player.GetComponent<PleaseWork>().TakeDamage(playerDamage);
            Debug.Log("We hit" + player.name);
        }
    }

    void OnDrawGizmosSelected(){
        if(attackPoint == null){
            return;
        }
        Gizmos.DrawWireSphere(attackPoint.position,attackRange);
    }
}
