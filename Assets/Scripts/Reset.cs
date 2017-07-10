/*
 * When player hits an obstacle, it 'resets'
 * Goes back to original position
 * Health is decreased by 1
 * 
 * When it's reset 3 times, its game over!
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour {

	private GameObject obstacle;
	private Vector3 initialPosition;
	private int count = 0;

	void Start () {
		initialPosition = transform.position;
	}

	void OnTriggerEnter2D (Collider2D other) 
	{
		if (other.gameObject.tag == "Obstacle") 
		{
			transform.position = initialPosition;
			count++;

			if (count >= 3)
				print ("Game Over!");
		}
	}
}
