using UnityEngine; // using statements link script to necessary libraries -> if enter something(eg. rigidbody), script know what that mean.

public class Collectible : MonoBehaviour // defines script as public class named "Collectible" that inherits from MonoBehaiour Class. Allows you to add script as component to GameObject.
{

    public float rotationSpeed; // public float variable of type float. "public" allows value to be editable in inspector.
    public GameObject onCollectEffect;
    [SerializeField] private PlayerUI _collect;

    void Start() // "Start()" executes once at beginning when project is run.
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        _collect.Get();
        Destroy(gameObject); // Destroy Collectible
        Instantiate(onCollectEffect, transform.position, transform.rotation);
    }

}