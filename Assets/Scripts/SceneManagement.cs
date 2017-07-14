/*
 * Start Screen w How to play & levels  - 0
 * How to play 							- 1
 * Choose Levels						- 2
 * Levels 1-10 (1 - 2 for now)			- 3-4
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour {

	public static SceneManagement instance = null;

	void Awake () {
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);
		DontDestroyOnLoad (gameObject);
	}
	
	public void LoadNextScene () {
		//- From start scenes to level 2
		if (SceneManager.GetActiveScene ().buildIndex <= 3) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
		}

		//- when player reaches last level, go back to start screen 
		if (SceneManager.GetActiveScene ().buildIndex >= 4)
			SceneManager.LoadScene ("Start");
	}

	public void Play () {
		SceneManager.LoadScene ("Select Level");
	}
}
