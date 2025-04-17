using System;
using System.Linq;
using System.Windows.Forms;
using DND_Bot_States.States;
using DND_Bot_XML_Baker.Forms;

namespace DND_Bot_XML_Baker;

public partial class SubStateDivsEditorForm : Form
{
    public SubStateItem Result;

    public SubStateDivsEditorForm(SubStateItem result)
    {
        InitializeComponent();

        Result = result;
        ButtonDivsListBox.Items.AddRange(Result.SubState.Buttons ?? []);
    }

    private void MessageTextBox_TextChanged(object sender, System.EventArgs e)
    {
        Result.SubState.Message = MessageTextBox.Text;
    }

    private void ImagePathTextBox_TextChanged(object sender, System.EventArgs e)
    {
        Result.SubState.ImagePath = ImagePathTextBox.Text;
    }

    private void ImagePathBrowseButton_Click(object sender, System.EventArgs e)
    {
        var openFileDialogue = new OpenFileDialog();
        openFileDialogue.Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";
        openFileDialogue.Title = "Select an image";

        if (openFileDialogue.ShowDialog() == DialogResult.OK)
        {
            Result.SubState.ImagePath = openFileDialogue.FileName;
            ImagePathTextBox.Text = openFileDialogue.FileName;
        }
    }

    private void AddButtonButton_Click(object sender, System.EventArgs e)
    {
        ButtonDivsListBox.Items.Add(Array.Empty<MessageState.SubState.ButtonData>());
        Result.SubState.Buttons = ButtonDivsListBox.Items.Cast<MessageState.SubState.ButtonData[]>().ToArray();
    }

    private void RemoveButtonButton_Click(object sender, System.EventArgs e)
    {
        if (ButtonDivsListBox.SelectedItem != null)
        {
            ButtonDivsListBox.Items.Remove(ButtonDivsListBox.SelectedItem);
            Result.SubState.Buttons = ButtonDivsListBox.Items.Cast<MessageState.SubState.ButtonData[]>().ToArray();
        }
    }

    private void ButtonsListBox_DoubleClick(object sender, System.EventArgs e)
    {
        if (ButtonDivsListBox.SelectedItem == null)
        {
            return;
        }
        
        var buttonsEditorForm = new SubStateButtonsEditorForm((MessageState.SubState.ButtonData[])ButtonDivsListBox.SelectedItem);
        if (buttonsEditorForm.ShowDialog() == DialogResult.OK)
        {
            ButtonDivsListBox.Items[ButtonDivsListBox.SelectedIndex] = buttonsEditorForm.Result;
            Result.SubState.Buttons = ButtonDivsListBox.Items.Cast<MessageState.SubState.ButtonData[]>().ToArray();
        }
    }
}