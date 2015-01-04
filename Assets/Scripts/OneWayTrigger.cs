using UnityEngine;
using System.Collections;

public class OneWayTrigger : MonoBehaviour {

	public BoxCollider2D elevator;
	
	void OnTriggerStay2D(Collider2D other) {
		elevator.enabled=false;
	}
	
	void OnTriggerExit2D(Collider2D other) {
		elevator.enabled=true;
		elevator.gameObject.SendMessage("removePlayerReference");
	}
}
