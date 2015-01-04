using UnityEngine;
using System.Collections;

public class Portals : MonoBehaviour {

	public Transform otherPortal;
	bool deferTeleport;
	void OnTriggerStay2D(Collider2D other) {
		if (other.gameObject.tag == "Player"&&!deferTeleport) {
			other.rigidbody2D.position=otherPortal.position;
			deferTeleport=false;
			otherPortal.gameObject.SendMessage("defer");
		}
	}

	void OnTriggerExit2D(Collider2D other) {
		if (other.gameObject.tag == "Player") {
			deferTeleport=false;
		}
	}

	void defer(){
		deferTeleport = true;
	}
}
