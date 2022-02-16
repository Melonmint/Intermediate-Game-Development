using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// automatically adds the required component to the sprite the script is attached to
/// </summary>
[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class SimplePhysicsPlayer : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField]
    float movementSpeed = 5.0f;
    [SerializeField]
    float jumpStrength = 5.0f;
    float moveX;

    bool canJump;
    bool isGrounded;
    //these booleans are automatically false

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void PlayerControls()
    {
        moveX = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            canJump = true;
        }
    }
    // use void fixedupdate when doing physics
    // rb.velocity.y means "the previous y value"

    void Jump()
    {
        if (!isGrounded)
            return;
        isGrounded = false;
        rb.AddForce(Vector2.up * jumpStrength, ForceMode2D.Impulse);
        Debug.Log("JUMP!!", gameObject);
        /*
        if (isGrounded)
        {
            isGrounded = false;
            rb.AddForce(Vector2.up * jumpStrength, ForceMode2D.Impulse);
            // ForceMode2D adds a force to rigidbody2D, impulse makes it instant
            // Vector2.up is shorthand for Vector2(0,1)
        }
        */
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
        Debug.Log("Hit something", collision.gameObject);
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveX * movementSpeed, rb.velocity.y);
        if (canJump)
        {
            canJump = false;
            Jump();
        }
    }
    private void Update()
    {
        PlayerControls();
    }
}
