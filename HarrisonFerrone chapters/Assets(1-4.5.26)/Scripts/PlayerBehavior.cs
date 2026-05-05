using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{

    public float moveSpeed = 10f;// Public variable - How fast player moves forward/backward
    public float rotateSpeed = 10f;// Public variable - How fast player rotates left/right
    public float jumpVelocity = 5f;
    public float distanceToGround = 0.5f; // dist. to object with ground layer in order to jump
    public LayerMask groundLayer;
    public GameObject bullet; // allows to set object refererence in Inspector
    public float bulletSpeed = 50f; // allow change speeds in Inspector
    private float vInput;// Private variable - Stores vertical axis input
    private float hInput;// Private variable - Stores horizontal axis input
    private Rigidbody _rb;
    private CapsuleCollider _col;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _col = GetComponent<CapsuleCollider>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        vInput = Input.GetAxis("Vertical") * moveSpeed;// Detect when W/S or up/dpwm arrow pressed & multiplies value by moveSpeed. Up arrow/W = 1 -> move forward(positive) & down arrow/S = -1 -> move backward(negative)
        hInput = Input.GetAxis("Horizontal") * rotateSpeed;// Detect when A/D or Left/Right arrow pressed & multiplies by rotateSpeed. D/Right arrow = 1(pos) -> move right & A/Left arrow = -1 -> move left(neg)

        this.transform.Translate(Vector3.forward * vInput * Time.deltaTime);
        this.transform.Rotate(Vector3.up * hInput * Time.deltaTime);
    }

    void FixedUpdate()
    {
        if(IsGrounded() && (Input.GetKeyDown(KeyCode.Space))) // Jumping code - press Spcae + be on object with ground layer.
        {
            _rb.AddForce(Vector3.up * jumpVelocity, ForceMode.Impulse);
        }

        Vector3 rotation = Vector3.up * hInput;
        Quaternion angleRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);
        _rb.MovePosition(this.transform.position + this.transform.forward * vInput * Time.fixedDeltaTime);
        _rb.MoveRotation(_rb.rotation * angleRot);

        if(Input.GetMouseButtonDown(0)) // Shooting code - Left click(0) to shoot.
        {
            GameObject newbullet = Instantiate(bullet, this.transform.position + new Vector3(1, 0, 0), this.transform.rotation) as GameObject;
            Rigidbody bulletRB = newbullet.GetComponent<Rigidbody>();
            bulletRB.velocity = this.transform.forward * bulletSpeed;
        }
    }

    private bool IsGrounded()
    {
        Vector3 capsuleBottom = new Vector3 (_col.bounds.center.x, _col.bounds.min.y, _col.bounds.center.z);
        bool grounded = Physics.CheckCapsule(_col.bounds.center, capsuleBottom, distanceToGround, groundLayer, QueryTriggerInteraction.Ignore);
        return grounded;
    }
}
