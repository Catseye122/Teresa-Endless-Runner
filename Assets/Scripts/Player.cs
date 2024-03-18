using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D playerRigidbody;
    [SerializeField] private float jumpForce = 10f;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform feetPosition;
    [SerializeField] private float groundDistance = 0.25f;
    [SerializeField] private float jumpTime = 0.3f;
    [SerializeField] private ObstacleSpawner obstacleSpawner;
    // [SerializeField] private Animator animator;
    // Start is called before the first frame update
    private bool isGrounded = false;
    private bool isJumping = false;
    private float jumpTimer;

    private bool isDoubleJump = false;

    private void Start()
    {
        if (Physics2D.OverlapCircle(feetPosition.position, groundDistance, groundLayer) == true)
        {
            isGrounded = true;
        }

        else
        {
            isGrounded = false;
            //animator.SetBool("isJumping", false);
        }

        isGrounded = Physics2D.OverlapCircle(feetPosition.position, groundDistance, groundLayer);

        if (isGrounded == true && Input.GetButtonDown("Jump"))
        {
            playerRigidbody.velocity = Vector2.up * jumpForce;
            isJumping = true;
            Debug.Log(isGrounded);
            //animator.SetBool("isJumping", true);

        }

        if (isJumping && Input.GetButton("Jump"))
        {
            if (jumpTimer < jumpTime)
            {
                playerRigidbody.velocity = Vector2.up * jumpForce;

                jumpTimer += Time.deltaTime;

            }
            else
            {
                isJumping = false;
            }

        }

        if (Input.GetButtonUp("Jump"))
        {
            isJumping = false;
            jumpTimer = 0f;
        }

        if (Input.GetKeyDown(KeyCode.E) && isGrounded == true)
        {
            obstacleSpawner.PauseObstacles();
        }
        if (Input.GetKeyUp(KeyCode.E) && isGrounded == true)
        {
            obstacleSpawner.ResumeObstacles();
        }
    }

    void Update()
    {
        if (isGrounded = Physics2D.OverlapCircle(feetPosition.position, groundDistance, groundLayer) == true)
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }

        if (isGrounded == true && Input.GetButtonDown("Jump"))
        {
            playerRigidbody.velocity = Vector2.up * jumpForce;
            isJumping = true;
            Debug.Log(isGrounded);
        }
        if (isJumping && Input.GetButton("Jump"))
        {
            if (jumpTimer < jumpTime)
            {
                playerRigidbody.velocity = Vector2.up * jumpForce;

                jumpTimer += Time.deltaTime;
            }

            else
            {
                isJumping = false;
            }


        }
        if (Input.GetButtonUp("Jump"))
        {
            isJumping = false;
            jumpTimer = 0f;

              
        }
    }
}



    