// Patrol.cs
using UnityEngine;
using UnityEngine.AI;
using System.Collections;


public class AiTest : MonoBehaviour
{

    public Transform[] Targetpoints;
    private int destPoint = 0;
    private NavMeshAgent agent;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();//get agent
        agent.autoBraking = false;

        GotoNextPoint();
    }


    void GotoNextPoint()
    {
        //check point
        if (Targetpoints.Length == 0)
            return;

        //set target
        agent.destination = Targetpoints[destPoint].position;

        //set next target
        destPoint = (destPoint + 1) % Targetpoints.Length;
    }


    void Update()
    {
  //set next dest
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
            GotoNextPoint();
    }
}