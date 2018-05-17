using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {

	public GameObject FallingBlock;
	public GameObject startScreen; 
	public GameObject Buttons;
	Vector2 screenHalfWidthInRealWorld;
	public Vector2 timeBetweenSpawnsMinMax;
	float nextSpawnTime;
	public Vector2 spawnSizeMinMax ; 
	public float maxAngle;
	void Start () {
		screenHalfWidthInRealWorld = new Vector2 (Camera.main.aspect * Camera.main.orthographicSize, Camera.main.orthographicSize);

	
	}
	
	void Update () {
		if (Input.touchCount>0) {
			
			startScreen.SetActive (false);
			Buttons.SetActive (true);

		}
		if (startScreen.activeSelf==false) {
     
			if (Time.time > nextSpawnTime) {
			
				float spawnAngle = Random.Range (-maxAngle, maxAngle);
				float spawnSize = Random.Range (spawnSizeMinMax.x, spawnSizeMinMax.y);
				float timeBetweenSpawns = Mathf.Lerp (timeBetweenSpawnsMinMax.y, timeBetweenSpawnsMinMax.x, Difficulty.GetDifficultyPercent ());
				nextSpawnTime = Time.time + timeBetweenSpawns;
				Vector2 spawnPosition = new Vector2 (Random.Range (-screenHalfWidthInRealWorld.x, screenHalfWidthInRealWorld.x), screenHalfWidthInRealWorld.y + spawnSize);
				GameObject newBlock = (GameObject)Instantiate (FallingBlock, spawnPosition, Quaternion.Euler (Vector3.forward * spawnAngle));
				newBlock.transform.localScale = Vector2.one * spawnSize;
			}
		}
	}
}
