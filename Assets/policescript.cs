using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class policescript : MonoBehaviour {

	// Use this for initialization
	public Transform[] waypoints;
	int cur = 0;
	int forscore=0;
	int player;


	public float speed = 0.3f;

	void Start(){
		//police.GetComponent<WaypointProgressTracker> ().active = false;	

	}
	void FixedUpdate () {
		

		// Waypoint not reached yet? then move closer
		if (transform.position != waypoints [cur].position) {
			Vector2 p = Vector2.MoveTowards (transform.position,
				            waypoints [cur].position,
				            speed);
			GetComponent<Rigidbody2D> ().MovePosition (p);
		}
		// Waypoint reached, select next one
		else {
			cur = (cur + 1) % waypoints.Length;
		}
		// Animation
		Vector2 dir = waypoints[cur].position - transform.position;
		GetComponent<Animator>().SetFloat("DirX", dir.x);
		GetComponent<Animator>().SetFloat("DirY", dir.y);
	}
	void OnTriggerEnter2D(Collider2D co) {
		if (co.name == "getawaycar") {
			Destroy (co.gameObject);
			forscore = forScoring.score;
			PlayerPrefs.SetInt ("PlayerScore",forscore);
			Application.LoadLevel ("gameOver");
		}
	}
}
