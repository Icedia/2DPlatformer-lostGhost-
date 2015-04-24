using UnityEngine;
using System.Collections;

public class killplayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.tag == "Enemy")
		{
			Application.LoadLevel("Main");
		}
	}
}
