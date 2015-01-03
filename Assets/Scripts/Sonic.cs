using UnityEngine;
using System.Collections;

public class Sonic : MonoBehaviour {
	public int direction;
	public int speed;
	Animator animator;

	void Start () {
		animator = GetComponent<Animator> ();
	}

	void Update () {
		if (direction > 0) {
			rigidbody2D.velocity= new Vector2(1f*speed,rigidbody2D.velocity.y);
		} else if (direction < 0) {
			rigidbody2D.velocity= new Vector2(-1f*speed,rigidbody2D.velocity.y);
		} else {
			rigidbody2D.velocity= new Vector2(0f,rigidbody2D.velocity.y);
		}
		animator.SetFloat ("SpeedX",Mathf.Abs(rigidbody2D.velocity.x));
	}
}
