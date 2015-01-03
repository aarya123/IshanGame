using UnityEngine;
using System.Collections;

public class Sonic : MonoBehaviour {
	public int directionx;
	int directiony;

	public int speed;
	Animator animator;

	void Start () {
		animator = GetComponent<Animator> ();
	}

	void Update () {
		if (directionx > 0) {
			rigidbody2D.velocity= new Vector2(1f*speed,rigidbody2D.velocity.y);
		} else if (directionx < 0) {
			rigidbody2D.velocity= new Vector2(-1f*speed,rigidbody2D.velocity.y);
		} else {
			rigidbody2D.velocity= new Vector2(0f,rigidbody2D.velocity.y);
		}
		animator.SetFloat ("SpeedX",Mathf.Abs(rigidbody2D.velocity.x));
		if (rigidbody2D.velocity.y > 0) {
			directiony = 1;
		} else if (rigidbody2D.velocity.y < 0) {
			directiony = -1;
		} else {
			directiony = 0;
				}
		animator.SetFloat ("DirectionY", directiony);
	}
}
