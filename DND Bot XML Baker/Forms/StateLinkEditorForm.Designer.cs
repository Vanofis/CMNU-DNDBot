namespace DND_Bot_XML_Baker.Forms
{
    partial class StateLinkEditorForm
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
            StateLinkLayout = new System.Windows.Forms.FlowLayoutPanel();
            TransitionIsAvailableCheckbox = new System.Windows.Forms.CheckBox();
            flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            StateLinkPathLabel = new System.Windows.Forms.Label();
            StateLinkPathTextBox = new System.Windows.Forms.TextBox();
            LinkPathBrowseButton = new System.Windows.Forms.Button();
            OkButton = new System.Windows.Forms.Button();
            StateLinkLayout.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // StateLinkLayout
            // 
            StateLinkLayout.AutoSize = true;
            StateLinkLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            StateLinkLayout.Controls.Add(TransitionIsAvailableCheckbox);
            StateLinkLayout.Controls.Add(flowLayoutPanel2);
            StateLinkLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            StateLinkLayout.Location = new System.Drawing.Point(12, 12);
            StateLinkLayout.Name = "StateLinkLayout";
            StateLinkLayout.Size = new System.Drawing.Size(481, 71);
            StateLinkLayout.TabIndex = 0;
            // 
            // TransitionIsAvailableCheckbox
            // 
            TransitionIsAvailableCheckbox.AutoSize = true;
            TransitionIsAvailableCheckbox.Location = new System.Drawing.Point(3, 3);
            TransitionIsAvailableCheckbox.Name = "TransitionIsAvailableCheckbox";
            TransitionIsAvailableCheckbox.Size = new System.Drawing.Size(173, 24);
            TransitionIsAvailableCheckbox.TabIndex = 1;
            TransitionIsAvailableCheckbox.Text = "Transition is available";
            TransitionIsAvailableCheckbox.UseVisualStyleBackColor = true;
            TransitionIsAvailableCheckbox.CheckedChanged += TransitionIsAvailableCheckbox_CheckedChanged;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(StateLinkPathLabel);
            flowLayoutPanel2.Controls.Add(StateLinkPathTextBox);
            flowLayoutPanel2.Controls.Add(LinkPathBrowseButton);
            flowLayoutPanel2.Location = new System.Drawing.Point(3, 33);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new System.Drawing.Size(475, 35);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // StateLinkPathLabel
            // 
            StateLinkPathLabel.AutoSize = true;
            StateLinkPathLabel.Location = new System.Drawing.Point(3, 3);
            StateLinkPathLabel.Margin = new System.Windows.Forms.Padding(3);
            StateLinkPathLabel.Name = "StateLinkPathLabel";
            StateLinkPathLabel.Size = new System.Drawing.Size(77, 20);
            StateLinkPathLabel.TabIndex = 0;
            StateLinkPathLabel.Text = "State path";
            // 
            // StateLinkPathTextBox
            // 
            StateLinkPathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            StateLinkPathTextBox.Location = new System.Drawing.Point(86, 3);
            StateLinkPathTextBox.Name = "StateLinkPathTextBox";
            StateLinkPathTextBox.ReadOnly = true;
            StateLinkPathTextBox.Size = new System.Drawing.Size(286, 27);
            StateLinkPathTextBox.TabIndex = 1;
            // 
            // LinkPathBrowseButton
            // 
            LinkPathBrowseButton.Location = new System.Drawing.Point(378, 3);
            LinkPathBrowseButton.Name = "LinkPathBrowseButton";
            LinkPathBrowseButton.Size = new System.Drawing.Size(94, 29);
            LinkPathBrowseButton.TabIndex = 2;
            LinkPathBrowseButton.Text = "Browse";
            LinkPathBrowseButton.UseVisualStyleBackColor = true;
            LinkPathBrowseButton.Click += LinkPathBrowseButton_Click;
            // 
            // OkButton
            // 
            OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            OkButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            OkButton.Location = new System.Drawing.Point(12, 89);
            OkButton.Name = "OkButton";
            OkButton.Size = new System.Drawing.Size(481, 45);
            OkButton.TabIndex = 1;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = true;
            // 
            // StateLinkEditorForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(503, 144);
            Controls.Add(OkButton);
            Controls.Add(StateLinkLayout);
            Name = "StateLinkEditorForm";
            Text = "StateLinkEditorForm";
            StateLinkLayout.ResumeLayout(false);
            StateLinkLayout.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel StateLinkLayout;
        private System.Windows.Forms.CheckBox TransitionIsAvailableCheckbox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label StateLinkPathLabel;
        private System.Windows.Forms.TextBox StateLinkPathTextBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button LinkPathBrowseButton;
    }
}