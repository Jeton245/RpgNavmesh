using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System;


public class MoveTo : MonoBehaviour
{
    public Transform[] points;
    public Transform[] checkPoints;
    public Transform[] chillPoints;

    private int destPoint = 0;
    private NavMeshAgent agent;
    
    public bool pitchforkCheck = false;
    public bool beeInPosition = false;
    
   



    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        
        agent.autoBraking = false;
        GotoNextPoint();

    }
    void GotoNextPoint()
    {

        if (points.Length == 0)
            return;
        if (agent.remainingDistance < 0.5f)
        {
            agent.destination = checkPoints[destPoint].position;
            destPoint = (destPoint + 1) % checkPoints.Length;

        }
       
    }
    void GotoWork()
    {
        if (points.Length == 0)
            return;
        if (agent.remainingDistance < 0.5f) {
            agent.destination = points[destPoint].position;
            destPoint = (destPoint + 1) % points.Length;
        }
         

    }
    void GotoChill()
    {
        if (points.Length == 0)
            return;

        agent.destination = chillPoints[destPoint].position;
        destPoint = (destPoint + 1) % chillPoints.Length;
    }
    void Update()
    {
        if (pitchforkCheck == true && beeInPosition == true)
        {
            GotoWork();
        } else if (pitchforkCheck == false && beeInPosition == true)
        {
            GotoChill();
        }
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Pitchfork")
        {
            pitchforkCheck = true;
            beeInPosition = true;


        }
        else
        {
            pitchforkCheck = false;
            beeInPosition = true;
        }
    }
        
    
}



