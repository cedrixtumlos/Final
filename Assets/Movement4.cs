using UnityEngine;
using System.Collections;

public class Movement4	 : MonoBehaviour {
	public float speed = 0.4f;
	Vector2 dest = Vector2.zero;
	public AudioSource sounds;
	int myscore;
	int myscore1;
	void Start() {

		sounds = GetComponent<AudioSource> ();
		dest = transform.position;
		myscore1=PlayerPrefs.GetInt ("PlayerScore",0);
		forScoring.score = myscore1;
	}
	void OnTriggerEnter2D(Collider2D co) {
		if (co.tag == "coin") {
			sounds.Play ();
			co.gameObject.SetActive (false);
			forScoring.score+= 1;
			if (forScoring.score>=718){
				myscore = forScoring.score;
				PlayerPrefs.SetInt ("PlayerScore",myscore);
				Application.LoadLevel ("5");

			}

		}

	}

	void FixedUpdate() {
		// Move closer to Destination
		Vector2 p = Vector2.MoveTowards(transform.position, dest, speed);
		GetComponent<Rigidbody2D>().MovePosition(p);

		// Check for Input if not moving
		if ((Vector2)transform.position == dest) {
			if (Input.GetKey(KeyCode.UpArrow) && valid(Vector2.up))
				dest = (Vector2)transform.position + Vector2.up;
			if (Input.GetKey(KeyCode.RightArrow) && valid(Vector2.right))
				dest = (Vector2)transform.position + Vector2.right;
			if (Input.GetKey(KeyCode.DownArrow) && valid(-Vector2.up))
				dest = (Vector2)transform.position - Vector2.up;
			if (Input.GetKey(KeyCode.LeftArrow) && valid(-Vector2.right))
				dest = (Vector2)transform.position - Vector2.right;
		}

		// Animation Parameters
		Vector2 dir = dest - (Vector2)transform.position;
		GetComponent<Animator>().SetFloat("DirX", dir.x);
		GetComponent<Animator>().SetFloat("DirY", dir.y);
		print (dir.x);


	}

	bool valid(Vector2 dir) {
		// Cast Line from 'next to Pac-Man' to 'Pac-Man'
		Vector2 pos = transform.position;
		RaycastHit2D hit = Physics2D.Linecast(pos + dir, pos);
		return (hit.collider == GetComponent<Collider2D>());
	}

}
