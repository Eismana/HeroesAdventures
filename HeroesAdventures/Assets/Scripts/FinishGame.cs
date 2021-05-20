/* *****************
 Programme : HerosAdventures
 Auteur : Abel Eisman Camara
 Projet : TPI 2021
 Date : 03.05.2021 - 20.05.2021
 Version : 1.0
 Description : Jeu Unity 2D
****************** */
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class FinishGame : MonoBehaviour
{
    //Déclaration variable
    public Text timer;
    // Méthode qui amène le joueur à la scène score si il touche le drapeau
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("Score");
            
        }
    }

}
