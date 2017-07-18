/*
 * Collects collectables and handles score?
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollector : MonoBehaviour {


	[HideInInspector] public int score;
	[HideInInspector] public bool hasTakenChest = false;

	public Text scoreText;
	public Image chestimage;

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
			LoadOnClick loadOnClick = GameObject.FindObjectOfType<LoadOnClick> ();
			loadOnClick.ButtonNextLevel ();
		}
	}
}
