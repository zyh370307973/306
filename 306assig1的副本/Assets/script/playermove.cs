using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private Rigidbody2D rb;
    private Animator animator;
    private float inputx;
    private float inputy;
    private float stopx;
    private float stopy;
    private Vector3 offset;
    

    void Start()
    {
        offset = Camera.main.transform.position - transform.position;
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        inputx = Input.GetAxisRaw("Horizontal");
        inputy = Input.GetAxisRaw("Vertical");
        Vector2 input = new Vector2(inputx, inputy).normalized;
        rb.velocity = input * speed;

        if(input != Vector2.zero)
        {
            animator.SetBool("ismoving", true);
            stopx = inputx;
            stopy = inputy;       
        }
        else
        {
            animator.SetBool("ismoving", false);
        }
        animator.SetFloat("inputx", stopx);
        animator.SetFloat("inputy", stopy);
        Camera.main.transform.position = transform.position + offset;
        
    }
}

