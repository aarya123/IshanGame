using UnityEngine;
using System.Collections;

public class Elevator : MonoBehaviour
{
	
    public int deltaX;
    public int deltaY;
    public int speed;
    [SerializeField]
    Vector3
        startVect;
    [SerializeField]
    Vector3
        endVect;
    [SerializeField]
    Vector3
        destination;
    [SerializeField]
    bool
        hasPlayer;
    Rigidbody2D player;
    bool elevatorActive;

    void Start()
    {
        startVect = transform.position;
        endVect = new Vector3(startVect.x + deltaX, startVect.y + deltaY, startVect.z);
    }
	
    void Update()
    {
        float step = speed * Time.deltaTime;
        if (elevatorActive && hasPlayer)
        {
            transform.position = Vector3.MoveTowards(transform.position, endVect, step);
            if (transform.position != endVect)
            {
                player.velocity = new Vector2(0f, player.velocity.y);
            }
        } else
        {
            transform.position = Vector3.MoveTowards(transform.position, startVect, step);
        }
    }
	
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player" && Vector2.Dot(coll.contacts [0].normal, Vector2.right) == 0)
        {
            //coll.transform.parent=transform;
            player = coll.gameObject.rigidbody2D;
            hasPlayer = true;
        }
    }
	
    void OnCollisionExit2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            //coll.transform.parent=null;
            player = null;
            hasPlayer = false;
        }
    }

    void removePlayerReference()
    {
        hasPlayer = false;
        player = null;
    }

    public void triggerElevator()
    {
        elevatorActive = !elevatorActive;
    }
}
