namespace DND_Bot_XML_Baker.Forms
{
    partial class SubStateButtonDataEditorForm
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
            ButtonDataLayout = new System.Windows.Forms.FlowLayoutPanel();
            LabelLayout = new System.Windows.Forms.FlowLayoutPanel();
            LabelLabel = new System.Windows.Forms.Label();
            LabelTextBox = new System.Windows.Forms.TextBox();
            ArgsLayout = new System.Windows.Forms.FlowLayoutPanel();
            ArgsLabel = new System.Windows.Forms.Label();
            ArgumentsListBox = new System.Windows.Forms.ListBox();
            OkButton = new System.Windows.Forms.Button();
            ButtonsLayout = new System.Windows.Forms.FlowLayoutPanel();
            AddArgsButton = new System.Windows.Forms.Button();
            RemoveArgsButton = new System.Windows.Forms.Button();
            ButtonDataLayout.SuspendLayout();
            LabelLayout.SuspendLayout();
            ArgsLayout.SuspendLayout();
            ButtonsLayout.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonDataLayout
            // 
            ButtonDataLayout.AutoSize = true;
            ButtonDataLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            ButtonDataLayout.Controls.Add(LabelLayout);
            ButtonDataLayout.Controls.Add(ArgsLayout);
            ButtonDataLayout.Controls.Add(ArgumentsListBox);
            ButtonDataLayout.Controls.Add(ButtonsLayout);
            ButtonDataLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            ButtonDataLayout.Location = new System.Drawing.Point(14, 16);
            ButtonDataLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ButtonDataLayout.Name = "ButtonDataLayout";
            ButtonDataLayout.Size = new System.Drawing.Size(364, 308);
            ButtonDataLayout.TabIndex = 0;
            // 
            // LabelLayout
            // 
            LabelLayout.AutoSize = true;
            LabelLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            LabelLayout.Controls.Add(LabelLabel);
            LabelLayout.Controls.Add(LabelTextBox);
            LabelLayout.Location = new System.Drawing.Point(3, 4);
            LabelLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            LabelLayout.Name = "LabelLayout";
            LabelLayout.Size = new System.Drawing.Size(312, 37);
            LabelLayout.TabIndex = 2;
            // 
            // LabelLabel
            // 
            LabelLabel.Location = new System.Drawing.Point(3, 0);
            LabelLabel.Name = "LabelLabel";
            LabelLabel.Size = new System.Drawing.Size(46, 35);
            LabelLabel.TabIndex = 0;
            LabelLabel.Text = "Label";
            LabelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelTextBox
            // 
            LabelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            LabelTextBox.Location = new System.Drawing.Point(55, 4);
            LabelTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            LabelTextBox.Name = "LabelTextBox";
            LabelTextBox.Size = new System.Drawing.Size(252, 27);
            LabelTextBox.TabIndex = 1;
            LabelTextBox.TextChanged += LabelTextBox_TextChanged;
            // 
            // ArgsLayout
            // 
            ArgsLayout.AutoSize = true;
            ArgsLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            ArgsLayout.Controls.Add(ArgsLabel);
            ArgsLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            ArgsLayout.Location = new System.Drawing.Point(3, 49);
            ArgsLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ArgsLayout.Name = "ArgsLayout";
            ArgsLayout.Size = new System.Drawing.Size(356, 37);
            ArgsLayout.TabIndex = 1;
            // 
            // ArgsLabel
            // 
            ArgsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            ArgsLabel.Location = new System.Drawing.Point(0, 0);
            ArgsLabel.Margin = new System.Windows.Forms.Padding(0);
            ArgsLabel.Name = "ArgsLabel";
            ArgsLabel.Size = new System.Drawing.Size(354, 35);
            ArgsLabel.TabIndex = 0;
            ArgsLabel.Text = "Arguments";
            ArgsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ArgumentsListBox
            // 
            ArgumentsListBox.FormattingEnabled = true;
            ArgumentsListBox.Location = new System.Drawing.Point(3, 93);
            ArgumentsListBox.Name = "ArgumentsListBox";
            ArgumentsListBox.Size = new System.Drawing.Size(355, 164);
            ArgumentsListBox.TabIndex = 3;
            ArgumentsListBox.DoubleClick += ArgumentsListBox_DoubleClick;
            // 
            // OkButton
            // 
            OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            OkButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            OkButton.Location = new System.Drawing.Point(14, 332);
            OkButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            OkButton.Name = "OkButton";
            OkButton.Size = new System.Drawing.Size(366, 47);
            OkButton.TabIndex = 1;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = true;
            // 
            // ButtonsLayout
            // 
            ButtonsLayout.AutoSize = true;
            ButtonsLayout.Controls.Add(AddArgsButton);
            ButtonsLayout.Controls.Add(RemoveArgsButton);
            ButtonsLayout.Location = new System.Drawing.Point(3, 263);
            ButtonsLayout.Name = "ButtonsLayout";
            ButtonsLayout.Size = new System.Drawing.Size(211, 36);
            ButtonsLayout.TabIndex = 4;
            // 
            // AddArgsButton
            // 
            AddArgsButton.AutoSize = true;
            AddArgsButton.Location = new System.Drawing.Point(3, 3);
            AddArgsButton.Name = "AddArgsButton";
            AddArgsButton.Size = new System.Drawing.Size(94, 30);
            AddArgsButton.TabIndex = 0;
            AddArgsButton.Text = "Add args";
            AddArgsButton.UseVisualStyleBackColor = true;
            AddArgsButton.Click += AddArgsButton_Click;
            // 
            // RemoveArgsButton
            // 
            RemoveArgsButton.AutoSize = true;
            RemoveArgsButton.Location = new System.Drawing.Point(103, 3);
            RemoveArgsButton.Name = "RemoveArgsButton";
            RemoveArgsButton.Size = new System.Drawing.Size(105, 30);
            RemoveArgsButton.TabIndex = 1;
            RemoveArgsButton.Text = "Remove args";
            RemoveArgsButton.UseVisualStyleBackColor = true;
            RemoveArgsButton.Click += RemoveArgsButton_Click;
            // 
            // SubStateButtonDataEditorForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(388, 392);
            Controls.Add(ButtonDataLayout);
            Controls.Add(OkButton);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "SubStateButtonDataEditorForm";
            Text = "SubStateButtonDataEditorForm";
            ButtonDataLayout.ResumeLayout(false);
            ButtonDataLayout.PerformLayout();
            LabelLayout.ResumeLayout(false);
            LabelLayout.PerformLayout();
            ArgsLayout.ResumeLayout(false);
            ButtonsLayout.ResumeLayout(false);
            ButtonsLayout.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ButtonDataLayout;
        private System.Windows.Forms.FlowLayoutPanel ArgsLayout;
        private System.Windows.Forms.Label ArgsLabel;
        private System.Windows.Forms.FlowLayoutPanel LabelLayout;
        private System.Windows.Forms.Label LabelLabel;
        private System.Windows.Forms.TextBox LabelTextBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.ListBox ArgumentsListBox;
        private System.Windows.Forms.FlowLayoutPanel ButtonsLayout;
        private System.Windows.Forms.Button AddArgsButton;
        private System.Windows.Forms.Button RemoveArgsButton;
    }
}