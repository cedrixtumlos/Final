using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class forScoring : MonoBehaviour {
	public static int score;
	Text scoreHolder;

	void Awake(){
		scoreHolder = GetComponent<Text> ();
		score = 0;
	}
		
	// Update is called once per frame
	void Update () {
		scoreHolder.text = "SCORE: " + score;
	}
}
