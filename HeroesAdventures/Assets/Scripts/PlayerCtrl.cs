using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCtrl : MonoBehaviour
{
    //D�calrations variables
    public float playerSpeed;
    public float jumpSpeed;
    private float lockPos = 0;
    private bool isJunmping;
    private float move;
    private Rigidbody2D rb;
    private Animator anim;
    public int gold = 0;
    public int life = 3;

    // Start est appel� au lancement du programme
    void Start()
    {
        gold = PlayerPrefs.GetInt("GoldRecup", gold);
        life = PlayerPrefs.GetInt("LifeRecup", life);
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();


    }

    // Update est appel� une fois par rafraichissment
    void Update()
    {
        PlayerPrefs.SetInt("GoldRecup", gold);
        PlayerPrefs.SetInt("LifeRecup", life);
        PlayerPrefs.Save();
        //Permet que le personnage ne poss�de pas de rotation car la base du personnage est ronde
        transform.rotation = Quaternion.Euler(lockPos, lockPos, lockPos);
        move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(move * playerSpeed, rb.velocity.y);

        //Permet de tourner le h�ro � 180 degr�s en fonction de la gauche ou la droite
        if (move < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);

        }
        else if (move > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        //Fonction qui permet de sauter si le bouton "Jump" = bare espace est appuy� et le bool isJumping est en false 
        if (Input.GetButton("Jump") && !isJunmping)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jumpSpeed));
            isJunmping = true;

        }
        RunAnim();

    }

    //Si le tag du GameObject est pas �gal � "Ground" remet le bool isJumping a false pour repermettre un saut
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJunmping = false;
        }
    }

    //Permet au animations de suivre les mouvements du h�ro gauche/droite/saut
    void RunAnim()
    {
        anim.SetFloat("Movement", Mathf.Abs(move));
        anim.SetBool("IsJumping", isJunmping);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "BonusItem")
        {
            Destroy(other.gameObject);
            jumpSpeed += 150;


        }
        else if (other.tag == "MalusItem")
        {
            Destroy(other.gameObject);
            playerSpeed -= 2;

        }
        else if (other.tag == "Gold")
        {

            Destroy(other.gameObject);
            gold++;
            if (gold == 5)
            {
                life++;
                gold = 0;
            }


        }
        else if (other.tag == "Dammage")
        {
            if (life == 0)
            {
                SceneManager.LoadScene(5);
            }
            else
            {

                rb.AddForce(new Vector2(15 * playerSpeed, 10));
                life--;

            }

        }


    }

}
