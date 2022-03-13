using UnityEngine;

namespace TDZS.Game.Enemy
{
  public class EnemyAttack : MonoBehaviour
  {
    [SerializeField] private EnemyAnimation _enemyAnimation;
    [SerializeField] private float _attackDelay = 1f;

    private float _currentDelay;

    private void Update()
    {
      DecrementTimer(Time.deltaTime);
      
      if (CanShoot())
        Attack();
    }

    private void DecrementTimer(float deltaTime)=>
      _currentDelay -= deltaTime;
    
    private bool CanShoot() =>
      _currentDelay <= 0f;

    private void Attack()
    {
      _enemyAnimation.PlayAttack();
      SetDelay();
    }
    
    private void SetDelay() =>
      _currentDelay = _attackDelay;
  }
}