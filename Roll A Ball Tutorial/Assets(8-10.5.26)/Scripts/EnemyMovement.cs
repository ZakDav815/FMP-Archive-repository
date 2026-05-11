using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public Transform Player;
    private NavMeshAgent navMeshAgent; 

    void Start()  // Start is called once before the first execution of Update after the MonoBehaviour is created
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Player != null)
        {
            navMeshAgent.SetDestination(Player.position);
        }
    }
}
