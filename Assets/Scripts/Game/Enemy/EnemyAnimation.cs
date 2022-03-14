using UnityEngine;

namespace TDZS.Game.Enemy
{
  public class EnemyAnimation : MonoBehaviour
  {
    [SerializeField] private Animator _animator;
    [SerializeField] private string _attackName;
    [SerializeField] private string _deadName;

    public void PlayAttack() =>
      _animator.SetTrigger(_attackName);

    public void PlayDead() =>
      _animator.SetTrigger(_deadName);
  }
}