using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatePlayer : MonoBehaviour
{

    public Animator plrAnimtor;

    // DEATH ANIM
    public void startPlrIsDead()
    {
        plrAnimtor.SetBool("plrIsDead", true);
    }

    public void endPlrIsDead()
    {
        plrAnimtor.SetBool("plrIsDead", false);
        Debug.Log("RAN PLAYER IS DEAD");
    }
    // REWRITE ANIMATIONS ON HERE AND ADD THEM HERE TO MAKE CODE CLEANER SOME OTHER TIME 
}
