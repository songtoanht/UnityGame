using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player {


    int health = 100;
    int power = 80;
    string name = "Warriors";

    public Player()
    {
        Debug.Log("Player with health " + health + "; power " + power + "; name " + name);
    }
}
