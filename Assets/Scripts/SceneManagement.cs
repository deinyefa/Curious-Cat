/*
 * Start Screen w How to play & levels - 0
 * How to play 							- 1
 * Levels 1-10 (1 - 2 for now)			- 2-3
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
		if (SceneManager.GetActiveScene ().buildIndex <= 2) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
		}

		//- when player reaches last level, go back to start screen 
		if (SceneManager.GetActiveScene ().buildIndex >= 3)
			SceneManager.LoadScene ("Start");
	}
}
