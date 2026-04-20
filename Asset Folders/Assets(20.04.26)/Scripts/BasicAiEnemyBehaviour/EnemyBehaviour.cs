using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    // 1
    public Transform PatrolRoute;
    // 2
    public List<Transform> Locations;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 3
        InitializePatrolRoute()
    }

    // 4
    void InitializePatrolRoute();
    {
        // 5
        foreach(Transform child in PatrolRoute)
        {
            // 6
            Locations.Add(child);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // ... No changes needed...
    }

    void OnTriggerExit(Collider other)
    {
        //...No changes needed...
    }
}
