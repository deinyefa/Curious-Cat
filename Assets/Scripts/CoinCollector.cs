﻿/*
 * Collects collectables and handles score?
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CoinCollector : MonoBehaviour {


	[HideInInspector] public int score;
	[HideInInspector] public bool hasTakenChest = false;

	public Text scoreText;
	public Image chestimage;
	public GameObject panel;

	void Start () {
		chestimage.gameObject.SetActive (false);
	}

	void Update () {
		scoreText.text = score.ToString ();
	}
	
	void OnTriggerEnter2D (Collider2D other) 
	{
		if (other.CompareTag ("Coin")) 
		{
			score += 10;
			Destroy (other.gameObject);
		} 
		else if (other.CompareTag ("Chest")) 
		{
			hasTakenChest = true;
			score += 25;
			other.gameObject.SetActive (false);
			chestimage.gameObject.SetActive (true);
		}

		if (other.CompareTag ("Door") && hasTakenChest) {
			if (SceneManager.GetActiveScene ().name == "Level3") {
				Time.timeScale = 0;
				panel.SetActive (true);
			}
			else {
				LoadOnClick loadOnClick = GameObject.FindObjectOfType<LoadOnClick> ();
				loadOnClick.ButtonNextLevel ();
			}
		}
	}
}
