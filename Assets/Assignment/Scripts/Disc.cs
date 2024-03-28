using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Disc : MonoBehaviour
{

    public Vector2 direction;
    float power;
    float maxPower;
    public float speed = 50;
    public Rigidbody2D rb;

    

    void Start()
    {
        power = -2f;
    }

    private void FixedUpdate()
    {
        if (direction != Vector2.zero)
        {
            rb.AddForce(direction * speed, ForceMode2D.Impulse);
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
        direction = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position).normalized * power;
    }

}
