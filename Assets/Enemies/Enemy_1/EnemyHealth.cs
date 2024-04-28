using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public AnimateEnemy animScript;
    public int enemyHealth;
    private int currHitsTaken = 0;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void takeDamage(int amount)
    {
        enemyHealth -= amount;
        Debug.Log("------------------>ENEMY took damage! Health: " + enemyHealth);
        animScript.startDamageAnim();
        currHitsTaken++;
    }

    public int getHits()
    {
        return currHitsTaken;
    }

    public void resetHits()
    {
        currHitsTaken = 0;
    }
}
