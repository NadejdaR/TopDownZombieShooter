using UnityEngine;

namespace TDZS.Game.Enemy
{
    public class EnemyMovement : MonoBehaviour
    {
        [SerializeField] private Transform _playerTransform;

        private void Update()
        {
            TurnToThePlayer();
        }
        private void TurnToThePlayer()
        {
            transform.up = _playerTransform.position - transform.position;
        }
    }
}