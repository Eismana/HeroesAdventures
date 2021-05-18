using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ScoreUi : MonoBehaviour
{
    public RowUi rowUi;
    public ScoreManager scoreManager;

    void Start()
    {
        
        scoreManager.AddScore(new Score(PlayerPrefs.GetString("PlayerName"), PlayerPrefs.GetFloat("timer")));
        scoreManager.AddScore(new Score("Player1", 45));
        scoreManager.AddScore(new Score("Player2", 60));
        scoreManager.AddScore(new Score("Player3", 60));
        scoreManager.AddScore(new Score("Player4", 60));

        var scores = scoreManager.GetHighScores().ToArray();
        for (int i = 0; i < 5; i++)
        {
            var row = Instantiate(rowUi, transform).GetComponent<RowUi>();
            row.rank.text = (i + 1).ToString();
            row.nameScore.text = scores[i].name;
            row.score.text = string.Format("{0:0}:{1:00}", Mathf.Floor(scores[i].score / 60), scores[i].score % 60);
        }
    }
}