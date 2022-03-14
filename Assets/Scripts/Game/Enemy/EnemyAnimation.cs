using UnityEngine;

namespace TDZS.Game.Enemy
{
  public class EnemyAnimation : MonoBehaviour
  {
    [SerializeField] private Animator _animator;
    [SerializeField] private string _attackName;
    [SerializeField] private string _deadName;
    [SerializeField] private EnemyStat _enemyStat;

    private void Start() =>
      _enemyStat.OnEnemyDead += PlayDead;

    private void OnDestroy() =>
      _enemyStat.OnEnemyDead -= PlayDead;

    public void PlayAttack() =>
      _animator.SetTrigger(_attackName);

    private void PlayDead() =>
      _animator.SetBool(_deadName, true);
  }
}