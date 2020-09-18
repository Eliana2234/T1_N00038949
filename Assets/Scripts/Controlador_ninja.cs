using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador_ninja : MonoBehaviour
{
    // Start is called before the first frame update
    private const int ANIMATION_QUIETO = 0;
    private const int ANIMATION_CAMINAR = 1;

    private Rigidbody2D rb;
    private Animator animator;
    private SpriteRenderer sr;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //valor = false;
        rb.velocity = new Vector2(0, rb.velocity.y);
        animator.SetInteger("Estado", ANIMATION_QUIETO);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(10, rb.velocity.y);
            animator.SetInteger("Estado", ANIMATION_CAMINAR);
            sr.flipX = false;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-10, rb.velocity.y);
            animator.SetInteger("Estado", ANIMATION_CAMINAR);
            sr.flipX = true;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0, 30), ForceMode2D.Impulse);

        }

    }
    //private void OnCollisionEnter2D(Collision2D other)
    //{
    //    if(other.gameObject.tag == "Zombie")
    //    {
    //        Debug.Log("Chocaron");
    //    }
    //}
}
