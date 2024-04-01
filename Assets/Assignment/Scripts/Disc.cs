using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Disc : MonoBehaviour
{

    public int personalScore = 0;

    public virtual void UpdateScore(int scoreValue)
    {
        personalScore = scoreValue;
    }

}
