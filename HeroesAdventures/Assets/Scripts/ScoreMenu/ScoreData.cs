/* *****************
 Programme : HerosAdventures
 Auteur : Abel Eisman Camara
 Projet : TPI 2021
 Date : 03.05.2021 - 20.05.2021
 Version : 1.0
 Description : Jeu Unity 2D
****************** */
using System;
using System.Collections.Generic;

[Serializable]
public class ScoreData
{
    //Déclaration de variable
    public List<Score> scores;
    //Constructeur qui contient la liste Score
    public ScoreData()
    {
        scores = new List<Score>();
    }
}