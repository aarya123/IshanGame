using UnityEngine;
using System.Collections;

public class BridgeScript : MonoBehaviour {
	

	void Start () {
	
	}

	void Update () {

		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit2D hit;
		if (Physics2D.Raycast (ray, hit, 1000)) {
			Debug.Log("You hit: " + hit.collider.gameObject);
				}
		Vector2 relative = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
		Debug.Log (relative);
		if (Input.GetMouseButtonDown(0)) {
			transform.Rotate(new Vector3(0f, 0f, Mathf.Atan (relative.y/relative.x)));
		}
	}
}
