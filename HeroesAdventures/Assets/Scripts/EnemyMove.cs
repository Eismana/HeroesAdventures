using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMove : MonoBehaviour
{
    //D�clarations variables
    
    public float speed;
    public bool MoveRight;
    int dammage;
    private AreaEffector2D bump;

    void Start()
    {
        bump = GetComponent<AreaEffector2D>();
    }
    //Update est appell� � chaque rafraichissement 
    //Condition de faire bouger � une certaine vitesse donn�e l'ennemie � gauche ou � droite
    void Update()
    {

        if (MoveRight)
        {
            transform.Translate(2 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(-1, 1);
        }
        else {
            transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(1, 1);
        }
    }
    //Permet de faire tourner l'ennemi de gauche � droite dans une zone d�limit�e si il touche une zone avec le tag "turn" il tourne de mani�re automatique
    void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.CompareTag("turn"))
        {
            if (MoveRight)
            {
                bump.forceAngle = 120;
                MoveRight = false;
            }
            else
            {
                bump.forceAngle = 60;
                MoveRight = true;    
            }
        }
    }

}
