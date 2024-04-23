using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SporeBehavior : MonoBehaviour
{
    public int lifetime;
    public CircleCollider2D sporeCollider;
    public float velocity;

    void Start(){}

    void Update()
    {
        manageLifetime(); // Make sure it's within its lifetime
        transform.position -= (Vector3.left * velocity) * Time.deltaTime; //Move position
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject); // Destroy itself on collision
    }

    void manageLifetime()
    {
        if ((int)Time.time >= lifetime)
        {
            Destroy(gameObject); // Destroy itself after passes liftime
        }
    }

}
