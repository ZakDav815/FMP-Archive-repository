using UnityEngine;

public class CollecctibleRotate : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float rotationSpeed; // Variable - Rotation
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0); // can now change from Inspector

    }
    private void OnTriggerEnter(Collider other) {
        
        Destroy(gameObject); // Destroy Collectible

    } // When object with rigidbody component collides with object(containing this script), code inside the curly brackets will run.
}
