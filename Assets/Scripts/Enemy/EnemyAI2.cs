using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI2 : MonoBehaviour
{
  [SerializeField] Transform target;
  [SerializeField] float chaseRange = 7f;
  [SerializeField] float turnSpeed = 5f;
  NavMeshAgent navMeshAgent;
  float distanceToTarget = Mathf.Infinity;
  bool isProvoked= false;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        distanceToTarget = Vector3.Distance(target.position, transform.position); 
        if (isProvoked)
        {
            EngageTarget();
        }
        else if (distanceToTarget <= chaseRange)
        {
         isProvoked = true;
        
        }
    }

        public void OnDamageTaken()
        {
            isProvoked = true;
        }

         private void EngageTarget()
    {
        FaceTarget();
         if(distanceToTarget >= navMeshAgent.stoppingDistance)
        {
            ChaseTarget();
        }
        if(distanceToTarget <= navMeshAgent.stoppingDistance)
        {
           AttackTarget();
        }
        
    }

    void ChaseTarget()
    {
        GetComponent<Animator>().SetBool("attack", false);
        GetComponent<Animator>().SetTrigger("move");
        navMeshAgent.SetDestination(target.position);
    }

    private void AttackTarget()
    {
         GetComponent<Animator>().SetBool("attack", true);
        //Debug.Log(name+ "attack" + target.name);
    }

    private void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position). normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x,0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * turnSpeed);
    }

     void OnDrawGizmosSelected()
      {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position,chaseRange);
      }
}
