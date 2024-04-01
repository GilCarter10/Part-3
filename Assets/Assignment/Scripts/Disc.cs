using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Disc : MonoBehaviour
{

    public Vector2 direction;
    public float power;
    Rigidbody2D rb;

    public bool moveable = false;
    public bool finished = false;
    

    void Start()
    {
        power = -150f;
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
            Debug.Log("YUP");
            direction = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position).normalized * power;
            moveable = false;
            finished = true;
        }
    }


}
