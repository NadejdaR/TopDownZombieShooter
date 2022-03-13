using System;
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

        private void Start() =>
            PlayerStateManager.Instance.OnPlayerDead += PlayDead;

        private void Update() =>
            PlayMove();
        
        private void OnDestroy() =>
            PlayerStateManager.Instance.OnPlayerDead -= PlayDead;

        public void PlayShoot() =>
            _animator.SetTrigger(_shootName);

        private void PlayMove() =>
            _animator.SetFloat(_speedName, _rb.velocity.magnitude);

        private void PlayDead() =>
            _animator.SetBool(_deadName, true);
    }
}
