using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rigitBody;
    public Animator animator;

    public float speed = 5f;

    Vector2 Movement;

    void Update()
    {
        Movement.x = Input.GetAxisRaw("Horizontal");
        Movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", Movement.x);
        animator.SetFloat("Vertical", Movement.y);
        animator.SetFloat("Speed", Movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
        rigitBody.MovePosition(rigitBody.position + Movement * speed * Time.fixedDeltaTime);
    }
}
