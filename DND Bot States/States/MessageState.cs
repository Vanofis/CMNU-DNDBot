using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Telegram.Bot.Types.ReplyMarkups;

namespace DND_Bot_States.States;

public enum ActionType
{
    ToNextSubState,
    ToPreviousSubState,
    ToState,
    IncreaseKarma,
    DecreaseKarma,
    Finale,
}

[Serializable]
public class MessageState
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    
    #region Data
    
    [Serializable]
    public struct SubState
    {
        public class ButtonData
        {
            public string label;
            public string[] args;
        }
        
        public ButtonData[][] Buttons;
        
        public string ImagePath;
        public string Message;
    }

    [Serializable]
    public struct StateLink
    {
        public bool TransitionIsAvailable;
        
        public string StateName;
        
        public void SwitchToState()
        {
            if (!TransitionIsAvailable)
            {
                return;
            }
            
            
            StateMachine.SetState(StateFileManager.GetState(StateName));
        }
    }
    
    public SubState[] SubStates;
    public StateLink[] StateLinks;

    [XmlIgnore]
    public int CurrentSubStateIndex = 0;
    public int InitSubStateIndex = 0;
    public bool CycleSubStates = false;

    #endregion

    ////////////////////////////////////////////////////////////////////////////////////////////////////

    #region Life cycle

    public void Initialize()
    {
        CurrentSubStateIndex = InitSubStateIndex;
    }
    
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
    public static InlineKeyboardMarkup GetMarkup(this (string buttonName, string args)[][] buttonNames)
    {
        var keyboardButtons = new List<InlineKeyboardButton[]>();
        foreach(var array in buttonNames)
        {
            var buttonArray = new InlineKeyboardButton[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                buttonArray[i] = new InlineKeyboardButton(array[i].buttonName, array[i].args);
            }
            
            keyboardButtons.Add(buttonArray);
        }

        return new InlineKeyboardMarkup(keyboardButtons);
    }
}