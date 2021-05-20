/* *****************
 Programme : HerosAdventures
 Auteur : Abel Eisman Camara
 Projet : TPI 2021
 Date : 03.05.2021 - 20.05.2021
 Version : 1.0
 Description : Jeu Unity 2D
****************** */
using System;

[Serializable]
public class Score
{
    //Déclarations de variables
    public string name;
    public float score;

    //Constructeur de Score
    public Score(string name, float score)
    {
        this.name = name;
        this.score = score;
    }
}