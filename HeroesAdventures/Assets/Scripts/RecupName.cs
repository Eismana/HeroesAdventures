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
    //D�claration variable
    public Text NomAv;
    //Start() est appel� au lancement de la sc�ne
    void Start()
    {
        //Permet de r�cuperer l'input du nom dans le menu et l'afficher dans le text en haut � gauche du niveau 1 pour l'instant
        string affichageName = PlayerPrefs.GetString("PlayerName", "default");
        NomAv.text = affichageName;
    }


}
