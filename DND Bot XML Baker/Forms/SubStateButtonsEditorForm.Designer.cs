namespace DND_Bot_XML_Baker.Forms
{
    partial class SubStateButtonsEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DivsLayout = new System.Windows.Forms.FlowLayoutPanel();
            ButtonsLabel = new System.Windows.Forms.Label();
            ButtonsListBox = new System.Windows.Forms.ListBox();
            DivsButtons = new System.Windows.Forms.FlowLayoutPanel();
            ButtonAddButton = new System.Windows.Forms.Button();
            ButtonRemoveButton = new System.Windows.Forms.Button();
            OkButton = new System.Windows.Forms.Button();
            DivsLayout.SuspendLayout();
            DivsButtons.SuspendLayout();
            SuspendLayout();
            // 
            // DivsLayout
            // 
            DivsLayout.AutoSize = true;
            DivsLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            DivsLayout.Controls.Add(ButtonsLabel);
            DivsLayout.Controls.Add(ButtonsListBox);
            DivsLayout.Controls.Add(DivsButtons);
            DivsLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            DivsLayout.Location = new System.Drawing.Point(14, 16);
            DivsLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            DivsLayout.Name = "DivsLayout";
            DivsLayout.Size = new System.Drawing.Size(267, 225);
            DivsLayout.TabIndex = 0;
            // 
            // ButtonsLabel
            // 
            ButtonsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            ButtonsLabel.Location = new System.Drawing.Point(0, 0);
            ButtonsLabel.Margin = new System.Windows.Forms.Padding(0);
            ButtonsLabel.Name = "ButtonsLabel";
            ButtonsLabel.Size = new System.Drawing.Size(229, 32);
            ButtonsLabel.TabIndex = 0;
            ButtonsLabel.Text = "Buttons";
            ButtonsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonsListBox
            // 
            ButtonsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            ButtonsListBox.FormattingEnabled = true;
            ButtonsListBox.Location = new System.Drawing.Point(3, 36);
            ButtonsListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ButtonsListBox.Name = "ButtonsListBox";
            ButtonsListBox.Size = new System.Drawing.Size(259, 127);
            ButtonsListBox.TabIndex = 1;
            ButtonsListBox.DoubleClick += ButtonsListBox_DoubleClick;
            // 
            // DivsButtons
            // 
            DivsButtons.AutoSize = true;
            DivsButtons.Controls.Add(ButtonAddButton);
            DivsButtons.Controls.Add(ButtonRemoveButton);
            DivsButtons.Location = new System.Drawing.Point(3, 171);
            DivsButtons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            DivsButtons.Name = "DivsButtons";
            DivsButtons.Size = new System.Drawing.Size(259, 48);
            DivsButtons.TabIndex = 2;
            // 
            // ButtonAddButton
            // 
            ButtonAddButton.AutoSize = true;
            ButtonAddButton.Location = new System.Drawing.Point(3, 4);
            ButtonAddButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ButtonAddButton.Name = "ButtonAddButton";
            ButtonAddButton.Size = new System.Drawing.Size(109, 40);
            ButtonAddButton.TabIndex = 0;
            ButtonAddButton.Text = "Add button";
            ButtonAddButton.UseVisualStyleBackColor = true;
            ButtonAddButton.Click += ButtonAddButton_Click;
            // 
            // ButtonRemoveButton
            // 
            ButtonRemoveButton.AutoSize = true;
            ButtonRemoveButton.Location = new System.Drawing.Point(118, 4);
            ButtonRemoveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ButtonRemoveButton.Name = "ButtonRemoveButton";
            ButtonRemoveButton.Size = new System.Drawing.Size(138, 40);
            ButtonRemoveButton.TabIndex = 1;
            ButtonRemoveButton.Text = "Remove button";
            ButtonRemoveButton.UseVisualStyleBackColor = true;
            ButtonRemoveButton.Click += ButtonRemoveButton_Click;
            // 
            // OkButton
            // 
            OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            OkButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            OkButton.Location = new System.Drawing.Point(14, 245);
            OkButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            OkButton.Name = "OkButton";
            OkButton.Size = new System.Drawing.Size(267, 60);
            OkButton.TabIndex = 1;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = true;
            // 
            // SubStateButtonsEditorForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(311, 320);
            Controls.Add(OkButton);
            Controls.Add(DivsLayout);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "SubStateButtonsEditorForm";
            Text = "SubStateButtonsEditorForm";
            DivsLayout.ResumeLayout(false);
            DivsLayout.PerformLayout();
            DivsButtons.ResumeLayout(false);
            DivsButtons.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel DivsLayout;
        private System.Windows.Forms.Label ButtonsLabel;
        private System.Windows.Forms.ListBox ButtonsListBox;
        private System.Windows.Forms.FlowLayoutPanel DivsButtons;
        private System.Windows.Forms.Button ButtonAddButton;
        private System.Windows.Forms.Button ButtonRemoveButton;
        private System.Windows.Forms.Button OkButton;
    }
}