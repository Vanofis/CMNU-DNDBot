using System;
using System.IO;
using System.Windows.Forms;
using DND_Bot_States;

namespace DND_Bot_XML_Baker.Forms
{
    public partial class StateLinkEditorForm : Form
    {
        public SubStateLinkItem Result;

        public StateLinkEditorForm(SubStateLinkItem result)
        {
            InitializeComponent();

            Result = result;
            TransitionIsAvailableCheckbox.Checked = Result.StateLink.TransitionIsAvailable;
            StateLinkPathTextBox.Text = Result.StateLink.StateName;
        }

        private void LinkPathBrowseButton_Click(object sender, EventArgs e)
        {
            var fileBrowseDialog = new OpenFileDialog();
            fileBrowseDialog.Filter = "XML Image (*.xml;)|*.xml;";
            if (fileBrowseDialog.ShowDialog() == DialogResult.OK)
            {
                Result.StateLink.StateName = Path.GetRelativePath(StateFileManager.StateFolderPath, fileBrowseDialog.FileName);
                StateLinkPathTextBox.Text = Result.StateLink.StateName;
            }
        }

        private void TransitionIsAvailableCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Result.StateLink.TransitionIsAvailable = TransitionIsAvailableCheckbox.Checked;
        }
    }
}
