using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{

    public float moveSpeed = 10f; // Public variable - How fast player moves forward/backward
    public float rotateSpeed = 75f; // Public variable - How fast player rotates left/right
    private float vInput; // Private variable - Stores vertical axis input
    private float hInput; // Private variable - Stores horizontal axis input
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vInput = Input.GetAxis("Vertical") * moveSpeed;
        hInput = Input.GetAxis("Horizontal") * rotateSpeed;

        transform.Translate(Vector3.forward * vInput * Time.deltaTime);
        transform.Translate(Vector3.forward * hInput * Time.deltaTime);
    }
}
