namespace TDZS.Infrastructure.StateMachine.State
{
  public interface IState
  {
    void Enter();
    void Exit();
  }
}