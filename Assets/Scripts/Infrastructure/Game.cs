using TDZS.Infrastructure.StateMachine;

namespace TDZS.Infrastructure
{
    public class Game
    {
        public IGameStateMachine StateMachine;
        public Game(IGameStateMachine gameStateMashine)
        {
            StateMachine = gameStateMashine;
        }
    }
}
