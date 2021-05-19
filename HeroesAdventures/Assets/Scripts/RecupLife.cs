using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RecupLife : MonoBehaviour
{
    // Start is called before the first frame update
    public Text NbLife;
    string affichageLife;
    // Update is called once per frame
    void Update()
    {
        affichageLife = PlayerPrefs.GetInt("LifeRecup", 0).ToString();
        NbLife.text = affichageLife + " X";

    }
}
