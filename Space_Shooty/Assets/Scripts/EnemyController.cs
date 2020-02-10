using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public float speed = 5;
    Rigidbody2D body;

	// Use this for initialization
	void Start () {

        body = GetComponent<Rigidbody2D>();
        body = new Vector2();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
