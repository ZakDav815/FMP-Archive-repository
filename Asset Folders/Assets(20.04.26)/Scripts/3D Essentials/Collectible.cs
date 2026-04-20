using UnityEngine; // using statements link script to necessary libraries -> if enter something(eg. rigidbody), script know what that mean.

public class Collectible : MonoBehaviour // defines script as public class named "Collectible" that inherits from MonoBehaiour Class. Allows you to add script as component to GameObject.
{

public float rotationSpeed; // public float variable of type float. "public" allows value to be editable in inspector.
public GameObject onCollectEffect;

    void Start() // "Start()" executes once at beginning when project is run.
    {
        
    }

    // Update is called once per frame
    void Update() // "Update()" executes once per frame
    {
        transform.Rotate(0, rotationSpeed, 0); // 
    }

private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject); // Destroy Collectible
        Instantiate(onCollectEffect, transform.position, transform.rotation);
    }

}
