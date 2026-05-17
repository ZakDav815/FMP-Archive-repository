using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Game.NavigationTutorial
{
    public class NPCWander : NPCComponent //NPCWander script will be child of NPCComponent
    {
        [SerializedField]
        public Area Area; //need reference to out area

        
        private void Start()
        {
            SetRandomDestination(); // method to set random destination
        }


        private void Update()
        {
            if (HasArrived()) // check if arrived then set random direction
            {
                SetRandomDestination();
            }
        }


        bool HasArrived()
        {
            return NPCWander.Agent.remainingDistance <= npc.Agent.stoppingDistance; // Agent arrive when remaining distance is lower than stopping distance
        }
        void SetRandomDestination()
        {
            npc.Agent.SetDestination(area.GetRandomPoint());
        }
    }
}