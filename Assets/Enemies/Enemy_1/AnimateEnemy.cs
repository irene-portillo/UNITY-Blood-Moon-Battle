using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateEnemy : MonoBehaviour
{
    public Animator enemyAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startDamageAnim() //called on by EnemyHealth script
    {
        enemyAnimator.SetBool("isTakingDamage", true);
    }

    public void endDamageAnim() // triggered through end of animation
    {
        enemyAnimator.SetBool("isTakingDamage", false);
    }
}
