using UnityEngine;

namespace TDZS.Game.Enemy
{
  public class EnemyAnimation : MonoBehaviour
  {
    [SerializeField] private Animator _animator;
    [SerializeField] private string _attackName;
    [SerializeField] private string _deadName;

    private void Start() =>
      EnemyStatManager.Instance.OnEnemyDead += PlayDead;
    
    private void OnDestroy() =>
      EnemyStatManager.Instance.OnEnemyDead -= PlayDead;
    
    public void PlayAttack() =>
      _animator.SetTrigger(_attackName);
    
    private void PlayDead() =>
      _animator.SetBool(_deadName, true);
    
    
  }
}