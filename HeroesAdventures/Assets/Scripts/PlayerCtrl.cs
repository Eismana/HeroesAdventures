/* *****************
 Programme : HerosAdventures
 Auteur : Abel Eisman Camara
 Projet : TPI 2021
 Date : 03.05.2021 - 20.05.2021
 Version : 1.0
 Description : Jeu Unity 2D
****************** */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCtrl : MonoBehaviour
{
    //Décalrations variables
    public float playerSpeed;
    public float jumpSpeed;
    private float lockPos = 0;
    private bool isJunmping;
    private float move;
    private Rigidbody2D rb;
    private Animator anim;
    public int gold = 0;
    public int life = 3;
    private float delay = 0f;
    private float delayItemBonus = 0f;
    private float delayItemMalus = 0f;
    bool BonusJumpSpeed = false;
    bool MalusSpeed = false;
    // Start est appelé au lancement du programme
    void Start()
    {
        
        gold = PlayerPrefs.GetInt("GoldRecup", gold);
        life = PlayerPrefs.GetInt("LifeRecup", life);
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update est appelé une fois par rafraichissment
    void Update()
    {
        delay += Time.deltaTime;
        delayItemBonus += Time.deltaTime;
        delayItemMalus += Time.deltaTime;
        PlayerPrefs.SetInt("GoldRecup", gold);
        PlayerPrefs.SetInt("LifeRecup", life);
        PlayerPrefs.Save();
        //Permet que le personnage ne possède pas de rotation car la base du personnage est ronde
        transform.rotation = Quaternion.Euler(lockPos, lockPos, lockPos);
        move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(move * playerSpeed, rb.velocity.y);

        //Permet de tourner le héro à 180 degrés en fonction de la gauche ou la droite
        if (move < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);

        }
        else if (move > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        //Condition qui permet de sauter si le bouton "Jump" = bare espace est appuyé et le bool isJumping est en false 
        if (Input.GetButton("Jump") && !isJunmping)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jumpSpeed));
            isJunmping = true;

        }
        RunAnim();

    }

    //Si le tag du GameObject est pas égal à "Ground" remet le bool isJumping a false pour repermettre un saut
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJunmping = false;
        }
    }

    //Permet au animations de suivre les mouvements du héro gauche/droite/saut
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
            BonusJumpSpeed = true;
            delayItemBonus = 0f;
        }
        else if (delayItemBonus > 0.4f && BonusJumpSpeed==true)
        {
                jumpSpeed -= 150;
                BonusJumpSpeed = false;
                delayItemBonus = 0f;

        }
        else if (other.tag == "MalusItem")
        {
            Destroy(other.gameObject);
            playerSpeed -= 2;
            MalusSpeed = true;
            delayItemMalus = 0f;

        }
        else if (delayItemMalus > 0.4f && MalusSpeed == true)
        {
            playerSpeed += 2;
            MalusSpeed = false;
            delayItemMalus = 0f;

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
        if (other.tag == "Dammage" && delay>0.2f)
        {
            delay = 0f;
            life--;
            
        }

    }

}
