using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    //Fonction qui permet de vérifier si le héro avec le tag "Player" touche cette zone ce qui permet de revenir au début du niveau en rechargeant la scène en cas de chute
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
        }
    }
}
