using UnityEngine;
using System.Collections;

public class Trampoline : MonoBehaviour {

	public float velocityX;
	public float velocityY;

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Player") {
			coll.gameObject.rigidbody2D.velocity+=new Vector2(velocityX,velocityY);
		}
	}

}
