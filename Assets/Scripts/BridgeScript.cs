using UnityEngine;
using System.Collections;

public class BridgeScript : MonoBehaviour {
	
	void Start () {
	
	}

	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			Debug.Log(Input.mousePosition);
			transform.Rotate(new Vector3(0f, 0f, Mathf.Atan (Input.mousePosition.y/Input.mousePosition.x)));
		}
	}
}
