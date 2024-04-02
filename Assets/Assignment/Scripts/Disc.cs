using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disc : MonoBehaviour
{
    public int currentScore = 0;

    public virtual void UpdateScore(int scoreValue)
    {
        currentScore = scoreValue;
    }
}
