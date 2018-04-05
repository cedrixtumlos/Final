using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toHome : MonoBehaviour {

	// Use this for initialization
	public void ChangeScene(string sceneName){
		Application.LoadLevel (sceneName);
		
	}
}
