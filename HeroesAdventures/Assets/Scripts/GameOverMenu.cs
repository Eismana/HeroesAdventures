using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Quit()
    {
        Application.Quit();


    }
    public void Replay()
    {
        SceneManager.LoadScene(0);
    
    }
    public void Score()
    {
        SceneManager.LoadScene("Score");

    }

}
