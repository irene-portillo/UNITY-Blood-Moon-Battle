using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SporeBehavior : MonoBehaviour
{
    public CircleCollider2D sporeCollider;
    public float lifetime;
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
        setPosition(); // set direction + pos of spore
    }

    void setPosition()
    {
        float direction = Mathf.Sign(transform.parent.localScale.x); // see which way char is facing -1 or 1 
        transform.position -= direction * (Vector3.left * velocity) * Time.deltaTime; //Move position
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
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
            Destroy(gameObject); // Destroy itself after passes liftime
        }

    }

}
