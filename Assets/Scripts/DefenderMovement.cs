using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D defenderRb;

    void Start()
    {
        
        defenderRb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // Klavye giri�i
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");    

        // Hareket y�n�
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        defenderRb.velocity = movement * speed;
    }
}
