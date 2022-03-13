using System;
using UnityEngine;

namespace TDZS.Game.Player
{
    public class PlayerStateManager : MonoBehaviour
    {
        [Header("Lives")] 
        [SerializeField] private int _maxLives;
        [SerializeField] private int _startLives;
        
        private static PlayerStateManager _instance;
        public static PlayerStateManager Instance => _instance;
        public int MaxLives => _maxLives;
        public event Action OnLivesChanged;
        public event Action OnPlayerDead;
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
        
        public void Reload()
        {
            CurrentLives = _startLives;
        }

        public void RemoveLive()
        {
            CurrentLives--;

            if (CurrentLives <= 0)
                OnPlayerDead?.Invoke();

            OnLivesChanged?.Invoke();
        }

        public void AddLive(int liveToAdd)
        {
            CurrentLives++;

            if (CurrentLives >= _maxLives)
                CurrentLives = _maxLives;

            OnLivesChanged?.Invoke();
        }
    }
}
