using UnityEngine;

using System.Collections;

using UnityEngine.AI;


[RequireComponent(typeof(NavMeshAgent))]

public class Enemy_Controller : MonoBehaviour

{

    public Transform Target;

    public float UpdateSpeed = 0.1f;

    private NavMeshAgent Agent;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()

    {

        Agent = GetComponent<NavMeshAgent>();

    }

    void Update()

    {

        StartCoroutine(FollowTarget());

    }

   private IEnumerator FollowTarget()

   {

      WaitForSeconds  wait = new WaitForSeconds(UpdateSpeed);

      while (enabled)

       {

Agent.SetDestination(Target.transform.position);

          yield return wait;

       }

   }

}

