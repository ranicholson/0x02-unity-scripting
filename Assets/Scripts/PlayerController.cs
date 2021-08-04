using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody rb;


    void FixedUpdate()
    {
        rb = GetComponent<Rigidbody>();
        Vector3 playerMovement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        rb.MovePosition(transform.position + playerMovement * Time.deltaTime * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}