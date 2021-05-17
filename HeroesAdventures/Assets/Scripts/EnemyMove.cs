using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMove : MonoBehaviour
{
    //Déclarations variables
    
    public float speed;
    public bool MoveRight;
    int dammage;
    private AreaEffector2D bump;

    void Start()
    {
        bump = GetComponent<AreaEffector2D>();
    }
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
