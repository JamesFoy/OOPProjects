using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TernaryOperator : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        int health = 10;
        string message;

        message = health > 0 ? "Player is Alive" : health == 0 ? "Player is Barely Alive" : "Player is Dead";
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
