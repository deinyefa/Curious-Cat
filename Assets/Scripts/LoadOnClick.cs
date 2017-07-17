using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOnClick : MonoBehaviour {

	public void LoadSelectedLevel (int level) {
		SceneManager.LoadScene (level);
	}

	public void SelectLevelScene () {
		SceneManager.LoadScene ("Select Level");
	}
}
