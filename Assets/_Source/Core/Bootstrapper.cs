using System;
using PlayerSystem.Movement;
using InputSystem;
using PlayerSystem.Data;
using PlayerSystem.Movement;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private InputListener inputListener;
        [SerializeField] private Player player;
        private Movement _movement;
        private void Awake()
        {
            _movement = new Movement();
            
            inputListener.Construct(_movement, player);
            
        }
    }
}
