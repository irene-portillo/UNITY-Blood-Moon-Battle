using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SporeBehavior : MonoBehaviour
{
    public int lifetime;
    public CircleCollider2D sporeCollider;
    public float velocity;

    // Start is called before the first frame update
    void Start(){}

    // Update is called once per frame
    void Update(){}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject); // Destroy itself on collision

    }

}
