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
    //La méthode Quit() sert à quitter l'application
    public void Quit()
    {
        Application.Quit();


    }
    //La méthode Replay() sert à retourner au Menu
    public void Replay()
    {
        SceneManager.LoadScene(0);
    
    }
    //La méthode Scores() sert à voir les scores
    public void Score()
    {
        SceneManager.LoadScene("Score");

    }

}
