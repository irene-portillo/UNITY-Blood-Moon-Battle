using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int plrHealth;
    public BoxCollider2D plrHitBoxBody;
    public BoxCollider2D plrHitBoxFt;

    // Start is called before the first frame update
    void Start(){}

    // Update is called once per frame
    void Update(){}

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
}
