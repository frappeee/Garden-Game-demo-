using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public float speed = 5f;

    private enum State { normal, hurt };
    private State state = State.normal; 

    private Vector2 movement;
    private Rigidbody2D rb;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Animator animator;
    
    [Header("Hurt Settings")]
    [SerializeField] private float recoilForce = 2f;
    [SerializeField] private float hurtDuration = 0.3f; 
    [SerializeField] private string hurtTriggerName = "Hurt"; 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (state == State.normal)
        {
            Movement();
        }
    }

    private void FixedUpdate()
    {
        if (state == State.normal)
        {
            rb.velocity = movement.normalized * speed;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            // if (state == State.hurt) 
            // {
            //     return; 
            // }

            state = State.hurt;

            animator.SetTrigger(hurtTriggerName);

            Vector2 recoilDirection;
            
            if (collision.gameObject.transform.position.x > transform.position.x)
            {
                // enemy is to right, recoil left
                recoilDirection = Vector2.left;
                animator.SetTrigger(hurtTriggerName);
            }
            else
            {
                // enemy is to left, recoil right
                recoilDirection = Vector2.right;
                animator.SetTrigger(hurtTriggerName);
            }

            rb.velocity = Vector2.zero;
            rb.AddForce(recoilDirection * recoilForce, ForceMode2D.Impulse);

            StartCoroutine(HurtRecovery());

            Debug.Log("Player is hurt");
        }
    }

    private IEnumerator HurtRecovery()
    {
        yield return new WaitForSeconds(hurtDuration);

        state = State.normal;
    }

    private void Movement()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        movement = new Vector2(moveX, moveY);

        if (moveX > 0f)
        {
            spriteRenderer.flipX = false;
        }
        else if (moveX < 0f)
        {
            spriteRenderer.flipX = true;
        }

        if (Mathf.Abs(moveX) > 0 || Mathf.Abs(moveY) > 0)
        {
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }
    }
}