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
