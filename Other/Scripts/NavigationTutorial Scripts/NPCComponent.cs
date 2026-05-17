using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.NavigationTutorial
{
    public class NPCComponent : MonoBehaviour
    {
        protected NPC npc;

        protected virtual void Awake()
        {
            npc = GetComponentInParent<NPC>(); // get NPCComponent from parent. When using GetComponentInParent, game object searches component in same obect then hierachy -> can add these components to child objects of NPC, root object not crowded.
        }
    }
}