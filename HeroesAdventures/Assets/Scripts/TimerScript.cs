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

public class TimerScript : MonoBehaviour
{
    //D�clarations des variables
    float time;
    public float TimerInterval = 5f;
    float tick;
    //D�s que la sc�ne est active le timer se lance
    void Awake()
    {
        time = (int)Time.time;
        time = TimerInterval;
    }

    // le m�thode update sert � que chaque fois qu' un rafraichissement se fait le temps afficher se met � jour correctement avant un bon format
    void Update()
    {
        GetComponent<Text>().text = string.Format("{0:0}:{1:00}",Mathf.Floor(time/60),time%60);
        time = (int)Time.time;

        if (time == tick)
        {
            tick = time + TimerInterval;
        }
        PlayerPrefs.SetFloat("timer", time);
    }

}
