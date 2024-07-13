using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acid_script : MonoBehaviour
{

    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    public Transform attackPoint2;
    public int playerDamage = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Attack(){
        Collider2D[] hitEnemies = Physics2D.OverlapAreaAll(attackPoint2.position,attackPoint2.position,enemyLayers);

        foreach(Collider2D player in hitEnemies){
            player.GetComponent<PleaseWork>().TakeDamage(10);
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
