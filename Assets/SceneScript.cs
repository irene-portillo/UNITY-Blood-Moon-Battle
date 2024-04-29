using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneScript : MonoBehaviour
{

    public Camera mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        //setCameraSize(1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void setCameraSize(float size)
    {
        mainCamera.orthographicSize = size;
    }
}
