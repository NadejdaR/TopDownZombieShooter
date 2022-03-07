namespace TDZS.Infrastructure.StateMachine.State
{
  public class MenuState : IState
  {
    private readonly IGameStateMachine _gameStateMachine;

    public MenuState(IGameStateMachine gameStateMachine)
    {
      _gameStateMachine = gameStateMachine;
    }

    public void Enter()
    {
      
    }

    public void Exit()
    {
      
    }
  }
}