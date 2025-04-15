using System;
using System.Collections.Generic;
using Telegram.Bot.Types.ReplyMarkups;

namespace DND_Bot.StateMachine.States;

[Serializable]
public abstract class BaseState
{
    public struct Substate
    {
        public List<string[]> Buttons => default;
        public string ImagePath => string.Empty;
    }

    public virtual List<Substate> Substates => default;
    
    public virtual int CurrentSubstateIndex { get; protected set; }
    public virtual int InitSubStateIndex => 0;
    public virtual bool CycleSubStates => false;

    public void ToNextSubState()
    {
        CurrentSubstateIndex++;

        ProcessNewSubStateIndex(CurrentSubstateIndex >= Substates.Count, 0, Substates.Count - 1);
    }

    public void ToPreviousSubState()
    {
        CurrentSubstateIndex--;

        ProcessNewSubStateIndex(CurrentSubstateIndex < 0, Substates.Count - 1, 0);
    }

    private void ProcessNewSubStateIndex(bool outOfBoundCondition, int indexIfCycle, int clampIndex)
    {
        if (outOfBoundCondition)
        {
            CurrentSubstateIndex = CycleSubStates ? indexIfCycle : clampIndex;
        }
    }

    public void Initialize()
    {
        CurrentSubstateIndex = InitSubStateIndex;
    }
    
    public virtual void InitializeInternal() {}
}

public static class BaseStateExtensions
{
    public static ReplyKeyboardMarkup GetMarkup(this List<string[]> buttonNames)
    {
        var keyboardButtons = new List<KeyboardButton[]>();
        foreach(var array in buttonNames)
        {
            var buttonArray = new KeyboardButton[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                buttonArray[i] = array[i];
            }
            
            keyboardButtons.Add(buttonArray);
        }
        
        return new ReplyKeyboardMarkup(keyboardButtons)
        {
            ResizeKeyboard = true,
        };
    }
}