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
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    //Fonction qui permet de v�rifier si le h�ro avec le tag "Player" touche cette zone ce qui permet de revenir au d�but du niveau en rechargeant la sc�ne en cas de chute
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player" && PlayerPrefs.GetInt("LifeRecup", 0) == 0)
        {

            SceneManager.LoadScene(5);
        }
        else 
        {
            other.transform.position = new Vector3(-5,-3,0);
            
        }
    

    }
}
