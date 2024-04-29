using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    // SHOOTING 
    public GameObject sporeObj;
    public int spawnRate; // seconds 
    private float timer = 0;

    // MOVEMENT 
    public PlayerMovement plrMoveScript;
    private EnemyHealth enHealthScript;
    public AnimateEnemy animEnScript;

    //HEALTH
    public GameLogic gameLogScript;

    void Start()
    {
        enHealthScript = transform.GetComponent<EnemyHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameLogScript.plrWonFight) { return; }
        updateTimer();
        checkHits();
    }

    ////////////////////////////////////////////////// MOVEMENT //////////////////////////////////////////////////////////////////////////
    void checkHits()
    {
        if(enHealthScript.getHits() >= 5)
        {
            triggerDashAnim();
            enHealthScript.resetHits();
        }
    }

    void triggerDashAnim()
    {
        animEnScript.startDashAnim(); // end of anim will call swtichPosition()
    }

    public void swtichPosition()
    {
        // VARS
        Vector3 playerPos = plrMoveScript.getPlayerPos();
        float imgWidth = animEnScript.getSpriteBounds();

        // decide on addition or subtraction 
        float sign = Mathf.Sign( transform.localScale.x);

        // +- amount of image width 
        float newX = imgWidth * (sign) + transform.position.x; // BUG NOW, hitting / attacks 

        transform.position = new Vector3(newX, transform.position.y);
        flipSpriteImg();
        Debug.Log("ran switch pos ");
    }

    private void flipSpriteImg()
    {
        Vector3 newScale = transform.localScale;
        newScale.x *= -1;
        transform.localScale = newScale;
    }

    private bool isFlipped() // true means scale == -1  // false means scale == 1  
    {
        return ( transform.localScale.x < 0 ); 
    }
////////////////////////////////////////////////// SHOOTING //////////////////////////////////////////////////////////////////////////
void updateTimer() // update timer + shoots 
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            shootSpore();
            timer = 0;
        }
    }

    void shootSpore()
    {
        GameObject newSpore = Instantiate(sporeObj, transform.position, transform.rotation); //create spore
        newSpore.transform.SetParent(transform);
        SporeBehavior sbScript = newSpore.GetComponent<SporeBehavior>();
        sbScript.enabled = true; // enable its script
    }

}
