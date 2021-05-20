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
using System.Linq;
using UnityEngine;

public class ScoreUi : MonoBehaviour
{
    //Déclarations de varibles
    public RowUi rowUi;
    public ScoreManager scoreManager;

    //Start() se lance au lancement de la scène et affiche les cinq meilleurs scores si il y en a 
    void Start()
    {
        
        scoreManager.AddScore(new Score(PlayerPrefs.GetString("PlayerName"), PlayerPrefs.GetFloat("timer")));

        var scores = scoreManager.GetHighScores().ToArray();
        for (int i = 0; i < 5; i++)
        {
            var row = Instantiate(rowUi, transform).GetComponent<RowUi>();
            row.rank.text = (i + 1).ToString();
            row.nameScore.text = scores[i].name;
            row.score.text = string.Format("{0:0}:{1:00}", Mathf.Floor(scores[i].score / 60), scores[i].score % 60);
        }
    }
}