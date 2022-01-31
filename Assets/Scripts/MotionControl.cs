using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MotionControl : MonoBehaviour
{
    private NavMeshAgent agent;
    [HideInInspector] public bool isRun = false;

    void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        if(agent.hasPath)
        {
            isRun = true;
        }
        else
        {
            isRun = false;
        }
    }
    public void Move(Vector3 target)
    {
        agent.speed = gameObject.GetComponent<Player>().SettingGameValues.GetSpeedPlayer;
        agent.SetDestination(target);
    }
}
