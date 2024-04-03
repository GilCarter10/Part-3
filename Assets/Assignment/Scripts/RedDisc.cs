using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class RedDisc : Disc
{
    public static int redScore = 0;

    public TextMeshProUGUI scoreP2;

    int oldScore = 0;

    private void Update()
    {
        scoreP2.text = "Score: " + redScore.ToString();
    }

    public override void UpdateScore(int scoreValue)
    {
        base.UpdateScore(scoreValue);

        if (currentScore != oldScore)
        {
            redScore += currentScore;
            redScore -= oldScore;
            oldScore = currentScore;

        }
    }




}
