using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class RollABallPlayerController : MonoBehaviour
{
    public float speed = 0; // speed variable
    public TextMeshProUGUI countText;
    public GameObject WinTextObject;
    private Rigidbody rb; // Rigidbody variable
    private int count;
    private float movementX; // X-axis movement variable
    private float movementY; // Y-Axis movement variable
    void Start()
    {
        rb = GetComponent <Rigidbody>(); // Get & store rigidbody component attached to player
        count = 0;

        SetCountText();
        WinTextObject.SetActive(false);
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if(count >= 7)
        {
            WinTextObject.SetActive(true); // When collect X no. objects, show win screen.
        }
    }

    void OnMove(InputValue movementValue) // function called when move input detected
    {
        Vector2 movementVector = movementValue.Get<Vector2>(); // converts input value to Vector2 for movement
        movementX = movementVector.x; // store X component
        movementY = movementVector.y; // store Y component
    }

    void FixedUpdate() // fuction called once per fixe frame-rate frame
    {
        Vector3 movement = new Vector3 (movementX, 0.0f, movementY); // creates 3D movement vector using X, Y axis

        rb.AddForce(movement * speed); // apply force to Rigidbody to move player
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup")) 
        {
            other.gameObject.SetActive(false); // If object player collide with has Pickup tag, deactivate object on colide
            count = count + 1;
            {
                SetCountText();
            }
        }
    }

    private void OnCollisonEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);

            WinTextObject.gameObject.SetActive(true);
            WinTextObject.GetComponent<TextMeshProUGUI>().text = "You Lose!";
        }
    }
}
