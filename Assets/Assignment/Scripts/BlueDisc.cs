using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BlueDisc : Disc
{

    public static int blueScore = 0;
    int personalScore = 0;


    private void Update()
    {
        Debug.Log(blueScore);
    }

    public override void UpdateScore(int scoreValue)
    {
        base.UpdateScore(scoreValue);

        if (tempScore != personalScore)
        {
            blueScore += personalScore;
        }
    }

}
