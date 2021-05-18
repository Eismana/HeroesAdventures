using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    float time;
    public float TimerInterval = 5f;
    float tick;
    // Start is called before the first frame update
    void Awake()
    {
        time = (int)Time.time;
        time = TimerInterval;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = string.Format("{0:0}:{1:00}",Mathf.Floor(time/60),time%60);
        time = (int)Time.time;

        if (time == tick)
        {
            tick = time + TimerInterval;
            //executer le code du timer
            TimerExecute();
        }
        PlayerPrefs.SetFloat("timer", time);
    }

    void TimerExecute()
    {
        Debug.Log("Timer");
    }
}
