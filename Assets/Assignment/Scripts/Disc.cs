using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Disc : MonoBehaviour
{

    public Vector2 direction;
    public float speed = -100;
    public Rigidbody2D rb;

    public bool moveable = true;
    

    void Start()
    {
    }

    private void FixedUpdate()
    {
        if (direction != Vector2.zero)
        {
            rb.AddForce(direction * speed, ForceMode2D.Impulse);
            direction = Vector2.zero;
            moveable = false;

        }
    }


    void Update()
    {

    }

    private void OnMouseDown()
    {
        
    }

    private void OnMouseDrag()
    {
        
    }

    private void OnMouseUp()
    {
        if (moveable)
        {
            direction = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position).normalized;
            moveable = false;
        }
    }


}
