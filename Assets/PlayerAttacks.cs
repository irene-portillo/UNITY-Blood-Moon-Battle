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
        updateTimer();
    }

    private bool playerCanAttack() 
    {
        return (enemyObject != null) && (attackTimer >= attackRate); // Check if colliding w enemy & cooldown is ok
    }

    void updateTimer()
    {
        if (attackTimer < attackRate) // cooldown in process
        {
            isAttacking = true;
            attackTimer += Time.deltaTime;
        }
        else // cooldown complete
        {
            isAttacking = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            enemyObject = collision.gameObject; // colliding with enemy
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        enemyObject = null; // not colliding to anything  
    }

}
