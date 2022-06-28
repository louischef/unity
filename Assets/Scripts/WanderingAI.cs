using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class WanderingAI : MonoBehaviour
{

    public float wanderRadius;
    public float wanderTimer;

    private Transform target;
    private NavMeshAgent agent;
    private float timer;
    [SerializeField] Animator anim;

    public float speed = 1.0f;

    // Use this for initialization
    void OnEnable()
    {
        agent = GetComponent<NavMeshAgent>();
        //anim = GetComponent<Animator>();
        timer = wanderTimer;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= wanderTimer)
        {
            Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
            Vector3 targetDirection = newPos - transform.position;
            float singleStep = speed * Time.deltaTime;
            anim.SetBool("Walk", false);
            agent.SetDestination(newPos);
            Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);
            Debug.DrawRay(transform.position, newDirection, Color.red);
            transform.rotation = Quaternion.LookRotation(newDirection);
            timer = 0;
        }
        else
        {
            Debug.Log(anim);
            anim.SetBool("Walk", true);
            //agent.SetDestination(agent.transform.position);

        }
    }

    public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask)
    {
        Vector3 randDirection = Random.insideUnitSphere * dist;

        randDirection += origin;

        NavMeshHit navHit;

        NavMesh.SamplePosition(randDirection, out navHit, dist, layermask);

        return navHit.position;
    }
}