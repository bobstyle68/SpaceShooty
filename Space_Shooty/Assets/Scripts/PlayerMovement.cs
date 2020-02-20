﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed = 10;
    float horizontal;
    Vector3 nextPosition;
    Rigidbody2D body;

	// Use this for initialization
	void Start () {
        body = GetComponent<Rigidbody2D>();
        
		
	}
	
	// Update is called once per frame
	void Update () {

        horizontal = Input.GetAxis("Horizontal");
        nextPosition.x = horizontal * speed * Time.deltaTime;
        
	}

    private void FixedUpdate()
    {
        body.velocity = nextPosition;
    }
}
