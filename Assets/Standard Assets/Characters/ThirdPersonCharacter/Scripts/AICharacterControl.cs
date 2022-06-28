using System;
using System.Collections;
using UnityEngine;

namespace UnityStandardAssets.Characters.ThirdPerson
{
    [RequireComponent(typeof (UnityEngine.AI.NavMeshAgent))]
    [RequireComponent(typeof (ThirdPersonCharacter))]
    public class AICharacterControl : MonoBehaviour
    {
        public UnityEngine.AI.NavMeshAgent agent { get; private set; }             // the navmesh agent required for the path finding
        public ThirdPersonCharacter character { get; private set; } // the character we are controlling
        public Transform target;
        public float wanderRadius;
        public float wanderTimer;

        private float timer;


        private void Start()
        {
            // get the components on the object we need ( should not be null due to require component so no need to check )
            agent = GetComponentInChildren<UnityEngine.AI.NavMeshAgent>();
            character = GetComponent<ThirdPersonCharacter>();

            agent.updateRotation = false;
	        agent.updatePosition = true;
        }


        private void Update()
        {
            if ((target.transform.position.x + target.transform.position.z) - (agent.transform.position.x + agent.transform.position.z) <= 0 && (target.transform.position.x + target.transform.position.z) - (agent.transform.position.x + agent.transform.position.z) >= -0)
            {
                if (target != null)
                    agent.SetDestination(target.position);

                if (agent.remainingDistance > agent.stoppingDistance)
                    character.Move(agent.desiredVelocity, false, false);
                else
                    character.Move(Vector3.zero, false, false);
            }
        }

        public void SetTarget(Transform target)
        {
            this.target = target;
        }
    }
}
