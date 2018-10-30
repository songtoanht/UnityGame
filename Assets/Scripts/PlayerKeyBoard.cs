using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKeyBoard : MonoBehaviour {

    public float speed = 8f;
    public float maxVelocity = 4f;

    //[SerializeField]
    private Rigidbody2D myBody;
    private Animator anim;

    //call first 
    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        PlayerMoveKeyBoard();
	}

    void PlayerMoveKeyBoard()
    {
        float forxeX = 0f;
        float vel = Mathf.Abs(myBody.velocity.x);

        float h = Input.GetAxisRaw("Horizontal");// -1 0 1

        if (h>0)
        {
            if (vel < maxVelocity)
            {
                forxeX = speed;

                Vector3 temp = transform.localScale;
                temp.x = 1.5f;
                transform.localScale = temp;

                anim.SetBool("walk", true);
            } 
        } else if (h < 0) 
        {
            if (vel < maxVelocity)
            {
                forxeX = -speed;

                Vector3 temp = transform.localScale;
                temp.x = -1.5f;
                transform.localScale = temp;

                anim.SetBool("walk", true);
            }
        } else
        {
            anim.SetBool("walk", false);
        }
        myBody.AddForce(new Vector2(forxeX, 0));
    }
}
