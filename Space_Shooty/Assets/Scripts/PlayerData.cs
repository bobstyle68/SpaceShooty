using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerData : MonoBehaviour {
    int health;
    public int StartingHealth =100;
    public int Lives = 5;
    public int Ammo = 100;
    EnemyData enemyData;

	// Use this for initialization
	void Start () {
        health = StartingHealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            enemyData = collision.gameObject.GetComponent<EnemyData>();
            
            
            health = health - enemyData.damage;
            Debug.Log(health);
            
            Destroy(collision.gameObject);
            
        }
        if (health <= 1)
        {
            Debug.Log(Lives);
            Lives = Lives - 1;
            
            health = StartingHealth;

        }
        if (Lives <= 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
