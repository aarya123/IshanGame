using UnityEngine;
using System.Collections;

public class Trampoline : MonoBehaviour {

	public float velocityX;
	public float velocityY;
	public Input button; 

	void OnTriggerStay2D(Collider2D other) {
		if (other.gameObject.tag == "Player") {
			if(button){
				other.rigidbody2D.AddForce(new Vector2(velocityX,velocityY));
				//other.rigidbody2D.velocity+=new Vector2(velocityX,velocityY);
			}

		}
	}
}
