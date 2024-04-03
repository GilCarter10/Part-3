using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BlueDisc : Disc
{

    public static int blueScore = 0;

    public TextMeshProUGUI scoreP1;

    int oldScore = 0;

    private void Update()
    {
        scoreP1.text = "Score: " + blueScore.ToString();
    }

    public override void UpdateScore(int scoreValue)
    {
        base.UpdateScore(scoreValue);
        
        if (currentScore != oldScore)
        {
            blueScore += currentScore;
            blueScore -= oldScore;
            oldScore = currentScore;

        }

    }

    

}
