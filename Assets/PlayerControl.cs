using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float speed = 10.0f;
    private float turnSpeed = 50.0f;
    private float jumpForce = 8.0f;
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Move forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        // Make turns
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        // Jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
