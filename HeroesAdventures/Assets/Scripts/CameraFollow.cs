using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //D�claration variables
    public Transform target;
    public Vector3 offset;

    
    //La cam�ra suit la position de la cible s�lection�e
    private void FixedUpdate()
    {
        transform.position = target.position+offset;
    }
}
