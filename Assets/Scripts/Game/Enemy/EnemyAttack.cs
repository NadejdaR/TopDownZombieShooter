using System.Collections;
using UnityEngine;

namespace TDZS.Game.Enemy
{
  public class EnemyAttack : MonoBehaviour
  {
    [SerializeField] private EnemyAnimation _enemyAnimation;
    [SerializeField] private float _delay = 2f;

    private IEnumerator _attackPlayerEnumerator;

    private void Start()
    {
      GameInvoke();
    }

    public void CancelGameInvoke()
    {
      if (_attackPlayerEnumerator != null)
        StopCoroutine(_attackPlayerEnumerator);
    }

    private void GameInvoke()
    {
      _attackPlayerEnumerator = AttackPlayerCoroutine();
      StartCoroutine(_attackPlayerEnumerator);
    }

    private IEnumerator AttackPlayerCoroutine()
    {
      yield return new WaitForSeconds(_delay);

      while (true)
      {
        Attack();
        yield return new WaitForSeconds(_delay);
      }
    }

    private void Attack() =>
      _enemyAnimation.PlayAttack();
  }
}