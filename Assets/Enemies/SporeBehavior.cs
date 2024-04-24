using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SporeBehavior : MonoBehaviour
{
    public float lifetime;
    public CircleCollider2D sporeCollider;
    public float velocity;

    void Start(){
        lifetime += Time.time;
    }

    void Update()
    {
        manageLifetime(); // Make sure it's within its lifetime
        transform.position -= (Vector3.left * velocity) * Time.deltaTime; //Move position
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("collided!");
        Destroy(gameObject); // Destroy itself on collision
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
