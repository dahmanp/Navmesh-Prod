using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentControl : MonoBehaviour
{
    public Transform home;
    NavMeshAgent agent;
    public string homeTag = "PinkHome";

    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
        home = FindHomeByTag(homeTag);
        agent.SetDestination(home.position);
    }

    void Update()
    {
        if (home != null)
        {
            agent.SetDestination(home.position);
        }
    }

    Transform FindHomeByTag(string tag)
    {
        GameObject homeObject = GameObject.FindGameObjectWithTag(tag);
        return homeObject.transform;
    }
}
