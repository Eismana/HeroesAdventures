using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RecupName : MonoBehaviour
{
    //D�claration variable
    public Text NomAv;
    //Start() est appel� au lancement de la sc�ne
    void Start()
    {
        //Permet de r�cuperer l'input du nom dans le menu et l'afficher dans le text en haut � gauche du niveau 1 pour l'instant
        string affichageName = PlayerPrefs.GetString("PlayerName", "default");
        NomAv.text = affichageName;
        Debug.Log(affichageName);
    }


}
