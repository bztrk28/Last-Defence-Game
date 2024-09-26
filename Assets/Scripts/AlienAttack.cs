using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienAttack : MonoBehaviour
{
    public int damage = 15;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<TowerHealth>())
        {
            collision.gameObject.GetComponent<TowerHealth>().health -= damage;
            Destroy(gameObject);
        }
    }

}
