using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {

	public string sceneName;
	
	public void ChangeLevel()
	{
		Application.LoadLevel (sceneName);
	}
}

