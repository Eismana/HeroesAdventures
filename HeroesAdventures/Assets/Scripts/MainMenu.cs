using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

    public class MainMenu : MonoBehaviour
    {
        //D�clarations variables
        public InputField namePlayer;
        public Text warning;

        //Start est appel� au lancement du programme
        private void Start()
        {
            warning.enabled = false;
            PlayerPrefs.SetInt("LifeRecup", 3);
            PlayerPrefs.SetInt("GoldRecup", 0);

        }
        void Update()
        {
            
        }
    //La fonction Play() permet de rendre visble ou non le text de warning et d'acc�der au premier niveau si l'utilisateur entre son nom
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
                //Acc�der � la sc�ne du nivau 1
                SceneManager.LoadScene("Niveau_1");
            }
        }
        //La fonction Score() permet d'acc�der � la sc�ne score
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
