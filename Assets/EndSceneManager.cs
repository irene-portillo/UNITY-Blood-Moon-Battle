using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EndSceneManager : MonoBehaviour
{

    public float sceneTime;
    //public string sceneName; // not trnaistioning somewhere else i think
    public Image transImg;
    public GameObject dialougeBox;
    public TMP_Text dialougeText;
    private int index = 0;
    List<string> dialougeStrings;

    public Text victoryText;

    void Start()
    {
        setUiVisible();
        setDialougeStrings();
    }


    void Update()
    {
        if (isDoneWithCutscene() == false) { return; } // CUTSCENE is still going     
        if (index == 0 | Input.GetMouseButtonDown(0)) // CUTSCENE ended
        {
            dialougeBox.SetActive(true);
            setDialougeText();
            index++;
        }
    }

    // set new text in dialouge box
    void setDialougeText()
    {
        if (index < dialougeStrings.Count) { 
            dialougeText.SetText(dialougeStrings[index]); 
        }
        else 
        {
            dialougeBox.SetActive(false);
            victoryText.gameObject.SetActive(true);
        }
    }

    // check if done w cutscene
    bool isDoneWithCutscene()
    {
        if (sceneTime <= 0)
        {
            return true;
        }
        else
        {
            sceneTime -= Time.deltaTime;
            return false;
        }
    }

    // GAME DIALOUGE
    void setDialougeStrings()
    {
        dialougeStrings = new List<string>
        {
            "After a long and arduous journey, you stand before the coveted Moon Stone, victorious at last."
        };

    }

    // set scene
    void setUiVisible()
    {
        transImg.gameObject.SetActive(true);
    }
}
