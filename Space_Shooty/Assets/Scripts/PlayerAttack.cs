using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {
    public GameObject BulletObject;
    Vector3 ship;
    PlayerData data;

	// Use this for initialization
	void Start () {
        data = GetComponent<PlayerData>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0)&& data.Ammo >=1)
        {
            ship = transform.position;
            Instantiate(BulletObject, ship, Quaternion.identity);
            data.Ammo--;
        }
        
	}
}
