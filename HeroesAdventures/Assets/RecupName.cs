using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RecupName : MonoBehaviour
{
    public Text NomAv;
    // Start is called before the first frame update
    void Start()
    {
        string affichageName = PlayerPrefs.GetString("PlayerName", "default");
        NomAv.text = affichageName;
        Debug.Log(affichageName);
    }

    // Update is called once per frame

}
