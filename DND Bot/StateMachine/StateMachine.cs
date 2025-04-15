using DND_Bot.StateMachine.States;

namespace DND_Bot.StateMachine;

public static class StateMachine
{
    private static BaseState CurrentState;

    public static void SetState(BaseState newState)
    {
        CurrentState = newState;
        CurrentState.Initialize();
    }
}