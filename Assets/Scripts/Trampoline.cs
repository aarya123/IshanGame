using UnityEngine;
using System.Collections;

public class Trampoline : MonoBehaviour
{

    public float velocityX;
    public float velocityY;
    bool trampolineActive;
	public Animator animator;

    void OnTriggerStay2D(Collider2D other)
    {
        if (trampolineActive && other.gameObject.tag == "Player")
        {
            other.rigidbody2D.AddForce(new Vector2(velocityX, velocityY));
            //other.rigidbody2D.velocity+=new Vector2(velocityX,velocityY);
        }
    }

    public void triggerTrampoline()
    {
        trampolineActive = !trampolineActive;
    }

	void Start () {
		//animator = GetComponent<Animator> ();
	}
	
	void Update(){
		animator.SetBool ("State", trampolineActive);
	}
}
