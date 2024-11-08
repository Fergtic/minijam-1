using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movemont : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical"); 
    }

    void FixedUpdate()
    {

        rb.linearVelocity = movement.normalized * moveSpeed;
    }
}
