﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damagetest : MonoBehaviour
{
    Health currentHealth;
    Health takeDamage;
    public float amount = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        //currentHealth -= amount;
        takeDamage.currentHealth -= amount;
    }
}
