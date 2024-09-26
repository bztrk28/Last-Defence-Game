using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject gunPrefab; 
    public float fireRate = 0.5f; 
    private float nextFireTime = 0f; 

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0) && Time.time >= nextFireTime)
        {
            FireLaser();
            nextFireTime = Time.time + fireRate; 
        }
    }

    void FireLaser()
    {
        
        Instantiate(gunPrefab, transform.position, transform.rotation);
    }
}
