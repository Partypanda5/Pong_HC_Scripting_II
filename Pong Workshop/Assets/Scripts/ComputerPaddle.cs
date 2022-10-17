using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball;

    private void FixedUpdate()
    {
        if (ball.velocity.x > 0f) //check if the ball is going towards the paddle
        {
            if (ball.position.y > rigidbody.position.y) //if the ball's y position is bigger than the paddle's y position
            {
                rigidbody.AddForce(Vector2.up * speed); //move the paddle up
            }
            else if (ball.position.y < rigidbody.position.y) // if the ball's y position is less than the paddle's y positon
            {
                rigidbody.AddForce(Vector2.down * speed); //move the paddle down
            }
        }
        else 
        {
            if (rigidbody.position.y > 0f) //check paddle's y position if it is bigger than 0
            {
                rigidbody.AddForce(Vector2.down * speed); //move paddle down
            }
            else if (rigidbody.position.y < 0f)  //check paddle's y position if it is less than 0
            {
                rigidbody.AddForce(Vector2.up * speed); // move paddle down
            }
        }
    }
}
