using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{

    private Vector2 vector; 
    private Rigidbody2D rb; 
    public int movementSpeed;
    private Animator animator;

    void Start()
    {
      rb = GetComponent<Rigidbody2D>();
      animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        vector.x = Input.GetAxis("Horizontal");
        vector.y = Input.GetAxis("Vertical");

        animator.SetFloat("Horizontal", vector.x);
        animator.SetFloat("Vertical", vector.y);
        animator.SetFloat("Speed" , vector.sqrMagnitude);
       

    }

     void FixedUpdate()
    {
        rb.MovePosition(rb.position + vector * movementSpeed * Time.deltaTime);
    }
}
