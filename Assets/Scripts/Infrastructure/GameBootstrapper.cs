using TDZS.Infrastructure.SceneLoading;
using TDZS.Infrastructure.StateMachine;
using TDZS.Infrastructure.StateMachine.State;
using TDZS.UI;
using TDZS.Utility;
using UnityEngine;

namespace TDZS.Infrastructure
{
    public class GameBootstrapper : MonoBehaviour, ICoroutineRunner
    {
        private Game _game;

        private void Awake()
        {
            _game = new Game(new GameStateMachine(new AsyncSceneLoader(this)));
            _game.StateMachine.Enter<BootstrapState>();
        
            DontDestroyOnLoad(this);
        }
    }
}
