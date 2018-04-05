using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disable2 : MonoBehaviour {

	public GameObject police;
	public GameObject police2;	

	// Use this for initialization
	IEnumerator Start () {
		yield return new WaitForSeconds (.0001f);
		hello ();
	}

	// Update is called once per frame
	void hello () {

		police.GetComponent<WaypointProgressTracker>().enabled=false;
		police2.GetComponent<WaypointProgressTracker>().enabled=false;


	}
}
