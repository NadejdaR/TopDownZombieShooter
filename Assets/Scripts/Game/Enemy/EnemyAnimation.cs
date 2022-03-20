using UnityEngine;

namespace TDZS.Game.Enemy
{
  public class EnemyAnimation : MonoBehaviour
  {
    [SerializeField] private Animator _animator;
    [SerializeField] private string _attackName;
    [SerializeField] private string _speedName;
    [SerializeField] private string _deathName;

    public void PlayAttack() =>
      _animator.SetTrigger(_attackName);
    
    public void PlayMove(float speed) =>
      _animator.SetFloat(_speedName, speed);

    public void PlayDeath() =>
      _animator.SetTrigger(_deathName);
  }
}