using System.Collections;
using System.Collections.Generic;
using System.Net;
using Unity.VisualScripting;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public int pointValue;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Disc disc = collision.GetComponent<Disc>();
        disc.UpdateScore(pointValue);
            
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Disc disc = collision.GetComponent<Disc>();
        disc.UpdateScore(0);
    }

}
