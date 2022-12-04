using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;

    public void TakeDamage (float damage)
    {
        //GetComponent<EnemyAI>()OnDamageTaken();
        BroadcastMessage("OnDamageTaken");
        hitPoints -= damage;
        if (hitPoints <=0)
        {
             Destroy(gameObject);
        }
    }
}
