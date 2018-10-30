using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Joystick : MonoBehaviour, IPointerUpHandler, IPointerDownHandler {
    private PlayerJoystick playerJoystick;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (gameObject.name == "Left")
        {
            playerJoystick.setMoveLeft(true);
        } else
        {
            playerJoystick.setMoveLeft(false);
        }
        
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (gameObject.name == "Left")
        {
            playerJoystick.stopMoving();
        }

        if (gameObject.name == "Right")
        {
            playerJoystick.stopMoving();
        }
    }

    // Use this for initialization
    void Start () {
        playerJoystick = GameObject.Find("playerA").GetComponent<PlayerJoystick>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
