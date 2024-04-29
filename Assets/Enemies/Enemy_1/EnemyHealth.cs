using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public AnimateEnemy animScript;
    public int enemyHealth;
    private int currHitsTaken = 0;
    public GameLogic gameLogicScript;

    public bool deathAnimPlayed = false;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void takeDamage(int amount)
    {

        if ( (enemyHealth - amount ) > 0)
        {
            enemyHealth -= amount;
            Debug.Log("------------------>ENEMY took damage! Health: " + enemyHealth);
            animScript.startDamageAnim();
            currHitsTaken++;
        }
        else if(deathAnimPlayed == false)
        {
            Debug.Log("enemy just died!");
            animScript.startDeathAnim();
            gameLogicScript.setPlrWonFight();
            deathAnimPlayed = true;
        }
        
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
