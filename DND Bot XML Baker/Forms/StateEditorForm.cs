using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DND_Bot_States;
using DND_Bot_States.States;
using DND_Bot_XML_Baker.Forms;

namespace DND_Bot_XML_Baker;

public partial class StateEditorForm : Form
{
    private string filePath;
    private string fileName;
    private int substateCount;

    private MessageState editableState = new();

    public StateEditorForm()
    {
        InitializeComponent();

        Text = "State Editor";
        AutoSize = true;
        AutoSizeMode = AutoSizeMode.GrowAndShrink;
        AutoScaleMode = AutoScaleMode.Dpi;
        Padding = new Padding(10);
    }

    private void BrowsePathButton_Click(object sender, EventArgs e)
    {
        var folderDialogue = new FolderBrowserDialog();
        if (folderDialogue.ShowDialog() == DialogResult.OK)
        {
            filePath = folderDialogue.SelectedPath;
            FilePathTextBox.Text = filePath;
        }
    }

    private void FileNameTextBox_TextChanged(object sender, EventArgs e)
    {
        fileName = FileNameTextBox.Text;
    }

    private void CycleSubStatesCheckbox_CheckedChanged(object sender, EventArgs e)
    {
        editableState.CycleSubStates = CycleSubStatesCheckbox.Checked;
    }

    private void InitialSubStateIndexNumeric_ValueChanged(object sender, EventArgs e)
    {
        editableState.InitSubStateIndex = (int)InitialSubStateIndexNumeric.Value;
    }

    private void AddSubStateButton_Click(object sender, EventArgs e)
    {
        SubStatesListBox.Items.Add(new SubStateItem
        {
            Name = "SubState",
            SubState = new MessageState.SubState(),
        });
        substateCount++;
        InitialSubStateIndexNumeric.Maximum = substateCount - 1;
    }

    private void RemoveSubStateButton_Click(object sender, EventArgs e)
    {
        if (SubStatesListBox.SelectedItem != null)
        {
            SubStatesListBox.Items.Remove(SubStatesListBox.SelectedItem);
            substateCount--;
            InitialSubStateIndexNumeric.Maximum = substateCount - 1;
        }
    }

    private void SubStatesListBox_DoubleClick(object sender, EventArgs e)
    {
        if (SubStatesListBox.SelectedItem == null)
        {
            return;
        }

        var subStateEditorForm = new SubStateDivsEditorForm((SubStateItem)SubStatesListBox.SelectedItem);
        if (subStateEditorForm.ShowDialog() == DialogResult.OK)
        {
            SubStatesListBox.SelectedItem = subStateEditorForm.Result;
        }
    }

    private void StateLinksAddButton_Click(object sender, EventArgs e)
    {
        StateLinksListBox.Items.Add(new SubStateLinkItem
        {
            Name = "Link",
            StateLink = default,
        });
    }

    private void StateLinksRemoveButton_Click(object sender, EventArgs e)
    {
        if (StateLinksListBox.SelectedItem != null)
        {
            StateLinksListBox.Items.Remove(StateLinksListBox.SelectedItem);
        }
    }

    private void StateLinksListBox_DoubleClick(object sender, EventArgs e)
    {
        if (StateLinksListBox.SelectedItem == null)
        {
            return;
        }

        var stateLinkEditorForm = new StateLinkEditorForm((SubStateLinkItem)StateLinksListBox.SelectedItem);
        if (stateLinkEditorForm.ShowDialog() == DialogResult.OK)
        {
            StateLinksListBox.SelectedItem = stateLinkEditorForm.Result;
        }
    }

    private void SaveState_Click(object sender, EventArgs e)
    {
        editableState.SubStates = SubStatesListBox.Items.Cast<SubStateItem>().Select(x => x.SubState).ToArray();
        editableState.StateLinks = StateLinksListBox.Items.Cast<SubStateLinkItem>().Select(x => x.StateLink).ToArray();

        StateFileManager.SaveState(editableState, Path.Combine(filePath, fileName));
    }

    private void LoadFileButton_Click(object sender, EventArgs e)
    {
        var fileBrowseDialog = new OpenFileDialog();
        fileBrowseDialog.Filter = "XML Image (*.xml;)|*.xml;";
        if (fileBrowseDialog.ShowDialog() == DialogResult.OK)
        {
            string filePath = Path.GetRelativePath(StateFileManager.StateFolderPath, fileBrowseDialog.FileName);
            editableState = StateFileManager.GetState(filePath);
            FilePathTextBox.Text = filePath;
            FileNameTextBox.Text = Path.GetFileNameWithoutExtension(filePath);
            SubStatesListBox.Items.Clear();
            SubStatesListBox.Items.AddRange(editableState.SubStates.Select(x => new SubStateItem
            {
                Name = "SubState",
                SubState = x,
            }).ToArray());
            StateLinksListBox.Items.Clear();
            StateLinksListBox.Items.AddRange(editableState.StateLinks.Select(x => new SubStateLinkItem
            {
                Name = "Link",
                StateLink = x
            }).ToArray());
            CycleSubStatesCheckbox.Checked = editableState.CycleSubStates;
            InitialSubStateIndexNumeric.Maximum = editableState.SubStates.Length - 1;
            InitialSubStateIndexNumeric.Value = editableState.InitSubStateIndex;
        }
    }
}

public class SubStateItem
{
    public string Name;
    public MessageState.SubState SubState = new()
    {
        Buttons = [],
        ImagePath = string.Empty,
        Message = string.Empty
    };

    public override string ToString()
    {
        return Name;
    }
}

public class SubStateLinkItem
{
    public string Name;
    public MessageState.StateLink StateLink;

    public override string ToString()
    {
        return Name;
    }
}