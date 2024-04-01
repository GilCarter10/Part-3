using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Mover : MonoBehaviour
{

    public Vector2 direction;
    public float power;
    Rigidbody2D rb;

    public bool moveable = false;
    public bool finished = false;

    void Start()
    {
        power = -150f;
        //moveable = false;
        rb = GetComponent<Rigidbody2D>();

    }

    private void FixedUpdate()
    {
        if (direction != Vector2.zero)
        {
            rb.AddForce(direction, ForceMode2D.Impulse);
            direction = Vector2.zero;

        }
    }

    private void OnMouseUp()
    {
        if (moveable)
        {
            direction = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position).normalized * power;
            moveable = false;
            finished = true;
        }
    }

}
