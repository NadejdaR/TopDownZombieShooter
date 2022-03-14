using System;
using TDZS.Utility.Constants;
using UnityEngine;

namespace TDZS.Game.Enemy
{
    public class EnemyStat : MonoBehaviour
    {
        [Header("Lives")] 
        [SerializeField] private int _startLives = 1;
        
        [Header("")]
        [SerializeField] private EnemyAnimation _enemyAnimation;
        [SerializeField] private EnemyMovement _enemyMovement;
        [SerializeField] private EnemyAttack _enemyAttack;
        [SerializeField] private CircleCollider2D _circleCollider2D;
        
        public int CurrentLives { get; private set; }
        
        private void Awake()
        {
            CurrentLives = _startLives;
        }

        public void RemoveLive()
        {
            CurrentLives--;

            if (CurrentLives <= 0)
                Death();
        }

        private void Death()
        {
            _enemyAnimation.PlayDead();
            _enemyAttack.CancelGameInvoke();
            _enemyMovement.enabled = false;
            _enemyAttack.enabled = false;
            _circleCollider2D.enabled = false;
        }
    }
}
