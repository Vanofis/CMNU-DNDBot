using System;
using System.Collections.Generic;
using Telegram.Bot.Types.ReplyMarkups;

namespace DND_Bot_States.States;

[Serializable]
public class BaseState
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    
    #region Data
    
    [Serializable]
    public struct SubState
    {
        public string[][] Buttons;
        
        public string ImagePath;
        public string Message;
    }

    [Serializable]
    public struct StateLink
    {
        public bool TransitionIsAvailable;
        
        public string StateName;
        public string StateType;
        
        public void SwitchToState()
        {
            if (!TransitionIsAvailable)
            {
                return;
            }
            
            var stateType = Type.GetType(StateType);

            if (stateType == null)
            {
                throw new NullReferenceException($"State of type {StateType} not found");
            }
            
            //StateMachine.SetState(FileResourcesManager.GetState(StateName, stateType));
        }
    }
    
    public virtual SubState[] SubStates => default;
    
    public virtual StateLink[] StateLinks => default;
    
    public virtual int CurrentSubStateIndex { get; protected set; }
    public virtual int InitSubStateIndex => 0;
    public virtual bool CycleSubStates => false;

    #endregion
    
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    
    #region Life cycle
    
    public void Initialize()
    {
        CurrentSubStateIndex = InitSubStateIndex;

        InitializeInternal();
    }
    protected virtual void InitializeInternal() {}

    public virtual void Update()
    {
        UpdateInternal();
    }
    protected virtual void UpdateInternal() {}

    public virtual void Dispose()
    {
        DisposeInternal();
    }
    protected virtual void DisposeInternal() {}
    
    #endregion
    
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    
    #region SubState control
    
    public void ToNextSubState()
    {
        CurrentSubStateIndex++;

        ProcessNewSubStateIndex(CurrentSubStateIndex >= SubStates.Length, 0, SubStates.Length - 1);
    }

    public void ToPreviousSubState()
    {
        CurrentSubStateIndex--;

        ProcessNewSubStateIndex(CurrentSubStateIndex < 0, SubStates.Length - 1, 0);
    }

    private void ProcessNewSubStateIndex(bool outOfBoundCondition, int indexIfCycle, int clampIndex)
    {
        if (outOfBoundCondition)
        {
            CurrentSubStateIndex = CycleSubStates ? indexIfCycle : clampIndex;
        }
    }

    #endregion
    
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    
    #region State control

    public void SwitchToLinkedState(int linkIndex)
    {
        StateLinks[linkIndex].SwitchToState();
    }
    
    #endregion
    
    ////////////////////////////////////////////////////////////////////////////////////////////////////
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