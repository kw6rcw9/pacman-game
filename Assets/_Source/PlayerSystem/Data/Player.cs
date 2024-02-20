using System;
using UnityEngine;

namespace PlayerSystem.Data
{
   [RequireComponent(typeof(Rigidbody2D))]
   public class Player : MonoBehaviour
   {
      [field: SerializeField] public float Speed { get; private set; }
      [field: SerializeField] public Rigidbody2D Rb { get; private set; }
      [field: SerializeField] public Transform NearestPoint { get; private set; } = null;

      private void OnTriggerEnter2D(Collider2D col)
      {
         if (col.gameObject.layer == 3)
         {
            Debug.Log("in trigger");
         }
      }
   }
}
