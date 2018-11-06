using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJoystick : MonoBehaviour {

    public float speed = 8f;
    public float maxVelocity = 4f;

    //[SerializeField]
    private Rigidbody2D myBody;
    private Animator anim;

    private bool moveLeft, moveRight;

    //call first 
    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        RuntimeJNI.init();
    }


    // Use this for initialization
    void Start () {
	}

    public void setMoveLeft(bool moveLeft)
    {
        this.moveLeft = moveLeft;
        this.moveRight = !moveLeft;
    }

    public void stopMoving()
    {
        moveLeft = moveRight = false;
        anim.SetBool("walk", false);
        //RuntimeJNI.endSession();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (moveLeft)
        {
            MoveLeft();
        }

        if (moveRight)
        {
            MoveRight();
        }
    }

    void MoveLeft()
    {
        float forxeX = 0f;
        float vel = Mathf.Abs(myBody.velocity.x);
        if (vel < maxVelocity)
            forxeX = -speed;

            Vector3 temp = transform.localScale;
            temp.x = -1.5f;
            transform.localScale = temp;

            anim.SetBool("walk", true);

        myBody.AddForce(new Vector2(forxeX, 0));
    }

    void MoveRight()
    {
        float forxeX = 0f;
        float vel = Mathf.Abs(myBody.velocity.x);
        if (vel < maxVelocity)
            forxeX = speed;

            Vector3 temp = transform.localScale;
            temp.x = 1.5f;
            transform.localScale = temp;

            anim.SetBool("walk", true);

        myBody.AddForce(new Vector2(forxeX, 0));
    }
}
