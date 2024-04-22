//##### SOURCE: Followed tutorial "Code Class - 2D Player Movement in Unity" by AdamCYounis #####//
//##### link: https://www.youtube.com/watch?v=0-c3ErDzrh8 #####//

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){}

    // Update is called once per frame
    void Update()
    {
        getInput();
    }
    void getInput()
    {
        xInput = Input.GetAxis("Horizontal"); // returns coordinate based on if left or right (-1,0) and (1,0)
        yInput = Input.GetAxis("Vertical");  
    }
