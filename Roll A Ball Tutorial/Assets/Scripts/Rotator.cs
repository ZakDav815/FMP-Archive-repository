using UnityEngine;

public class Rotator : MonoBehaviour
{
    void Update() // Update is called once per frame
    {
        transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime); // Rotates obj on the 3 axis. Framerate adjusted.
    }
}
