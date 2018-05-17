using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
	public GameObject GameOverScreen ;

	public Text secsSurvived;
	public bool gameOver;



	void Start () {
		
		
		
	}
	
	// Update is called once per frame
	void Update () {
		if (gameOver) {
			if(Input.touchCount>1)
			SceneManager.LoadScene (0);
		}
	}

	public void OnGameOver(){
		GameOverScreen.SetActive (true);
		secsSurvived.text = Mathf.RoundToInt(Time.timeSinceLevelLoad).ToString();
		gameOver = true;
	}
		
}
