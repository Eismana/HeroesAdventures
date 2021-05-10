using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

    public class MainMenu : MonoBehaviour
    {
        //Déclarations variables
        public InputField name;
        public Text warning;

        //Start est appelé au lancement du programme
        private void Start()
        {
            warning.enabled = false;
        }
        
        //La fonction Play() permet de rendre visble ou non le text de warning et d'accéder au premier niveau si l'utilisateur entre son nom
        public void Play()
        {
        if (name.text == "")
        {
            warning.enabled = true;
        }
        else
            {
                //Permet de sauvegarder le nom du jouer dans la cash pour l'afficher dans le niveau 1
                PlayerPrefs.SetString("PlayerName", name.text);
                PlayerPrefs.Save();
                //Accéder à la scène du nivau 1
                SceneManager.LoadScene("Niveau_1");
            }
        }
        //La fonction Score() permet d'accéder à la scène score
        public void Score()
        {
            SceneManager.LoadScene("Score");
        }
        //La fonction Quit() permet de fermer l'application
        public void Quit()
        {
            Application.Quit();


        }
    }
