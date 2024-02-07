using UnityEngine;

namespace _Source.PlayerSystem.Movement
{
    public class Movement
    {
        private Transform _transform;
        public void Move(float inputX, float inputY, Transform transform, float speed)
        {
         transform.Translate(new Vector3(inputX * speed, inputY * speed ));   
        }
    }
}
