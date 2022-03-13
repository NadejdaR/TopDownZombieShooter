using UnityEngine;

namespace TDZS.Game.Enemy
{
  public class EnemyAnimation : MonoBehaviour
  {
    [SerializeField] private Animator _animator;
    [SerializeField] private string _attackName;

    public void PlayAttack() =>
      _animator.SetTrigger(_attackName);
  }
}