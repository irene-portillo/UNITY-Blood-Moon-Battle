using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int plrHealth;
    public BoxCollider2D plrHitBoxBody;
    public BoxCollider2D plrHitBoxFt;
    public GameLogic gameLogicScript;


    public animatePlayer animPlrScript;
    // Start is called before the first frame update
    void Start(){}

    // Update is called once per frame
    void Update(){
        if (gameLogicScript.gameOver == true) { return;} // make sure game isnt over 
        checkPlrHealth();
    }


    public void decreaseHealth(int increment)
    {
        if( plrHealth > 0)
        {
            plrHealth -= increment;
        }
    }

    void checkPlrHealth()
    {
        if (plrHealth <= 0)
        {
            Debug.Log("Player has DIED!!!!");
            animPlrScript.startPlrIsDead();
            gameLogicScript.setGameOver();
        }
    }

    public int getPlayerHealth()
    {
        return plrHealth;
    }
}
