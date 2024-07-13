using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class Combat : MonoBehaviour
{
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    public int playerDamage = 20;

    public float attackRate = 2f;
    float nextAttackTime = 0f;

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= nextAttackTime){
            if (Input.GetKeyDown(KeyCode.RightShift)){
                Attack();
                nextAttackTime = Time.time + 1f/attackRate;
            }
        }
    }
    public void Attack(){
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        foreach(Collider2D enemy in hitEnemies){
            enemy.GetComponent<Health>().TakeDamage(playerDamage);
            Debug.Log("We hit" + enemy.name);
        }
    }
    void OnDrawGizmosSelected(){
        if(attackPoint == null){
            return;
        }
        Gizmos.DrawWireSphere(attackPoint.position,attackRange);
    }
}
