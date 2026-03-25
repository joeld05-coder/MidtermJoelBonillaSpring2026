using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    //These are the player's Variables, the raw info that defines them

    public Rigidbody2D rb; //The Rigidbody2D is a component that gives the player physics, and is what we use to move
    public float speed = 6; //This will control how fast the object moves
    public float bottomBoundary = -2f; // lowest Y position, basically where to stop and go up
    public float topBoundary = 2f; // highest Y position, basically where to stop and go down
    public int direction = 1; // with will make the object go 1 by 1, or -1 if it goes down

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  //First we make a variable that we'll use to record how we want to move
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = new Vector2(0, speed * direction); // X = 0 makes x stay the same while Y moves up and down at a constant speed

        if (transform.position.y >= topBoundary) //check if the object reached or passed the top boundary
        { 
            direction = -1; //this will make it go down when reaching the top
        }
        else if (transform.position.y <= bottomBoundary) //check if the object reached or passed the bottom boundary
        {
            direction = 1;  // this will make it go up when reaching the bottom
        }
    }
}