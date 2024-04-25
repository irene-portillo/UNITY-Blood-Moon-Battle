using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManageHealthUi : MonoBehaviour
{
    public Text healthStatus;
    public PlayerHealth playerHealthScript;
    public Animator heartAnimator;

    void Start(){}

    void Update()
    {
        setHpStatus(playerHealthScript.getPlayerHealth());
        handleHeartAnims(playerHealthScript.getPlayerHealth());
    }

    void setHpStatus(int plrHealth)
    {
        healthStatus.text = plrHealth + " HP";
    }

    void handleHeartAnims(int plrHealth)
    {
        if (plrHealth <= 30)
        {
            heartAnimator.SetBool("healthIsLow", true);
        }
    }
}
