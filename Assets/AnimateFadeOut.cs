using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimateFadeOut : MonoBehaviour
{

    public Animator animator;
    public string sceneName;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startFadeOut()
    {
        animator.SetBool("shouldTransition", true);
    }

    public void endFadeOut()
    {
        SceneManager.LoadScene(sceneName);
    }
}
