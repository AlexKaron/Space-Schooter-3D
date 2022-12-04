using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
   PlayerHealth target;
   [SerializeField] float damage = 40f;

    void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
    }
    
     public void OnDamageTaken()
     {
         Debug.Log (name + "I also know we took damage");
     }


    public void AttackHitEvent()
    {
        if (target==null)return;
        target.TakeDamage(damage);
        Debug.Log("attack hit event");
    }
}
