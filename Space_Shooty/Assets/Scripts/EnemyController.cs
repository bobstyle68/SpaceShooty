using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public float speed = -5;
    Rigidbody2D body;

	// Use this for initialization
	void Start () {

        body = GetComponent<Rigidbody2D>();
        body.velocity =  new Vector2(0, speed);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Kill")
        {
            Debug.Log("Gnigger");
            Destroy(gameObject);
        }
    }
}
