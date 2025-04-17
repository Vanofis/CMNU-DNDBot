namespace DND_Bot_XML_Baker.Forms
{
    partial class SubStateButtonArgsEditorForm
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
            ButtonArgsLayout = new System.Windows.Forms.FlowLayoutPanel();
            ActionTypeLayout = new System.Windows.Forms.FlowLayoutPanel();
            ActionTypeLabel = new System.Windows.Forms.Label();
            ActionTypeComboBox = new System.Windows.Forms.ComboBox();
            ArgsLayout = new System.Windows.Forms.FlowLayoutPanel();
            ArgsLabel = new System.Windows.Forms.Label();
            ArgsTextBox = new System.Windows.Forms.TextBox();
            OkButton = new System.Windows.Forms.Button();
            ButtonArgsLayout.SuspendLayout();
            ActionTypeLayout.SuspendLayout();
            ArgsLayout.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonArgsLayout
            // 
            ButtonArgsLayout.AutoSize = true;
            ButtonArgsLayout.Controls.Add(ActionTypeLayout);
            ButtonArgsLayout.Controls.Add(ArgsLayout);
            ButtonArgsLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            ButtonArgsLayout.Location = new System.Drawing.Point(12, 12);
            ButtonArgsLayout.Name = "ButtonArgsLayout";
            ButtonArgsLayout.Size = new System.Drawing.Size(500, 104);
            ButtonArgsLayout.TabIndex = 0;
            // 
            // ActionTypeLayout
            // 
            ActionTypeLayout.AutoSize = true;
            ActionTypeLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            ActionTypeLayout.Controls.Add(ActionTypeLabel);
            ActionTypeLayout.Controls.Add(ActionTypeComboBox);
            ActionTypeLayout.Location = new System.Drawing.Point(3, 5);
            ActionTypeLayout.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            ActionTypeLayout.Name = "ActionTypeLayout";
            ActionTypeLayout.Size = new System.Drawing.Size(375, 43);
            ActionTypeLayout.TabIndex = 0;
            // 
            // ActionTypeLabel
            // 
            ActionTypeLabel.Location = new System.Drawing.Point(0, 0);
            ActionTypeLabel.Margin = new System.Windows.Forms.Padding(0);
            ActionTypeLabel.Name = "ActionTypeLabel";
            ActionTypeLabel.Size = new System.Drawing.Size(99, 31);
            ActionTypeLabel.TabIndex = 0;
            ActionTypeLabel.Text = "Action type";
            ActionTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ActionTypeComboBox
            // 
            ActionTypeComboBox.FormattingEnabled = true;
            ActionTypeComboBox.Location = new System.Drawing.Point(102, 3);
            ActionTypeComboBox.Name = "ActionTypeComboBox";
            ActionTypeComboBox.Size = new System.Drawing.Size(268, 28);
            ActionTypeComboBox.TabIndex = 1;
            ActionTypeComboBox.SelectedIndexChanged += ActionTypeComboBox_SelectedIndexChanged;
            // 
            // ArgsLayout
            // 
            ArgsLayout.AutoSize = true;
            ArgsLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            ArgsLayout.Controls.Add(ArgsLabel);
            ArgsLayout.Controls.Add(ArgsTextBox);
            ArgsLayout.Location = new System.Drawing.Point(3, 56);
            ArgsLayout.Name = "ArgsLayout";
            ArgsLayout.Size = new System.Drawing.Size(494, 35);
            ArgsLayout.TabIndex = 1;
            // 
            // ArgsLabel
            // 
            ArgsLabel.Location = new System.Drawing.Point(3, 0);
            ArgsLabel.Name = "ArgsLabel";
            ArgsLabel.Size = new System.Drawing.Size(158, 30);
            ArgsLabel.TabIndex = 0;
            ArgsLabel.Text = "Args (Separated by ',')";
            ArgsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ArgsTextBox
            // 
            ArgsTextBox.Location = new System.Drawing.Point(167, 3);
            ArgsTextBox.Name = "ArgsTextBox";
            ArgsTextBox.Size = new System.Drawing.Size(322, 27);
            ArgsTextBox.TabIndex = 1;
            ArgsTextBox.TextChanged += ArgsTextBox_TextChanged;
            // 
            // OkButton
            // 
            OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            OkButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            OkButton.Location = new System.Drawing.Point(12, 122);
            OkButton.Name = "OkButton";
            OkButton.Size = new System.Drawing.Size(500, 45);
            OkButton.TabIndex = 1;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = true;
            // 
            // SubStateButtonArgsEditorForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(523, 179);
            Controls.Add(OkButton);
            Controls.Add(ButtonArgsLayout);
            Name = "SubStateButtonArgsEditorForm";
            Text = "SubStateButtonArgsEditorForm";
            ButtonArgsLayout.ResumeLayout(false);
            ButtonArgsLayout.PerformLayout();
            ActionTypeLayout.ResumeLayout(false);
            ArgsLayout.ResumeLayout(false);
            ArgsLayout.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ButtonArgsLayout;
        private System.Windows.Forms.FlowLayoutPanel ActionTypeLayout;
        private System.Windows.Forms.Label ActionTypeLabel;
        private System.Windows.Forms.ComboBox ActionTypeComboBox;
        private System.Windows.Forms.FlowLayoutPanel ArgsLayout;
        private System.Windows.Forms.Label ArgsLabel;
        private System.Windows.Forms.TextBox ArgsTextBox;
        private System.Windows.Forms.Button OkButton;
    }
}