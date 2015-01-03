using UnityEngine;
using System.Collections;

public class Sonic : MonoBehaviour {
	public int directionX;
	public int speed;
	bool start=true;
	Animator animator;

	void Start () {
		animator = GetComponent<Animator> ();
	}

	void Update () {

		//RaycastHit2D hitInfo=Physics2D.Raycast(rigidbody2D.position,new Vector2(Vector2.right*directionX,0f);
		if (rigidbody2D.velocity.x == 0) {
			if(start){
				start=false;
			} else{
				directionX = -directionX;
				transform.Rotate(new Vector3(0f,180f,0f));
			}
		}
		rigidbody2D.velocity = new Vector2 (directionX * speed, rigidbody2D.velocity.y);
		animator.SetFloat ("SpeedX",Mathf.Abs(rigidbody2D.velocity.x));
		animator.SetFloat ("VelocityY", rigidbody2D.velocity.y);
	}
}
