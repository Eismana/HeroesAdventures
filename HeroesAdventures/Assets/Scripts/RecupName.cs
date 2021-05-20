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

public class RecupName : MonoBehaviour
{
    //Déclaration variable
    public Text NomAv;
    //Start() est appelé au lancement de la scène
    void Start()
    {
        //Permet de récuperer l'input du nom dans le menu et l'afficher dans le text en haut à gauche du niveau 1 pour l'instant
        string affichageName = PlayerPrefs.GetString("PlayerName", "default");
        NomAv.text = affichageName;
    }


}
