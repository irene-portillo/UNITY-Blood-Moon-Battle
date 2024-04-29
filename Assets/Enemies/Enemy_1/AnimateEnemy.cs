using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateEnemy : MonoBehaviour
{
    public Animator enemyAnimator;
    public EnemyBehavior enBehaviorScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // DAMAGE //
    public void startDamageAnim() //called on by EnemyHealth script
    {
        enemyAnimator.SetBool("isTakingDamage", true);
    }

    public void endDamageAnim() // triggered through end of animation
    {
        Debug.Log("was this ever called???");
        enemyAnimator.SetBool("isTakingDamage", false);
        enBehaviorScript.swtichPosition();
    }
    

    // DASH // 
    public void startDashAnim()
    {
        enemyAnimator.SetBool("isSwitchingSide", true);
    }

    public void endDashAnim() // triggered through end of animation
    {
        enemyAnimator.SetBool("isSwitchingSide", false);
    }

    // DEATH //
    public void startDeathAnim()
    {
        enemyAnimator.SetBool("isDead", true);
    }

    public float getSpriteBounds()
    {
        return GetComponent<SpriteRenderer>().bounds.size.x;
    }

}
