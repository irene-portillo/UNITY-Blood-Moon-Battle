using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int enemyHealth;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void takeDamage(int amount)
    {
        enemyHealth -= amount;
        Debug.Log("ENEMY took damage! Health: " + enemyHealth);
    }
}
