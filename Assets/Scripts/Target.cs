using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour
{

		public GameObject game;

		void OnTriggerStay2D (Collider2D other)
		{
				Debug.Log ("Hit");
				game.SendMessage ("ScorePoint");
				Destroy (other.gameObject);
		}
}
