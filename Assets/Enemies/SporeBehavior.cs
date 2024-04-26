using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SporeBehavior : MonoBehaviour
{
    public float lifetime;
    public CircleCollider2D sporeCollider;
    public float velocity;
    private PlayerHealth plrHealthScript;

    void Start(){
        lifetime += Time.time;
        GameObject playerObj = GameObject.FindGameObjectWithTag("Player"); // set player health script var
        plrHealthScript = playerObj.GetComponent<PlayerHealth>();

    }

    void Update()
    {
        manageLifetime(); // Make sure it's within its lifetime
        transform.position -= (Vector3.left * velocity) * Time.deltaTime; //Move position
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("collided!");
        checkCollidePlr(collision); // check if collided w plr
        Destroy(gameObject); // Destroy itself on collision
    }

    void checkCollidePlr(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            plrHealthScript.decreaseHealth(5);
        }
    }

    void manageLifetime()
    {
        if ( Time.time >= lifetime) 
        {
            //Debug.Log("died bc of time");
            Destroy(gameObject); // Destroy itself after passes liftime
        }

    }

}
