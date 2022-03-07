namespace TDZS.Infrastructure.StateMachine.State
{
    public class BootstrapState : IState
    {
        private readonly IGameStateMachine _stateMachine;

        public BootstrapState(IGameStateMachine stateMachine)
        {
            _stateMachine = stateMachine;
        }
        
        public void Enter()
        {
            EnterMenuState();
        }

        public void Exit()
        {
            
        }

        private void EnterMenuState()
        {
            _stateMachine.Enter<MenuState>();
        }
    }
}
