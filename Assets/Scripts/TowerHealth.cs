using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 50;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        slider.maxValue = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = health;

        if (health <= 0)
        {
            EndGame(); // Oyun bitiþ fonksiyonunu çaðýr
        }
    }

    void EndGame()
    {
        Destroy(slider.gameObject);
        Destroy(gameObject);
        // GameManager üzerinden oyunu bitir
        if (GameManager.instance != null)
        {
            GameManager.instance.GameOver();
        }
    }
}
