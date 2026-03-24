using UnityEngine;
using UnityEngine.AI;

public class enemigo : MonoBehaviour
{

    public Transform pointA;
    public Transform pointB;

    private NavMeshAgent agent;
    private Transform target;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = pointA;
    }

    void Update()
    {
        agent.SetDestination(target.position);

        if (Vector3.Distance(transform.position, target.position) < 1f)
        {
            target = target == pointA ? pointB : pointA;
        }
    }
}

