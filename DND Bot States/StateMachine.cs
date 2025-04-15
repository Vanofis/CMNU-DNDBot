using System;
using DND_Bot_States.States;

namespace DND_Bot_States;

public static class StateMachine
{
    private static BaseState CurrentState;

    public static void SetState(BaseState newState)
    {
        Console.WriteLine($"Switching from {CurrentState.GetType().FullName} state to {CurrentState.GetType().FullName} state");
        
        CurrentState.Dispose();
        CurrentState = newState;
        CurrentState.Initialize();
    }

    public static void UpdateState()
    {
        CurrentState.Update();
    }
}