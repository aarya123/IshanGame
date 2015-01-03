using UnityEngine;
using System.Collections;

public class Sonic : MonoBehaviour {
	public int directionX;
	public int speed;
	public Transform edge;
	public LayerMask wallLayer;
	public bool DEBUG;
	Animator animator;

	void Start () {
		animator = GetComponent<Animator> ();
	}

	void Update () {
		if (DEBUG) {
			float velocityX,velocityY;
			if (Input.GetKey (KeyCode.LeftArrow)) {
				velocityX = -1;
			} else if (Input.GetKey (KeyCode.RightArrow)) {
				velocityX = 1;
			} else {
				velocityX = 0;
			}
			if(Input.GetKey(KeyCode.UpArrow)){
				velocityY=1;
			}else if(Input.GetKey(KeyCode.DownArrow)){
				velocityY=-1;
			}else{
				velocityY=0;
			}
			rigidbody2D.velocity = new Vector2 (velocityX * speed, velocityY*speed);
		} else {
			RaycastHit2D hitInfo = Physics2D.Linecast (rigidbody2D.position, edge.position, wallLayer);
			if (hitInfo.collider != null) {
				directionX = -directionX;
				transform.Rotate (new Vector3 (0f, 180f, 0f));
			}
			rigidbody2D.velocity = new Vector2 (directionX * speed, rigidbody2D.velocity.y);
		}
		animator.SetFloat ("SpeedX",Mathf.Abs(rigidbody2D.velocity.x));
		animator.SetFloat ("VelocityY", rigidbody2D.velocity.y);
	}
}
