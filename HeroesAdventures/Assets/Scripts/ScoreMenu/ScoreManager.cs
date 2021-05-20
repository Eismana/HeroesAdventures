/* *****************
 Programme : HerosAdventures
 Auteur : Abel Eisman Camara
 Projet : TPI 2021
 Date : 03.05.2021 - 20.05.2021
 Version : 1.0
 Description : Jeu Unity 2D
****************** */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    //Déclaration de variable
    private ScoreData sd;
    //Méthode qui marche tant que la scène est active 
    void Awake()
    {
        var json = PlayerPrefs.GetString("scores", "{}");
        sd = JsonUtility.FromJson<ScoreData>(json);
    }
    //Méthode qui filtre la liste de scores pour avoir en premier les temps les moins longs
    public IEnumerable<Score> GetHighScores()
    {
        return sd.scores.OrderBy(x => x.score);
    }
    //Méthode qui ajoute un score
    public void AddScore(Score score)
    {
        sd.scores.Add(score);
    }
    //Méthode pour nettoyer la liste de scores
    public void ClearScore()
    {
        sd.scores.Clear();
    }
    //Méthode qui est appellée quand la scène se ferme pour sauvegarder les scores
    private void OnDestroy()
    {
        SaveScore();
    }
    //Méthode qui sauvegarde les scores
    public void SaveScore()
    {
        var json = JsonUtility.ToJson(sd);
        Debug.Log(json);
        PlayerPrefs.SetString("scores", json);
    }
}


