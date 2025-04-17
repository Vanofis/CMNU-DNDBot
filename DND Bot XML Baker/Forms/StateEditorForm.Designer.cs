namespace DND_Bot_XML_Baker
{
    partial class StateEditorForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FileSettingsLayout = new System.Windows.Forms.FlowLayoutPanel();
            PathSubLayout = new System.Windows.Forms.FlowLayoutPanel();
            FileNameSubLayout = new System.Windows.Forms.FlowLayoutPanel();
            FilePathLabel = new System.Windows.Forms.Label();
            FilePathTextBox = new System.Windows.Forms.TextBox();
            BrowsePathButton = new System.Windows.Forms.Button();
            SubStatesLayout = new System.Windows.Forms.FlowLayoutPanel();
            SubStatesIndex = new System.Windows.Forms.Label();
            SubStatesListBox = new System.Windows.Forms.ListBox();
            SubstatesButtonsLayout = new System.Windows.Forms.FlowLayoutPanel();
            AddSubStateButton = new System.Windows.Forms.Button();
            RemoveSubStateButton = new System.Windows.Forms.Button();
            CycleSubStatesCheckbox = new System.Windows.Forms.CheckBox();
            SubStateIndexLayout = new System.Windows.Forms.FlowLayoutPanel();
            InitialSubstateIndexLabel = new System.Windows.Forms.Label();
            InitialSubStateIndexNumeric = new System.Windows.Forms.NumericUpDown();
            StateLinkLayout = new System.Windows.Forms.FlowLayoutPanel();
            StateLinksLabel = new System.Windows.Forms.Label();
            StateLinksListBox = new System.Windows.Forms.ListBox();
            StateLinksButtons = new System.Windows.Forms.FlowLayoutPanel();
            StateLinksAddButton = new System.Windows.Forms.Button();
            StateLinksRemoveButton = new System.Windows.Forms.Button();
            LoadFileButton = new System.Windows.Forms.Button();
            SaveState = new System.Windows.Forms.Button();
            flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            FileNameTextBox = new System.Windows.Forms.TextBox();
            FileNameLabel = new System.Windows.Forms.Label();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            FileSettingsLayout.SuspendLayout();
            FileNameSubLayout.SuspendLayout();
            SubStatesLayout.SuspendLayout();
            SubstatesButtonsLayout.SuspendLayout();
            SubStateIndexLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InitialSubStateIndexNumeric).BeginInit();
            StateLinkLayout.SuspendLayout();
            StateLinksButtons.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // FileSettingsLayout
            // 
            FileSettingsLayout.AutoSize = true;
            FileSettingsLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            FileSettingsLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            FileSettingsLayout.Controls.Add(PathSubLayout);
            FileSettingsLayout.Controls.Add(FileNameSubLayout);
            FileSettingsLayout.Controls.Add(flowLayoutPanel1);
            FileSettingsLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            FileSettingsLayout.Location = new System.Drawing.Point(15, 183);
            FileSettingsLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            FileSettingsLayout.Name = "FileSettingsLayout";
            FileSettingsLayout.Size = new System.Drawing.Size(430, 119);
            FileSettingsLayout.TabIndex = 0;
            // 
            // PathSubLayout
            // 
            PathSubLayout.AutoSize = true;
            PathSubLayout.Dock = System.Windows.Forms.DockStyle.Left;
            PathSubLayout.Location = new System.Drawing.Point(0, 0);
            PathSubLayout.Margin = new System.Windows.Forms.Padding(0);
            PathSubLayout.Name = "PathSubLayout";
            PathSubLayout.Size = new System.Drawing.Size(0, 0);
            PathSubLayout.TabIndex = 1;
            // 
            // FileNameSubLayout
            // 
            FileNameSubLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            FileNameSubLayout.Controls.Add(FilePathLabel);
            FileNameSubLayout.Controls.Add(FilePathTextBox);
            FileNameSubLayout.Controls.Add(BrowsePathButton);
            FileNameSubLayout.Location = new System.Drawing.Point(3, 7);
            FileNameSubLayout.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            FileNameSubLayout.Name = "FileNameSubLayout";
            FileNameSubLayout.Size = new System.Drawing.Size(422, 46);
            FileNameSubLayout.TabIndex = 2;
            // 
            // FilePathLabel
            // 
            FilePathLabel.Location = new System.Drawing.Point(3, 0);
            FilePathLabel.Name = "FilePathLabel";
            FilePathLabel.Size = new System.Drawing.Size(78, 31);
            FilePathLabel.TabIndex = 0;
            FilePathLabel.Text = "File path";
            FilePathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FilePathTextBox
            // 
            FilePathTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            FilePathTextBox.Location = new System.Drawing.Point(87, 4);
            FilePathTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            FilePathTextBox.Name = "FilePathTextBox";
            FilePathTextBox.ReadOnly = true;
            FilePathTextBox.Size = new System.Drawing.Size(230, 27);
            FilePathTextBox.TabIndex = 1;
            // 
            // BrowsePathButton
            // 
            BrowsePathButton.Location = new System.Drawing.Point(323, 4);
            BrowsePathButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            BrowsePathButton.Name = "BrowsePathButton";
            BrowsePathButton.Size = new System.Drawing.Size(86, 31);
            BrowsePathButton.TabIndex = 2;
            BrowsePathButton.Text = "Browse";
            BrowsePathButton.UseVisualStyleBackColor = true;
            BrowsePathButton.Click += BrowsePathButton_Click;
            // 
            // SubStatesLayout
            // 
            SubStatesLayout.AutoSize = true;
            SubStatesLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            SubStatesLayout.BackColor = System.Drawing.SystemColors.Control;
            SubStatesLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            SubStatesLayout.Controls.Add(SubStatesIndex);
            SubStatesLayout.Controls.Add(SubStatesListBox);
            SubStatesLayout.Controls.Add(SubstatesButtonsLayout);
            SubStatesLayout.Controls.Add(CycleSubStatesCheckbox);
            SubStatesLayout.Controls.Add(SubStateIndexLayout);
            SubStatesLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            SubStatesLayout.Location = new System.Drawing.Point(15, 310);
            SubStatesLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            SubStatesLayout.Name = "SubStatesLayout";
            SubStatesLayout.Size = new System.Drawing.Size(431, 330);
            SubStatesLayout.TabIndex = 1;
            // 
            // SubStatesIndex
            // 
            SubStatesIndex.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            SubStatesIndex.Location = new System.Drawing.Point(0, 0);
            SubStatesIndex.Margin = new System.Windows.Forms.Padding(0, 0, 0, 7);
            SubStatesIndex.Name = "SubStatesIndex";
            SubStatesIndex.Size = new System.Drawing.Size(429, 28);
            SubStatesIndex.TabIndex = 0;
            SubStatesIndex.Text = "SubStates";
            SubStatesIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubStatesListBox
            // 
            SubStatesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            SubStatesListBox.FormattingEnabled = true;
            SubStatesListBox.Location = new System.Drawing.Point(3, 42);
            SubStatesListBox.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            SubStatesListBox.Name = "SubStatesListBox";
            SubStatesListBox.Size = new System.Drawing.Size(423, 127);
            SubStatesListBox.TabIndex = 4;
            SubStatesListBox.DoubleClick += SubStatesListBox_DoubleClick;
            // 
            // SubstatesButtonsLayout
            // 
            SubstatesButtonsLayout.AutoSize = true;
            SubstatesButtonsLayout.Controls.Add(AddSubStateButton);
            SubstatesButtonsLayout.Controls.Add(RemoveSubStateButton);
            SubstatesButtonsLayout.Location = new System.Drawing.Point(3, 183);
            SubstatesButtonsLayout.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            SubstatesButtonsLayout.Name = "SubstatesButtonsLayout";
            SubstatesButtonsLayout.Size = new System.Drawing.Size(284, 48);
            SubstatesButtonsLayout.TabIndex = 2;
            // 
            // AddSubStateButton
            // 
            AddSubStateButton.AutoSize = true;
            AddSubStateButton.Location = new System.Drawing.Point(3, 4);
            AddSubStateButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            AddSubStateButton.Name = "AddSubStateButton";
            AddSubStateButton.Size = new System.Drawing.Size(121, 40);
            AddSubStateButton.TabIndex = 1;
            AddSubStateButton.Text = "Add substate";
            AddSubStateButton.UseVisualStyleBackColor = true;
            AddSubStateButton.Click += AddSubStateButton_Click;
            // 
            // RemoveSubStateButton
            // 
            RemoveSubStateButton.AutoSize = true;
            RemoveSubStateButton.Location = new System.Drawing.Point(130, 4);
            RemoveSubStateButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            RemoveSubStateButton.Name = "RemoveSubStateButton";
            RemoveSubStateButton.Size = new System.Drawing.Size(151, 40);
            RemoveSubStateButton.TabIndex = 0;
            RemoveSubStateButton.Text = "Remove substate";
            RemoveSubStateButton.UseVisualStyleBackColor = true;
            RemoveSubStateButton.Click += RemoveSubStateButton_Click;
            // 
            // CycleSubStatesCheckbox
            // 
            CycleSubStatesCheckbox.AutoSize = true;
            CycleSubStatesCheckbox.Location = new System.Drawing.Point(3, 245);
            CycleSubStatesCheckbox.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            CycleSubStatesCheckbox.Name = "CycleSubStatesCheckbox";
            CycleSubStatesCheckbox.Size = new System.Drawing.Size(135, 24);
            CycleSubStatesCheckbox.TabIndex = 2;
            CycleSubStatesCheckbox.Text = "Cycle sub states";
            CycleSubStatesCheckbox.UseVisualStyleBackColor = true;
            CycleSubStatesCheckbox.CheckedChanged += CycleSubStatesCheckbox_CheckedChanged;
            // 
            // SubStateIndexLayout
            // 
            SubStateIndexLayout.AutoSize = true;
            SubStateIndexLayout.BackColor = System.Drawing.SystemColors.Control;
            SubStateIndexLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            SubStateIndexLayout.Controls.Add(InitialSubstateIndexLabel);
            SubStateIndexLayout.Controls.Add(InitialSubStateIndexNumeric);
            SubStateIndexLayout.Location = new System.Drawing.Point(3, 283);
            SubStateIndexLayout.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            SubStateIndexLayout.Name = "SubStateIndexLayout";
            SubStateIndexLayout.Size = new System.Drawing.Size(209, 38);
            SubStateIndexLayout.TabIndex = 3;
            // 
            // InitialSubstateIndexLabel
            // 
            InitialSubstateIndexLabel.Location = new System.Drawing.Point(0, 0);
            InitialSubstateIndexLabel.Margin = new System.Windows.Forms.Padding(0);
            InitialSubstateIndexLabel.Name = "InitialSubstateIndexLabel";
            InitialSubstateIndexLabel.Size = new System.Drawing.Size(139, 36);
            InitialSubstateIndexLabel.TabIndex = 0;
            InitialSubstateIndexLabel.Text = "Initial substate index";
            InitialSubstateIndexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InitialSubStateIndexNumeric
            // 
            InitialSubStateIndexNumeric.Location = new System.Drawing.Point(142, 4);
            InitialSubStateIndexNumeric.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            InitialSubStateIndexNumeric.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
            InitialSubStateIndexNumeric.Name = "InitialSubStateIndexNumeric";
            InitialSubStateIndexNumeric.Size = new System.Drawing.Size(62, 27);
            InitialSubStateIndexNumeric.TabIndex = 1;
            InitialSubStateIndexNumeric.ValueChanged += InitialSubStateIndexNumeric_ValueChanged;
            // 
            // StateLinkLayout
            // 
            StateLinkLayout.AutoSize = true;
            StateLinkLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            StateLinkLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            StateLinkLayout.Controls.Add(StateLinksLabel);
            StateLinkLayout.Controls.Add(StateLinksListBox);
            StateLinkLayout.Controls.Add(StateLinksButtons);
            StateLinkLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            StateLinkLayout.Location = new System.Drawing.Point(15, 647);
            StateLinkLayout.Name = "StateLinkLayout";
            StateLinkLayout.Size = new System.Drawing.Size(431, 262);
            StateLinkLayout.TabIndex = 2;
            // 
            // StateLinksLabel
            // 
            StateLinksLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            StateLinksLabel.Location = new System.Drawing.Point(3, 0);
            StateLinksLabel.Name = "StateLinksLabel";
            StateLinksLabel.Size = new System.Drawing.Size(423, 28);
            StateLinksLabel.TabIndex = 0;
            StateLinksLabel.Text = "State links";
            StateLinksLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StateLinksListBox
            // 
            StateLinksListBox.FormattingEnabled = true;
            StateLinksListBox.Location = new System.Drawing.Point(3, 31);
            StateLinksListBox.Name = "StateLinksListBox";
            StateLinksListBox.Size = new System.Drawing.Size(419, 184);
            StateLinksListBox.TabIndex = 1;
            StateLinksListBox.DoubleClick += StateLinksListBox_DoubleClick;
            // 
            // StateLinksButtons
            // 
            StateLinksButtons.AutoSize = true;
            StateLinksButtons.Controls.Add(StateLinksAddButton);
            StateLinksButtons.Controls.Add(StateLinksRemoveButton);
            StateLinksButtons.Location = new System.Drawing.Point(3, 221);
            StateLinksButtons.Name = "StateLinksButtons";
            StateLinksButtons.Size = new System.Drawing.Size(206, 36);
            StateLinksButtons.TabIndex = 2;
            // 
            // StateLinksAddButton
            // 
            StateLinksAddButton.AutoSize = true;
            StateLinksAddButton.Location = new System.Drawing.Point(3, 3);
            StateLinksAddButton.Name = "StateLinksAddButton";
            StateLinksAddButton.Size = new System.Drawing.Size(94, 30);
            StateLinksAddButton.TabIndex = 0;
            StateLinksAddButton.Text = "Add link";
            StateLinksAddButton.UseVisualStyleBackColor = true;
            StateLinksAddButton.Click += StateLinksAddButton_Click;
            // 
            // StateLinksRemoveButton
            // 
            StateLinksRemoveButton.AutoSize = true;
            StateLinksRemoveButton.Location = new System.Drawing.Point(103, 3);
            StateLinksRemoveButton.Name = "StateLinksRemoveButton";
            StateLinksRemoveButton.Size = new System.Drawing.Size(100, 30);
            StateLinksRemoveButton.TabIndex = 1;
            StateLinksRemoveButton.Text = "Remove link";
            StateLinksRemoveButton.UseVisualStyleBackColor = true;
            StateLinksRemoveButton.Click += StateLinksRemoveButton_Click;
            // 
            // LoadFileButton
            // 
            LoadFileButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            LoadFileButton.Location = new System.Drawing.Point(3, 3);
            LoadFileButton.Name = "LoadFileButton";
            LoadFileButton.Size = new System.Drawing.Size(421, 75);
            LoadFileButton.TabIndex = 3;
            LoadFileButton.Text = "Load existing file";
            LoadFileButton.UseVisualStyleBackColor = true;
            LoadFileButton.Click += LoadFileButton_Click;
            // 
            // SaveState
            // 
            SaveState.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            SaveState.Location = new System.Drawing.Point(3, 84);
            SaveState.Name = "SaveState";
            SaveState.Size = new System.Drawing.Size(421, 75);
            SaveState.TabIndex = 4;
            SaveState.Text = "Save state";
            SaveState.UseVisualStyleBackColor = true;
            SaveState.Click += SaveState_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            flowLayoutPanel2.Controls.Add(LoadFileButton);
            flowLayoutPanel2.Controls.Add(SaveState);
            flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel2.Location = new System.Drawing.Point(15, 12);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new System.Drawing.Size(429, 164);
            flowLayoutPanel2.TabIndex = 5;
            // 
            // FileNameTextBox
            // 
            FileNameTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            FileNameTextBox.Location = new System.Drawing.Point(87, 4);
            FileNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            FileNameTextBox.Name = "FileNameTextBox";
            FileNameTextBox.Size = new System.Drawing.Size(230, 27);
            FileNameTextBox.TabIndex = 2;
            FileNameTextBox.TextChanged += FileNameTextBox_TextChanged;
            // 
            // FileNameLabel
            // 
            FileNameLabel.Location = new System.Drawing.Point(3, 0);
            FileNameLabel.Name = "FileNameLabel";
            FileNameLabel.Size = new System.Drawing.Size(78, 44);
            FileNameLabel.TabIndex = 0;
            FileNameLabel.Text = "File name";
            FileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(FileNameLabel);
            flowLayoutPanel1.Controls.Add(FileNameTextBox);
            flowLayoutPanel1.Location = new System.Drawing.Point(3, 67);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(422, 43);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // StateEditorForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(487, 914);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(StateLinkLayout);
            Controls.Add(SubStatesLayout);
            Controls.Add(FileSettingsLayout);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "StateEditorForm";
            Text = "StateEditorForm";
            FileSettingsLayout.ResumeLayout(false);
            FileSettingsLayout.PerformLayout();
            FileNameSubLayout.ResumeLayout(false);
            FileNameSubLayout.PerformLayout();
            SubStatesLayout.ResumeLayout(false);
            SubStatesLayout.PerformLayout();
            SubstatesButtonsLayout.ResumeLayout(false);
            SubstatesButtonsLayout.PerformLayout();
            SubStateIndexLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)InitialSubStateIndexNumeric).EndInit();
            StateLinkLayout.ResumeLayout(false);
            StateLinkLayout.PerformLayout();
            StateLinksButtons.ResumeLayout(false);
            StateLinksButtons.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FileSettingsLayout;
        private System.Windows.Forms.FlowLayoutPanel PathSubLayout;
        private System.Windows.Forms.FlowLayoutPanel FileNameSubLayout;
        private System.Windows.Forms.Label FilePathLabel;
        private System.Windows.Forms.TextBox FilePathTextBox;
        private System.Windows.Forms.Button BrowsePathButton;
        private System.Windows.Forms.FlowLayoutPanel SubStatesLayout;
        private System.Windows.Forms.Label SubStatesIndex;
        private System.Windows.Forms.FlowLayoutPanel SubstatesButtonsLayout;
        private System.Windows.Forms.Button AddSubStateButton;
        private System.Windows.Forms.Button RemoveSubStateButton;
        private System.Windows.Forms.CheckBox CycleSubStatesCheckbox;
        private System.Windows.Forms.FlowLayoutPanel SubStateIndexLayout;
        private System.Windows.Forms.Label InitialSubstateIndexLabel;
        private System.Windows.Forms.NumericUpDown InitialSubStateIndexNumeric;
        private System.Windows.Forms.ListBox SubStatesListBox;
        private System.Windows.Forms.FlowLayoutPanel StateLinkLayout;
        private System.Windows.Forms.Label StateLinksLabel;
        private System.Windows.Forms.ListBox StateLinksListBox;
        private System.Windows.Forms.Button LoadFileButton;
        private System.Windows.Forms.FlowLayoutPanel StateLinksButtons;
        private System.Windows.Forms.Button StateLinksAddButton;
        private System.Windows.Forms.Button StateLinksRemoveButton;
        private System.Windows.Forms.Button SaveState;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.TextBox FileNameTextBox;
    }
}
