using UnityEngine;
using System.Collections.Generic; // needed for public list<Transform> Locations;
using UnityEngine.AI;
using Unity.ProjectAuditor.Editor;

public class OldEnemyBehaviour : MonoBehaviour
{
    public Transform Player;
    public Transform PatrolRoute;
    public List<Transform> Locations;
    private int _LocationIndex = 0;
    private NavMeshAgent _agent;

    void Start()
    {
        InitializePatrolRoute();
        MoveToNextPatrolLocation();

        _agent = GetComponent<NavMeshAgent>();
        Player = GameObject.Find("Player").transform;
    }

    void Update()
    {
        if(_agent.remainingDistance < 0.2f && !_agent.pathPending)
        {
            MoveToNextPatrolLocation();
        }
    }

    void InitializePatrolRoute()
    {
        foreach(Transform child in PatrolRoute)
        {
            Locations.Add(child);
        }
    }

    void MoveToNextPatrolLocation()
    {
        if (Locations.Count == 0)
        return;
        _agent.destination = Locations[_LocationIndex].position;
        _LocationIndex = (_LocationIndex + 1) % Locations.Count;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            _agent.destination = Player.position;
            Debug.Log("Enemy detected");
        }
    }

    void OnTriggerExit(Collider other)
    {
        //...No changes needed...
    }
}