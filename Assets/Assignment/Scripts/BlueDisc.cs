using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueDisc : Disc
{

    public static int blueScore;

    private void Update()
    {
        Debug.Log(blueScore);
    }


    public override void UpdateScore(int scoreValue)
    {
        base.UpdateScore(scoreValue);
    }

    //add function that adds personal score to blueScore

}
