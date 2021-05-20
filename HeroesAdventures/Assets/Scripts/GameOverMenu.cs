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

public class GameOverMenu : MonoBehaviour
{
    //La m�thode Quit() sert � quitter l'application
    public void Quit()
    {
        Application.Quit();


    }
    //La m�thode Replay() sert � retourner au Menu
    public void Replay()
    {
        SceneManager.LoadScene(0);
    
    }
    //La m�thode Scores() sert � voir les scores
    public void Score()
    {
        SceneManager.LoadScene("Score");

    }

}
