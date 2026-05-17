using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.NavigationTutorial
{
    public class NPCAnimator : NPCComponent
    {
        private void Update()
        {
            npc.Animator.SetFloat("Speed", NPCAnimator.CurrentSpeed);
        }
    }
}