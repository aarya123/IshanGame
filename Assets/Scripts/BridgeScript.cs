using UnityEngine;
using System.Collections;

public class BridgeScript : MonoBehaviour {
	

	void Start () {
	
	}

	void Update () {

		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit2D hit = Physics2D.Raycast (ray.origin, ray.direction, Mathf.Infinity);
		if (hit) {
			Debug.Log("You hit: " + hit.collider.gameObject);
				}
		Vector2 relative = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

		if (Input.GetMouseButtonDown(0)) {
			transform.Rotate(new Vector3(0f, 0f, Mathf.Atan (relative.y/relative.x)));
		}
	}
}
