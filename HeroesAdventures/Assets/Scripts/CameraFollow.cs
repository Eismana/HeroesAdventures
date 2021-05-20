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

public class CameraFollow : MonoBehaviour
{
    //Déclaration variables
    public Transform target;
    public Vector3 offset;

    
    //La caméra suit la position de la cible sélectionée
    private void FixedUpdate()
    {
        transform.position = target.position+offset;
    }
}
