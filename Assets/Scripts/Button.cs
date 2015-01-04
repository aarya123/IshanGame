using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	// Use this for initialization
	public Transform bridgeMove;
	bool notRotated = true;

	void OnTriggerStay2D(Collider2D other) {
		if (other.gameObject.tag == "Player") {
			if(notRotated){
				bridgeMove.Rotate(new Vector3(0f, 0f, 90f));
				notRotated = false;
				GetComponent<SpriteRenderer>().sprite=null;
			}
		}
	}
}
