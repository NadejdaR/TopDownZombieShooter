using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TDZS
{
    public class EnemyMovement : MonoBehaviour
    {
        [SerializeField] private Transform _playerTransform;
        
        private Camera _camera;

        private void Start()
        {
            _camera = Camera.main;
        }

        private void Update()
        {
            TurnToThePlayer();
        }
        private void TurnToThePlayer()
        {
            transform.up = _playerTransform.position - transform.position;
                
            // Vector3 directionToFace = _playerTransform.position - transform.position;
            //
            // Quaternion targetRotation = Quaternion.LookRotation(directionToFace);
            // transform.rotation = Quaternion.Slerp(transform.rotation,targetRotation,Time.deltaTime);
        }
    }
}