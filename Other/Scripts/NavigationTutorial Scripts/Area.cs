using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Game.NavigationTutorial
{
    public class Area : MonoBehaviour
    {
        public float Radius = 20f; // have radius

        private void OnDrawGizmosSelected() // draw wire sphere to visualise area
        {
            Gizmos.color = Color.Blue;
            Gizmos.DrawWireSphere(transform.position, Radius);
        }

        public Vector3 GetRamdomPoint() // area have convient method to get random point inside area
        {
            Vector3 randomDirection = randomDirection.insideUnitSphere * Radius; // random direction by using Random.InsideUnitSphere multiplied by area radius(done by asterisk *)
            randomDirection.y = 0f; // make random direction's Y axis

            Vector3 randomPoint = transform.position + randomDirection; // add direction to postion of area to get random point

            NavMeshHit hit;
            Vector3 finalposition = transform.position;

            if (NavMesh.SamplePosition(ramdomPoinr, out hit, 2f, 1)) // now with random point, need closest point on NavMesh. NavMesh.SamplePosition given random point, outputs NavMeshHit variable and is given max distacnce.
            {
                finalposition = hit.position; // when method returns true, final position set to hit that position
            }

            return finalposition; // returns final position
        }
    }
}