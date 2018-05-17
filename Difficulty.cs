using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difficulty {
	static float secsToMaxDifficulty=60 ; 

	public static float GetDifficultyPercent(){
		float difficultyPercent = Mathf.Clamp01 (Time.timeSinceLevelLoad / secsToMaxDifficulty);

		return difficultyPercent;
	}
}
