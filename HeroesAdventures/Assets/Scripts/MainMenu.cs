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

    public class MainMenu : MonoBehaviour
    {
        //Déclarations variables
        public InputField namePlayer;
        public Text warning;

        //Start est appelé au lancement du programme et recupère les données des vies et des pièces
        private void Start()
        {
            warning.enabled = false;
            PlayerPrefs.SetInt("LifeRecup", 3);
            PlayerPrefs.SetInt("GoldRecup", 0);
        }
        //La méthode Play() permet de rendre visble ou non le text de warning et d'accéder au premier niveau si l'utilisateur entre son nom
        public void Play()
        {
        if (namePlayer.text == "")
        {
            warning.enabled = true;
        }
        else
            {
                //Permet de sauvegarder le nom du jouer dans la cash pour l'afficher dans le niveau 1
                PlayerPrefs.SetString("PlayerName", namePlayer.text);
                PlayerPrefs.Save();
                //Accéder à la scène du nivau 1
                SceneManager.LoadScene("Niveau_1");
            }
        }
        //La méthode Score() permet d'accéder à la scène score
        public void Score()
        {
            SceneManager.LoadScene("Score");
        }
        //La méthode Quit() permet de fermer l'application
        public void Quit()
        {
            Application.Quit();


        }
    }
