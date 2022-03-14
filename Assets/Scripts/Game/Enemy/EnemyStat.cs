using System;
using UnityEngine;

namespace TDZS.Game.Enemy
{
    public class EnemyStat : MonoBehaviour
    {
        [Header("Lives")] 
        [SerializeField] private int _startLives = 1;
        
        public event Action OnEnemyDead;
        public int CurrentLives { get; private set; }
        
        private void Awake()
        {
            CurrentLives = _startLives;
        }

        public void RemoveLive()
        {
            CurrentLives--;

            if (CurrentLives <= 0)
                OnEnemyDead?.Invoke();
        }
    }
}
