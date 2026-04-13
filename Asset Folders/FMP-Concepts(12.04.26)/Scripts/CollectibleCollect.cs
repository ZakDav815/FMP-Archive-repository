using UnityEngine;

public class CollectibleCollect : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        
        Destroy(gameObject); // Destroy Collectible

    } // When object with rigidbody component collides with object(containing this script), code inside the curly brackets will run.
}
