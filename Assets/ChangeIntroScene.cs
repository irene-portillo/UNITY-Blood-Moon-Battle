using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeIntroScene : MonoBehaviour
{
    public float sceneTime;
    public string sceneName;
    public Image transImg;
    public Text titleTxt;
    public GameObject dialougeBox;
    public TMP_Text dialougeText;
    private int index =0;
    List<string> dialougeStrings;

    void Start()
    {
        setUiVisible();
        setDialougeStrings();
    }

    void Update()
    {
        if(isDoneWithCutscene() == false){ return; } // CUTSCENE is still going     
        if(index == 0 | Input.GetMouseButtonDown(0)) // CUTSCENE ended
        {
            dialougeBox.SetActive(true);
            setDialougeText();
            index++;
        }
    }
    
    // set new text in dialouge box
    void setDialougeText()
    {
        if(index < dialougeStrings.Count ) { dialougeText.SetText(dialougeStrings[index]); }
        else {SceneManager.LoadScene(sceneName); }
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
            "Our world was not always shrouded in darkness and whispered tales.",
            "Long ago, there existed a land— a land where the moon reigned supreme, casting its red ruby light upon all who dwelled below. ",
            "But one fateful night, the moon's gentle glow was stolen away, leaving the land veiled in eternal night.",
            "Without the moon's guiding light, darkness crept into every corner, swallowing hope and plunging the world into despair.",
            "I wouldn't venture out there if I were you, kid. But hey, if you're feeling adventurous and don't mind a few bruises, who am I to stop you?"
        };

    }

    // set scene
    void setUiVisible()
    {
        transImg.gameObject.SetActive(true);
        titleTxt.gameObject.SetActive(true);
    }
}
