using System;
using PlayerSystem.Movement;
using PlayerSystem.Data;
using PlayerSystem.Movement;
using UnityEngine;

namespace InputSystem
{
    public class InputListener : MonoBehaviour
    {
        private Movement _movement;
        private Player _player;
        private Collider2D _playerCollider;
        //[SerializeField] private Transform[] rotatePoints;
        private Transform _nearestPoint;
        private bool _isInXDir;
        private bool _isInYDir;
        public void Construct(Movement movement, Player player)
        {
            _movement = movement;
            _player = player;
            _player.TryGetComponent(out Collider2D collider);
            _playerCollider = collider;
        }

        // Update is called once per frame
        void Update()
        {
            ReadMove();
        }

        

        void ReadMove()
        {
            RaycastHit2D[] hit;
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");
            if((x != 0 && _player.NearestPoint.position == _player.transform.position) 
               || _player.NearestPoint == null)
            {
                /*Collider2D[] hitt = Physics2D.OverlapCircleAll(_player.transform.position, 3);
                for (int i = 0; i < hitt.Length; i++)
                {
                    if (hitt[i].gameObject.layer == 3)
                    {
                        Debug.Log("Found");
                        _nearestPoint = hitt[i].transform;
                    }
                }*/
                //Debug.Log(x);
                y = 0;
                hit = Physics2D.RaycastAll(_player.transform.position, Vector2.right * x);
             if (hit[1].collider != null)
             {
                 //Debug.Log(hit[1].collider.gameObject);
                 //var objPos = hit.transform.InverseTransformPoint();
                 float distance = Mathf.Abs(hit[1].point.x - _player.transform.position.x);
                 //Debug.Log(distance);
                 if (distance > 0.6f)
                 {
                    _movement.Move(x,0, _player.Rb, _player.Speed);
                     
                 }
             }
            }
            else if (y != 0)
            {
                 x = 0;
                    hit = Physics2D.RaycastAll(_player.transform.position, Vector2.up * y);
                    if (hit[1].collider != null)
                    {
                        float distance = Mathf.Abs(hit[1].point.y - _player.transform.position.y);
                        if (distance > 0.6f)
                        {
                            _movement.Move(0,y, _player.Rb, _player.Speed);
                     
                        }
                    }
                
            }
             
        }
    
    }
}
