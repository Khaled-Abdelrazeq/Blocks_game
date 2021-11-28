using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed = 10;
    [SerializeField] float maxWidth, minWidth;

    private Rigidbody2D rb;
    private float movement;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed;
    }

    private void FixedUpdate()
    {
        movement *= Time.fixedDeltaTime;

        Vector2 position = rb.position + Vector2.right * movement;

        position.x = Mathf.Clamp(position.x, minWidth, maxWidth);
        
        rb.MovePosition(position);
    }
}
