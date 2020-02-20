using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyData : MonoBehaviour {

    public int MinDamage = 98;
    public int MaxDamage = 100;
    public int damage;

	// Use this for initialization
	void Start () {
        damage = Random.Range(MinDamage, MaxDamage);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
