using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Game.NavigationTutorial // good idea to put all game code in same name space
{
    [RequiredComponent(typeof(NavMeshAgent))] // for this navmesh need presence of NavMeshAgent & Animator -> reason for using RequiredComponent.
    [RequiredComponent(typeof(Animator))]  // ref to NavMeshAgent + Animator set to public as will reference in other scripts.
    public class NPC : MonoBehaviour
    {
        [HideInInspector]
        public NavMeshAgent Agent;

        [HideInInspector]
        public Animator Animator;


        public float CurrentSpeed // current speed property will return "CurrentSpeed" of Agent
        {
            get { return Agent.velocity.magnitude; }
        }

        private void Awake() //using awake method to get the two components
        {
            Agent = GetComponent<NavMeshAgent>();
            Animator = GetComponent<Animator>();
        }
    }
}