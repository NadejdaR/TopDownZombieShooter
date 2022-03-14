using System;
using UnityEngine;

namespace TDZS.Game.Player
{
    public class PlayerState : MonoBehaviour
    {
        [Header("Lives")] 
        [SerializeField] private int _maxLives;
        [SerializeField] private int _startLives;

        public int MaxLives => _maxLives;
        public event Action OnLivesChanged;
        public event Action OnPlayerDead;
        public int CurrentLives { get; private set; }

        private void Awake()
        {
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
