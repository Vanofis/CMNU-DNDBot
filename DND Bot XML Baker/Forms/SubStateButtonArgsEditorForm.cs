using System;
using System.Text;
using System.Windows.Forms;
using DND_Bot_States.States;

namespace DND_Bot_XML_Baker.Forms
{
    public partial class SubStateButtonArgsEditorForm : Form
    {
        public string Result;
        
        public SubStateButtonArgsEditorForm(string result)
        {
            InitializeComponent();
            
            Result = result;
            ActionTypeComboBox.Items.Clear();
            ActionTypeComboBox.Items.AddRange(Enum.GetNames(typeof(ActionType)));
            
            var splitResult = result.Split('|');
            ActionTypeComboBox.SelectedItem = splitResult.Length >= 2 ? splitResult[0] : string.Empty;
            ArgsTextBox.Text = splitResult.Length >= 2 ? splitResult[1] : string.Empty;
        }

        private void ActionTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildArgs();
        }

        private void ArgsTextBox_TextChanged(object sender, EventArgs e)
        {
            ArgsTextBox.Text.Replace(" ", string.Empty);

            BuildArgs();
        }

        private void BuildArgs()
        {
            var builder = new StringBuilder();
            builder.Append(ActionTypeComboBox.SelectedItem?.ToString() ?? "None");
            builder.Append('|');
            builder.Append(ArgsTextBox.Text);
            
            Result = builder.ToString();
        }
    }
}
