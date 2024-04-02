using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueDisc : Disc
{

    public static int blueScore = 0;

    int oldScore = 0;

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
