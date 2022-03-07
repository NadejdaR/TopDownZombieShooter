using System;
using TDZS.Infrastructure.StateMachine;
using TDZS.Infrastructure.StateMachine.State;
using UnityEngine;

namespace TDZS.Infrastructure
{
    public class GameBootstrapper : MonoBehaviour
    {
        private Game _game;
        private void Awake()
        {
            _game = new Game(new GameStateMachine());
            _game.StateMachine.Enter<BootstrapState>();
            
            DontDestroyOnLoad(this);
        }
    }
}
