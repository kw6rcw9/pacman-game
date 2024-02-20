using UnityEngine;

namespace PlayerSystem.Movement
{
    public class Movement
    {
        private Transform _transform;
        public void Move(float inputX, float inputY, Rigidbody2D rb, float speed)
        {
            //transform.Translate(new Vector3(inputX * speed * Time.deltaTime, inputY * speed * Time.deltaTime)); 
            rb.velocity = new Vector2(inputX * speed, inputY * speed );
        }
    }
}
