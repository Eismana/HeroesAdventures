using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

    public class MainMenu : MonoBehaviour
    {
        public InputField name;
        public Text warning;
        private void Start()
        {
        warning.enabled = false;
        }

        public void Play()
        {
        if (name.text == "")
        {
            warning.enabled = true;
        }
        else
            {
            PlayerPrefs.SetString("PlayerName", name.text);
            PlayerPrefs.Save();
            Debug.Log(name.text);
            SceneManager.LoadScene("Niveau_1");
            }
        }

        // Update is called once per frame
        public void Score()
        {
            SceneManager.LoadScene("Score");
        }

        public void Quit()
        {
            Application.Quit();


        }
    }
