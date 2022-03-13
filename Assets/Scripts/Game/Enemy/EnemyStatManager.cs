using System;
using UnityEngine;

namespace TDZS.Game.Enemy
{
    public class EnemyStatManager : MonoBehaviour
    {
        [Header("Lives")] 
        [SerializeField] private int _startLives = 1;
        
        private static EnemyStatManager _instance;
        public static EnemyStatManager Instance => _instance;

        public event Action OnEnemyDead;
        public int CurrentLives { get; private set; }

        
        private void Awake()
        {
            if (_instance != null)
            {
                Destroy(gameObject);
                return;
            }

            _instance = this;
            DontDestroyOnLoad(gameObject);
            
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
