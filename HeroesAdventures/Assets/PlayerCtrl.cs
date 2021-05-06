using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public float playerSpeed;
    public float jumpSpeed;


    private float lockPos = 0;
    private bool isJunmping;
    private float move;
    private Rigidbody2D rb;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(lockPos, lockPos, lockPos);
        move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(move * playerSpeed, rb.velocity.y);

        if (move<0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);

        }
        else if (move>0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }


        if (Input.GetButton("Jump")&& !isJunmping)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jumpSpeed));
            isJunmping =true;

        }
        RunAnim();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJunmping = false;
        }
    }
    void RunAnim() 
    {
        anim.SetFloat("Movement", Mathf.Abs(move));
        anim.SetBool("IsJumping", isJunmping);
    }
}
