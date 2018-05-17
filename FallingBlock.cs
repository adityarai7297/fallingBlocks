using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBlock : MonoBehaviour {


	public Vector2 speedMinMax ;

	void Update () {
		float speed = Mathf.Lerp (speedMinMax.x, speedMinMax.y, Difficulty.GetDifficultyPercent ());
		transform.Translate (Vector2.down * speed * Time.deltaTime);
		if (transform.position.y < -Camera.main.orthographicSize-transform.localScale.y) {
			Destroy (gameObject);
		}
	}
}
