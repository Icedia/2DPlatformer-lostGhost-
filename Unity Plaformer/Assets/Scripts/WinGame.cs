﻿using UnityEngine;
using System.Collections;

public class WinGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.tag == "Grave")
		{
			Application.LoadLevel("End");
		}
	}
}
