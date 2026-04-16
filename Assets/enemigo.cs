using UnityEngine;
using UnityEngine.AI;

public class enemigo : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;

    private NavMeshAgent agent;
    private Transform target;
    private Animator animator;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        target = pointA;
    }

    void Update()
    {
        agent.SetDestination(target.position);

        
        Vector3 velocity = agent.velocity;

        
        Vector3 localVelocity = transform.InverseTransformDirection(velocity);

        
        animator.SetFloat("X", localVelocity.x);
        animator.SetFloat("Y", localVelocity.z);

        if (Vector3.Distance(transform.position, target.position) < 1f)
        {
            target = target == pointA ? pointB : pointA;
        }
    }
}


