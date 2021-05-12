using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class RecupGold : MonoBehaviour
{
    public Text NbGold;
    string affichageGold;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        affichageGold = PlayerPrefs.GetInt("GoldRecup", 0).ToString();
        NbGold.text = affichageGold + " X";
    }
}
