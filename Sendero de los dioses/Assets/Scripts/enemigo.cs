using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemigo : MonoBehaviour
{
   Transform target;
   public float lookRadius=10f;
   NavMeshAgent agent;
   float speed = 3.0f, movespeed=3.0f;
    void Start()
    {

        // ObjectToFollow = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        target=GameObject.FindGameObjectWithTag("Player").transform;
        agent= GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update(){
     float distance= Vector3.Distance(target.position,transform.position);

     if(distance<=lookRadius){
         agent.SetDestination(target.position);
     }

    }

}
