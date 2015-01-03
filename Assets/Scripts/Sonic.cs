using UnityEngine;
using System.Collections;

public class Sonic : MonoBehaviour {
	public int direction;
	public int speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (direction > 0) {
			rigidbody2D.velocity= new Vector2(1f*speed,rigidbody2D.velocity.y);
		} else if (direction < 0) {
			rigidbody2D.velocity= new Vector2(-1f*speed,rigidbody2D.velocity.y);
		} else {
			rigidbody2D.velocity= new Vector2(0f,rigidbody2D.velocity.y);
		}
	}
}
