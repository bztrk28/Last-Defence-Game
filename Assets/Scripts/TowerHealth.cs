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
            EndGame(); // Oyun biti� fonksiyonunu �a��r
        }
    }

    void EndGame()
    {
        Destroy(slider.gameObject);
        Destroy(gameObject);
        // GameManager �zerinden oyunu bitir
        if (GameManager.instance != null)
        {
            GameManager.instance.GameOver();
        }
    }
}
