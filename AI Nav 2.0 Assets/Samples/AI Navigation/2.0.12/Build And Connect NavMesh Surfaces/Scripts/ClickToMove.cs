using UnityEngine;
using UnityEngine.AI;

namespace Unity.AI.Navigation.Samples
{
    /// <summary>
    /// Use physics raycast hit from mouse click to set agent destination
    /// </summary>
    [RequireComponent(typeof(NavMeshAgent))]
    public class ClickToMove : MonoBehaviour
    {
        private NavMeshAgent m_Agent; 
        private RaycastHit m_HitInfo = new RaycastHit();
        private Animator m_Animator; // variable for animations

        void Start()
        {
            m_Agent = GetComponent<NavMeshAgent>();
            m_Animator = GetComponent<Animator>();
        }

        void Update()
        {
            if (Input.GetMouseButtonDown(0) && !Input.GetKey(KeyCode.LeftShift))
            {
                var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray.origin, ray.direction, out m_HitInfo))
                    m_Agent.destination = m_HitInfo.point;
            }
            if (m_Agent.velocity.magnitude !=0f) // using Agent velocity to detect movement
            {
                 m_Animator.SetBool("Running", true); //if velocity doesn't equal zero then set animator bool running to true
            }
            else // else - if velocity does equal zero
            {
                m_Animator.SetBool("Running", false); //if velocity equal zero then idle anim played
            }
        }


        void OnAnimatorMove()
        {
            if (m_Animator.GetBool("Running"))
            {
                m_Agent.speed = (m_Animator.deltaPosition / Time.deltaTime).magnitude;
            }
        }
    }
}