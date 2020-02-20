using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public GameObject ObjectToBeSpawned;
    BoxCollider2D spawnArea;
    float elapsedTime = 0;
    public float spawnTime = 2;

	// Use this for initialization
	void Start () {
        spawnArea = GetComponent<BoxCollider2D>();
		
	}
    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > spawnTime)
        {
            SpawnObject();
            elapsedTime = 0;
        }
    }
    Vector3 PickPosition()
    {
        float x = Random.Range(spawnArea.bounds.min.x, spawnArea.bounds.max.x);
        float y = transform.position.y;
        return new Vector3(x, y, 0);
    }
    public void SpawnObject()
    {
        Instantiate(ObjectToBeSpawned, PickPosition(), Quaternion.identity);
    }
	
	
	
}
