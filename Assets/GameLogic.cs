using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameLogic : MonoBehaviour
{

    public bool gameOver = false;
    public bool plrWonFight = false;

    public Text defeateText;
    public AnimateFadeOut animateTransScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
   
    }

    public void setPlrWonFight()
    {
        plrWonFight = true;
        animateTransScript.startFadeOut();
    }

    public void setGameOver()
    {
        Debug.Log("GAME IS OVER");
        gameOver = true;
        defeateText.gameObject.SetActive(true);

    }
}
