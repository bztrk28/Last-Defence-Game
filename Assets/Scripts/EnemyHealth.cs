using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 50;
    public float delayTime = .15f;
    public AlienMovement alienMovement;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        StartCoroutine(knockbackDelay());
    }

    IEnumerator knockbackDelay()
    {
        alienMovement.enabled=false;
        yield return new WaitForSeconds(delayTime);
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            alienMovement.enabled=true;
        }
    }
}
