using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedDisc : Disc
{
    public static int redScore = 0;

    int oldScore = 0;

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
