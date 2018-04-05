using UnityEngine;
using System.Collections;

public class coin : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D co) {
		if (co.name == "getawaycar") {
			forScoring.score += 1;

		}
		
		
	}
}