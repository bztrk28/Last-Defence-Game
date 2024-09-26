using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienMovement : MonoBehaviour
{

    public Rigidbody2D alienRb;
    public float speed;

    void FixedUpdate()
    {
        alienRb.velocity = Vector2.left * speed;
    }
}
