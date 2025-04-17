using System;
using DND_Bot_States.States;

namespace DND_Bot_States;

public static class StateMachine
{
    public static MessageState CurrentState;

    public static void SetState(MessageState newState)
    {
        CurrentState = newState;
        CurrentState.Initialize();
    }
}