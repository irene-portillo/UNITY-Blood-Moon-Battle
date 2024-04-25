using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int plrHealth;
    public BoxCollider2D plrHitBoxBody;
    public BoxCollider2D plrHitBoxFt;

    public Animator plrAnimtor;

    // Start is called before the first frame update
    void Start(){}

    // Update is called once per frame
    void Update(){
        checkPlrHealth();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Damage plr if touches spore
        if (collision.gameObject.layer == LayerMask.NameToLayer("Spore")){
            decreaseHealth(5);
        }
    }

    private void decreaseHealth(int increment)
    {
        plrHealth -= increment;
    }

    void checkPlrHealth()
    {
        if (plrHealth <= 0)
        {
            Debug.Log("Player has DIED!!!!");
            plrAnimtor.SetBool("plrIsDead", true); // update health for anim
        }
    }
}
