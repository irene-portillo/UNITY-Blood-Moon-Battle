using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public GameObject sporeObj;
    public int spawnRate; // seconds 
    private float timer = 0 ;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        updateTimer();
    }

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
        SporeBehavior sbScript = newSpore.GetComponent<SporeBehavior>();
        sbScript.enabled = true; // enable its script
    }

}