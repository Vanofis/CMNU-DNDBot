using System.ComponentModel;

namespace DND_Bot_XML_Baker;

partial class SubStateDivsEditorForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        ImagePathLayout = new System.Windows.Forms.FlowLayoutPanel();
        ImagePathLabel = new System.Windows.Forms.Label();
        ImagePathTextBox = new System.Windows.Forms.TextBox();
        ImagePathBrowseButton = new System.Windows.Forms.Button();
        MessageLayout = new System.Windows.Forms.FlowLayoutPanel();
        MessageLabel = new System.Windows.Forms.Label();
        MessageTextBox = new System.Windows.Forms.TextBox();
        ButtonsLayout = new System.Windows.Forms.FlowLayoutPanel();
        ButtonsLabel = new System.Windows.Forms.Label();
        ButtonDivsListBox = new System.Windows.Forms.ListBox();
        ButtonsListButtons = new System.Windows.Forms.FlowLayoutPanel();
        AddButtonsDivButton = new System.Windows.Forms.Button();
        RemoveButtonsDivButton = new System.Windows.Forms.Button();
        OkButton = new System.Windows.Forms.Button();
        ImagePathLayout.SuspendLayout();
        MessageLayout.SuspendLayout();
        ButtonsLayout.SuspendLayout();
        ButtonsListButtons.SuspendLayout();
        SuspendLayout();
        // 
        // ImagePathLayout
        // 
        ImagePathLayout.AutoSize = true;
        ImagePathLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        ImagePathLayout.Controls.Add(ImagePathLabel);
        ImagePathLayout.Controls.Add(ImagePathTextBox);
        ImagePathLayout.Controls.Add(ImagePathBrowseButton);
        ImagePathLayout.Location = new System.Drawing.Point(14, 16);
        ImagePathLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        ImagePathLayout.Name = "ImagePathLayout";
        ImagePathLayout.Size = new System.Drawing.Size(539, 45);
        ImagePathLayout.TabIndex = 0;
        // 
        // ImagePathLabel
        // 
        ImagePathLabel.Location = new System.Drawing.Point(0, 0);
        ImagePathLabel.Margin = new System.Windows.Forms.Padding(0);
        ImagePathLabel.Name = "ImagePathLabel";
        ImagePathLabel.Size = new System.Drawing.Size(77, 35);
        ImagePathLabel.TabIndex = 0;
        ImagePathLabel.Text = "Image Path";
        ImagePathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // ImagePathTextBox
        // 
        ImagePathTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
        ImagePathTextBox.Location = new System.Drawing.Point(80, 4);
        ImagePathTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        ImagePathTextBox.Name = "ImagePathTextBox";
        ImagePathTextBox.ReadOnly = true;
        ImagePathTextBox.Size = new System.Drawing.Size(358, 27);
        ImagePathTextBox.TabIndex = 1;
        ImagePathTextBox.TextChanged += ImagePathTextBox_TextChanged;
        // 
        // ImagePathBrowseButton
        // 
        ImagePathBrowseButton.Location = new System.Drawing.Point(444, 4);
        ImagePathBrowseButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        ImagePathBrowseButton.Name = "ImagePathBrowseButton";
        ImagePathBrowseButton.Size = new System.Drawing.Size(86, 31);
        ImagePathBrowseButton.TabIndex = 2;
        ImagePathBrowseButton.Text = "Browse";
        ImagePathBrowseButton.UseVisualStyleBackColor = true;
        ImagePathBrowseButton.Click += ImagePathBrowseButton_Click;
        // 
        // MessageLayout
        // 
        MessageLayout.AutoSize = true;
        MessageLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        MessageLayout.Controls.Add(MessageLabel);
        MessageLayout.Controls.Add(MessageTextBox);
        MessageLayout.Location = new System.Drawing.Point(14, 69);
        MessageLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        MessageLayout.Name = "MessageLayout";
        MessageLayout.Size = new System.Drawing.Size(539, 150);
        MessageLayout.TabIndex = 1;
        // 
        // MessageLabel
        // 
        MessageLabel.Location = new System.Drawing.Point(0, 0);
        MessageLabel.Margin = new System.Windows.Forms.Padding(0);
        MessageLabel.Name = "MessageLabel";
        MessageLabel.Size = new System.Drawing.Size(77, 31);
        MessageLabel.TabIndex = 0;
        MessageLabel.Text = "Message";
        MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // MessageTextBox
        // 
        MessageTextBox.AcceptsReturn = true;
        MessageTextBox.AcceptsTab = true;
        MessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        MessageTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
        MessageTextBox.Location = new System.Drawing.Point(80, 7);
        MessageTextBox.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
        MessageTextBox.Multiline = true;
        MessageTextBox.Name = "MessageTextBox";
        MessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        MessageTextBox.Size = new System.Drawing.Size(453, 127);
        MessageTextBox.TabIndex = 1;
        MessageTextBox.TextChanged += MessageTextBox_TextChanged;
        // 
        // ButtonsLayout
        // 
        ButtonsLayout.AutoSize = true;
        ButtonsLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        ButtonsLayout.Controls.Add(ButtonsLabel);
        ButtonsLayout.Controls.Add(ButtonDivsListBox);
        ButtonsLayout.Controls.Add(ButtonsListButtons);
        ButtonsLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
        ButtonsLayout.Location = new System.Drawing.Point(15, 228);
        ButtonsLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        ButtonsLayout.Name = "ButtonsLayout";
        ButtonsLayout.Size = new System.Drawing.Size(540, 227);
        ButtonsLayout.TabIndex = 2;
        // 
        // ButtonsLabel
        // 
        ButtonsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
        ButtonsLabel.Location = new System.Drawing.Point(0, 0);
        ButtonsLabel.Margin = new System.Windows.Forms.Padding(0);
        ButtonsLabel.Name = "ButtonsLabel";
        ButtonsLabel.Size = new System.Drawing.Size(538, 31);
        ButtonsLabel.TabIndex = 0;
        ButtonsLabel.Text = "Button divs";
        ButtonsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // ButtonDivsListBox
        // 
        ButtonDivsListBox.FormattingEnabled = true;
        ButtonDivsListBox.Location = new System.Drawing.Point(3, 38);
        ButtonDivsListBox.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
        ButtonDivsListBox.Name = "ButtonDivsListBox";
        ButtonDivsListBox.Size = new System.Drawing.Size(526, 124);
        ButtonDivsListBox.TabIndex = 1;
        ButtonDivsListBox.DoubleClick += ButtonsListBox_DoubleClick;
        // 
        // ButtonsListButtons
        // 
        ButtonsListButtons.AutoSize = true;
        ButtonsListButtons.Controls.Add(AddButtonsDivButton);
        ButtonsListButtons.Controls.Add(RemoveButtonsDivButton);
        ButtonsListButtons.Location = new System.Drawing.Point(3, 173);
        ButtonsListButtons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        ButtonsListButtons.Name = "ButtonsListButtons";
        ButtonsListButtons.Size = new System.Drawing.Size(328, 48);
        ButtonsListButtons.TabIndex = 2;
        // 
        // AddButtonsDivButton
        // 
        AddButtonsDivButton.AutoSize = true;
        AddButtonsDivButton.BackColor = System.Drawing.SystemColors.ControlDark;
        AddButtonsDivButton.Location = new System.Drawing.Point(3, 4);
        AddButtonsDivButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        AddButtonsDivButton.Name = "AddButtonsDivButton";
        AddButtonsDivButton.Size = new System.Drawing.Size(143, 40);
        AddButtonsDivButton.TabIndex = 0;
        AddButtonsDivButton.Text = "Add buttons div";
        AddButtonsDivButton.UseVisualStyleBackColor = false;
        AddButtonsDivButton.Click += AddButtonButton_Click;
        // 
        // RemoveButtonsDivButton
        // 
        RemoveButtonsDivButton.AutoSize = true;
        RemoveButtonsDivButton.Location = new System.Drawing.Point(152, 4);
        RemoveButtonsDivButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        RemoveButtonsDivButton.Name = "RemoveButtonsDivButton";
        RemoveButtonsDivButton.Size = new System.Drawing.Size(173, 40);
        RemoveButtonsDivButton.TabIndex = 1;
        RemoveButtonsDivButton.Text = "Remove buttons div";
        RemoveButtonsDivButton.UseVisualStyleBackColor = true;
        RemoveButtonsDivButton.Click += RemoveButtonButton_Click;
        // 
        // OkButton
        // 
        OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
        OkButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
        OkButton.Location = new System.Drawing.Point(15, 461);
        OkButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        OkButton.Name = "OkButton";
        OkButton.Size = new System.Drawing.Size(543, 60);
        OkButton.TabIndex = 3;
        OkButton.Text = "OK";
        OkButton.UseVisualStyleBackColor = true;
        // 
        // SubStateDivsEditorForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(574, 540);
        Controls.Add(OkButton);
        Controls.Add(ButtonsLayout);
        Controls.Add(MessageLayout);
        Controls.Add(ImagePathLayout);
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        Name = "SubStateDivsEditorForm";
        Text = "SubStateDivsEditorForm";
        ImagePathLayout.ResumeLayout(false);
        ImagePathLayout.PerformLayout();
        MessageLayout.ResumeLayout(false);
        MessageLayout.PerformLayout();
        ButtonsLayout.ResumeLayout(false);
        ButtonsLayout.PerformLayout();
        ButtonsListButtons.ResumeLayout(false);
        ButtonsListButtons.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.FlowLayoutPanel ImagePathLayout;
    private System.Windows.Forms.Label ImagePathLabel;
    private System.Windows.Forms.TextBox ImagePathTextBox;
    private System.Windows.Forms.Button ImagePathBrowseButton;
    private System.Windows.Forms.FlowLayoutPanel MessageLayout;
    private System.Windows.Forms.Label MessageLabel;
    private System.Windows.Forms.TextBox MessageTextBox;
    private System.Windows.Forms.FlowLayoutPanel ButtonsLayout;
    private System.Windows.Forms.Label ButtonsLabel;
    private System.Windows.Forms.ListBox ButtonDivsListBox;
    private System.Windows.Forms.FlowLayoutPanel ButtonsListButtons;
    private System.Windows.Forms.Button AddButtonsDivButton;
    private System.Windows.Forms.Button RemoveButtonsDivButton;
    private System.Windows.Forms.Button OkButton;
}