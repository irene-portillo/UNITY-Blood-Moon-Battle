using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttacks : MonoBehaviour
{
    //SPRITE
    private SpriteRenderer spriteRendererPlr;
    public GameObject spriteObjHolder;
    public Sprite idlePlr;
    public Sprite attackPlr;
    //LOGIC
    public float attackRate; 
    private float attackTimer = 0;
    private bool isAttacking = false;
    private GameObject enemyObject; // set through collision 

    void Start()
    {
    }

    void Update()
    {
        if ( Input.GetKey(KeyCode.F) && playerCanAttack() ) // player attempts to attack 
        {
        }
    }

    private bool playerCanAttack() 
    {
        return (enemyObject != null) && (attackTimer >= attackRate); // Check if colliding w enemy & cooldown is ok
    }

}