using Mono.Cecil.Cil;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class PlayerMovement : MonoBehaviour
{
    //These are the player's Variables, the raw info that defines them

    public Rigidbody2D RB;  //The Rigidbody2D is a component that gives the player physics, and is what we use to move

    public float Speed = 5;//This will control how fast the player moves

    public int jumpSpeed = -6;
    public Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // The code below controls the character's movement
        Vector2 vel = RB.linearVelocity;  //First we make a variable that we'll use to record how we want to move, Linear velocity preserves verticl velocity
        vel.x = 0;

        //Then we use if statement to figure out what that variable should look like

        if (Input.GetKey(KeyCode.RightArrow))  //If I hold the right arrow key, the player should move right. . .
        {
            vel.x = Speed;
        }
        
        if (Input.GetKey(KeyCode.LeftArrow)) //If I hold the left arrow, the player should move left. . .
        {
            vel.x = -Speed;
        }
        //Jump

        if (Input.GetKey(KeyCode.Space))
        {
            vel.y = jumpSpeed; //set vertical velocity
        }
            //Finally, I take that variable and I feed it to the component in charge of movement
            RB.linearVelocity = vel;
    }
}
