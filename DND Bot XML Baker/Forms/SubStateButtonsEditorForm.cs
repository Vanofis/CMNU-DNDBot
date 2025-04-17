using System;
using System.Linq;
using System.Windows.Forms;
using DND_Bot_States.States;

namespace DND_Bot_XML_Baker.Forms;

public partial class SubStateButtonsEditorForm : Form
{
    public MessageState.SubState.ButtonData[] Result;
    
    public SubStateButtonsEditorForm(MessageState.SubState.ButtonData[] result)
    {
        InitializeComponent();
        
        Result = result;
        ButtonsListBox.Items.Clear();
        ButtonsListBox.Items.AddRange(Result);
    }

    private void ButtonAddButton_Click(object sender, EventArgs e)
    {
        ButtonsListBox.Items.Add(new MessageState.SubState.ButtonData());
        Result = ButtonsListBox.Items.Cast<MessageState.SubState.ButtonData>().ToArray();
    }

    private void ButtonRemoveButton_Click(object sender, EventArgs e)
    {
        if (ButtonsListBox.SelectedItem != null)
        {
            ButtonsListBox.Items.Remove(ButtonsListBox.SelectedItem);
            Result = ButtonsListBox.Items.Cast<MessageState.SubState.ButtonData>().ToArray();
        }
    }

    private void ButtonsListBox_DoubleClick(object sender, EventArgs e)
    {
        if (ButtonsListBox.SelectedItem == null)
        {
            return;
        }
        
        var dataEditorForm = new SubStateButtonDataEditorForm((MessageState.SubState.ButtonData)ButtonsListBox.SelectedItem);
        if (dataEditorForm.ShowDialog() == DialogResult.OK)
        {
            ButtonsListBox.Items[ButtonsListBox.SelectedIndex] = dataEditorForm.Result;
            ButtonsListBox.Refresh();
            Result = ButtonsListBox.Items.Cast<MessageState.SubState.ButtonData>().ToArray();
        }
    }
}

