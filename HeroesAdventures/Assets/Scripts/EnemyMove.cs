using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    //Déclarations variables

    public float speed;
    public bool MoveRight;

    //Update est appellé à chaque rafraichissement 
    //Condition de faire bouger à une certaine vitesse donnée l'ennemie à gauche ou à droite
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
    //Permet de faire tourner l'ennemi de gauche à droite dans une zone délimitée si il touche une zone avec le tag "turn" il tourne de manière automatique
    void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.CompareTag("turn"))
        {
            if (MoveRight)
            {
                MoveRight = false;
            }
            else
            {
                MoveRight = true;    
            }
        }
    }
}
