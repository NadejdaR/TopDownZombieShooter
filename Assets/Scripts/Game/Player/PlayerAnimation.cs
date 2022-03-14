using UnityEngine;

namespace TDZS.Game.Player
{
    public class PlayerAnimation : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _rb;
        [SerializeField] private Animator _animator;
        [SerializeField] private string _shootName;
        [SerializeField] private string _speedName;
        [SerializeField] private string _deadName;

        private void Update() =>
            PlayMove();

        public void PlayShoot() =>
            _animator.SetTrigger(_shootName);

        public void PlayMove() =>
            _animator.SetFloat(_speedName, _rb.velocity.magnitude);

        public void PlayDead() =>
            _animator.SetBool(_deadName, true);
    }
}
