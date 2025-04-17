using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DND_Bot_States.States;

namespace DND_Bot_XML_Baker.Forms;

public partial class SubStateButtonDataEditorForm : Form
{
    public MessageState.SubState.ButtonData Result;

    public SubStateButtonDataEditorForm(MessageState.SubState.ButtonData result)
    {
        InitializeComponent();

        Result = result;
        LabelTextBox.Text = Result.label;
        ArgumentsListBox.Items.Clear();
        ArgumentsListBox.Items.AddRange(result?.args ?? []);
    }

    private void LabelTextBox_TextChanged(object sender, EventArgs e)
    {
        Result.label = LabelTextBox.Text;
    }

    private void ArgumentsListBox_DoubleClick(object sender, EventArgs e)
    {
        if (ArgumentsListBox.SelectedItem == null)
        {
            return;
        }

        var buttonArgsForm = new SubStateButtonArgsEditorForm((string)ArgumentsListBox.SelectedItem);
        if (buttonArgsForm.ShowDialog() == DialogResult.OK)
        {
            ArgumentsListBox.Items[ArgumentsListBox.SelectedIndex] = buttonArgsForm.Result;
            ArgumentsListBox.Refresh();
            Result.args = ArgumentsListBox.Items.Cast<string>().ToArray();
        }
    }

    private void AddArgsButton_Click(object sender, EventArgs e)
    {
        ArgumentsListBox.Items.Add("Empty");
        Result.args = ArgumentsListBox.Items.Cast<string>().ToArray();
    }

    private void RemoveArgsButton_Click(object sender, EventArgs e)
    {
        if (ArgumentsListBox.SelectedItem != null)
        {
            ArgumentsListBox.Items.Remove(ArgumentsListBox.SelectedItem);
            Result.args = ArgumentsListBox.Items.Cast<string>().ToArray();
        }
    }
}