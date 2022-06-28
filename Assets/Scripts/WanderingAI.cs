using UnityEngine;
using System.Collections;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;

public class WanderingAI : MonoBehaviour
{

    public float wanderRadius;
    public float wanderTimer;

    private Transform target;
    private NavMeshAgent agent;
    private float timer;
    private Animator anim;

    // Use this for initialization
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        agent.SetDestination(RandomNavSphere(agent.gameObject.transform.position, wanderRadius, -1));
        Debug.Log(agent);
        Debug.Log(anim);

        timer = wanderTimer;
    }

    private void Update()
    {
        AnimatePlayer();
    }

    void AnimatePlayer()
    {
        if (agent.velocity.magnitude > 0)
        {
            anim.SetBool("HumanoidWalk", true);
        }
        else
            anim.SetBool("HumanoidWalk", false);
    }
    // Update is called once per frame
    /*void Update()
    {
        timer += Time.deltaTime;

        if (timer >= wanderTimer)
        {
            
            Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
            agent.SetDestination(newPos); 
            character.Move(agent.desiredVelocity, false, false);
            timer = 0;
        }
    }*/

    public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask)
    {
        Vector3 randDirection = Random.insideUnitSphere * dist;

        randDirection += origin;

        NavMeshHit navHit;

        NavMesh.SamplePosition(randDirection, out navHit, dist, layermask);

        return navHit.position;
    }
}
