//##### SOURCE: Followed tutorial "Code Class - 2D Player Movement in Unity" by AdamCYounis #####//
//##### link: https://www.youtube.com/watch?v=0-c3ErDzrh8 #####//

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // NOTE: C uses public/private vars -- SIMILAR TO JAVA 
    // be careful, these vars are SET IN UNITY ENGINE
    public float acceleration;
    public float groundSpeed; 
    public float jumpSpeed; 
    [Range(0f, 1f)]
    public float groundDecay = 0.9f;

    public Rigidbody2D rigBody;
    public BoxCollider2D groundCollider;
    public LayerMask groundMask;
    public bool grounded;

    float xInput;
    float yInput;

    // Start is called before the first frame update
    void Start(){}

    // Update is called once per frame
    void Update()
    {
        getInput();
        handleJump();
    }

    // runs to catch up w quote // things move in frame independent way // used for input? 
    private void FixedUpdate()
    {
        moveWithInput();
    }

    void getInput()
    {
        xInput = Input.GetAxis("Horizontal"); // returns coordinate based on if left or right (-1,0) and (1,0)
        yInput = Input.GetAxis("Vertical");  
    }

    void moveWithInput() // .normalized makes sure diagnally is same speed -- if u wanna add 
    {
        if (Mathf.Abs(xInput) > 0) // Check x input 
        {
            float increment = xInput * acceleration;
            float newSpeed = Mathf.Clamp(rigBody.velocity.x + increment, -groundSpeed, groundSpeed); // num in first param cant exceed 2nd or 3rd vals
            rigBody.velocity = new Vector2(newSpeed, rigBody.velocity.y);

        }
        
    }

    void handleJump()
    {
        if (Input.GetButtonDown("Jump")  && grounded) // Check y input 
        {
            rigBody.velocity = new Vector2(rigBody.velocity.x, jumpSpeed); 
        }
    }

