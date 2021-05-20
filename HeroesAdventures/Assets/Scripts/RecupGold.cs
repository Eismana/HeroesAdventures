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
public class RecupGold : MonoBehaviour
{
    //Déclarations de variables
    public Text NbGold;
    string affichageGold;

    //A chaque rafraichissments le nombre des pièces est mis à jour
    void Update()
    {
        affichageGold = PlayerPrefs.GetInt("GoldRecup", 0).ToString();
        NbGold.text = affichageGold + " X";
    }
}
