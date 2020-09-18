using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador_Zombie : MonoBehaviour
{
    //private const int ANIMATION_CAMINAR = 1;

    private Rigidbody2D rb;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(-2, rb.velocity.y);
        animator.SetInteger("estado",0);
    }
}
