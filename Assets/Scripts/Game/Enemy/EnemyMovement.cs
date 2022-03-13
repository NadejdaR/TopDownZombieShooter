using UnityEngine;

namespace TDZS.Game.Enemy
{
  public class EnemyMovement : MonoBehaviour
  {
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private float _speed;

    private void Update()
    {
      TurnToThePlayer();
      MoveToRhePlayer();
    }

    private void TurnToThePlayer() =>
      transform.up = _playerTransform.position - transform.position;

    private void MoveToRhePlayer() =>
      transform.position = Vector2.MoveTowards(transform.position, _playerTransform.position, _speed * Time.deltaTime);
  }
}