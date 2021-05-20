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

public class RecupLife : MonoBehaviour
{
    //Déclarations des variables
    public Text NbLife;
    string affichageLife;
    //A chaque rafraichissments le nombre des vies est mis à jour
    void Update()
    {
        affichageLife = PlayerPrefs.GetInt("LifeRecup", 0).ToString();
        NbLife.text = affichageLife + " X";

    }
}
