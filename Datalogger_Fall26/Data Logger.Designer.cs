namespace Datalogger_Fall26
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ComListBox = new ListBox();
            SaveButton = new Button();
            StopButton = new Button();
            StartButton = new Button();
            MainStatusStrip = new StatusStrip();
            LogPathStatusLabel = new ToolStripStatusLabel();
            SampleRateStatusLabel = new ToolStripStatusLabel();
            ComPortsStatusLabel = new ToolStripStatusLabel();
            TopMenuStrip = new MenuStrip();
            FileMenuItem = new ToolStripMenuItem();
            SettingsMenuItem = new ToolStripMenuItem();
            ExitMenuItem = new ToolStripMenuItem();
            MainTimer = new System.Windows.Forms.Timer(components);
            GraphContextMenuStrip = new ContextMenuStrip(components);
            StartContextMenuItem = new ToolStripMenuItem();
            StopContextMenuItem = new ToolStripMenuItem();
            SaveContextMenuItem = new ToolStripMenuItem();
            GraphPictureBox = new PictureBox();
            SampleRateComboBox = new ComboBox();
            PortsComboBox = new ComboBox();
            MainToolTip = new ToolTip(components);
            ButtonGroupBox = new GroupBox();
            HistoryComboBox = new ComboBox();
            SelectPortLabel = new Label();
            SampleRateLabel = new Label();
            HistorySelectLabel = new Label();
            MainStatusStrip.SuspendLayout();
            TopMenuStrip.SuspendLayout();
            GraphContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GraphPictureBox).BeginInit();
            ButtonGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ComListBox
            // 
            ComListBox.FormattingEnabled = true;
            ComListBox.Location = new Point(6, 36);
            ComListBox.Name = "ComListBox";
            ComListBox.Size = new Size(344, 254);
            ComListBox.TabIndex = 4;
            MainToolTip.SetToolTip(ComListBox, "Display the collected Data.");
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(298, 30);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(140, 62);
            SaveButton.TabIndex = 2;
            SaveButton.Text = "&Save";
            MainToolTip.SetToolTip(SaveButton, "Save the Data collected.");
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // StopButton
            // 
            StopButton.Location = new Point(152, 30);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(140, 62);
            StopButton.TabIndex = 1;
            StopButton.Text = "S&top";
            MainToolTip.SetToolTip(StopButton, "Stop Data logging.");
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(6, 30);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(140, 62);
            StartButton.TabIndex = 0;
            StartButton.Text = "St&art";
            MainToolTip.SetToolTip(StartButton, "Start Data logging.");
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // MainStatusStrip
            // 
            MainStatusStrip.ImageScalingSize = new Size(24, 24);
            MainStatusStrip.Items.AddRange(new ToolStripItem[] { LogPathStatusLabel, SampleRateStatusLabel, ComPortsStatusLabel });
            MainStatusStrip.Location = new Point(0, 418);
            MainStatusStrip.Name = "MainStatusStrip";
            MainStatusStrip.Size = new Size(800, 32);
            MainStatusStrip.TabIndex = 4;
            MainStatusStrip.Text = "statusStrip1";
            // 
            // LogPathStatusLabel
            // 
            LogPathStatusLabel.Name = "LogPathStatusLabel";
            LogPathStatusLabel.Size = new Size(94, 25);
            LogPathStatusLabel.Text = "Log: None";
            // 
            // SampleRateStatusLabel
            // 
            SampleRateStatusLabel.Name = "SampleRateStatusLabel";
            SampleRateStatusLabel.Size = new Size(77, 25);
            SampleRateStatusLabel.Text = "Rate: ---";
            // 
            // ComPortsStatusLabel
            // 
            ComPortsStatusLabel.Name = "ComPortsStatusLabel";
            ComPortsStatusLabel.Size = new Size(176, 25);
            ComPortsStatusLabel.Text = "COM: not connected";
            // 
            // TopMenuStrip
            // 
            TopMenuStrip.ImageScalingSize = new Size(24, 24);
            TopMenuStrip.Items.AddRange(new ToolStripItem[] { FileMenuItem });
            TopMenuStrip.Location = new Point(0, 0);
            TopMenuStrip.Name = "TopMenuStrip";
            TopMenuStrip.Size = new Size(800, 33);
            TopMenuStrip.TabIndex = 5;
            TopMenuStrip.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            FileMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SettingsMenuItem, ExitMenuItem });
            FileMenuItem.Name = "FileMenuItem";
            FileMenuItem.Size = new Size(54, 29);
            FileMenuItem.Text = "File";
            // 
            // SettingsMenuItem
            // 
            SettingsMenuItem.Name = "SettingsMenuItem";
            SettingsMenuItem.Size = new Size(270, 34);
            SettingsMenuItem.Text = "Settings";
            SettingsMenuItem.Click += SettingsMenuItem_Click;
            // 
            // ExitMenuItem
            // 
            ExitMenuItem.Name = "ExitMenuItem";
            ExitMenuItem.Size = new Size(270, 34);
            ExitMenuItem.Text = "Exit";
            ExitMenuItem.Click += ExitMenuItem_Click;
            // 
            // GraphContextMenuStrip
            // 
            GraphContextMenuStrip.ImageScalingSize = new Size(24, 24);
            GraphContextMenuStrip.Items.AddRange(new ToolStripItem[] { StartContextMenuItem, StopContextMenuItem, SaveContextMenuItem });
            GraphContextMenuStrip.Name = "contextMenuStrip1";
            GraphContextMenuStrip.Size = new Size(122, 100);
            // 
            // StartContextMenuItem
            // 
            StartContextMenuItem.Name = "StartContextMenuItem";
            StartContextMenuItem.Size = new Size(240, 32);
            StartContextMenuItem.Text = "Start";
            StartContextMenuItem.Click += StartContextMenuItem_Click;
            // 
            // StopContextMenuItem
            // 
            StopContextMenuItem.Name = "StopContextMenuItem";
            StopContextMenuItem.Size = new Size(240, 32);
            StopContextMenuItem.Text = "Stop";
            StopContextMenuItem.Click += StopContextMenuItem_Click;
            // 
            // SaveContextMenuItem
            // 
            SaveContextMenuItem.Name = "SaveContextMenuItem";
            SaveContextMenuItem.Size = new Size(240, 32);
            SaveContextMenuItem.Text = "Save";
            SaveContextMenuItem.Click += SaveContextMenuItem_Click;
            // 
            // GraphPictureBox
            // 
            GraphPictureBox.Location = new Point(362, 36);
            GraphPictureBox.Name = "GraphPictureBox";
            GraphPictureBox.Size = new Size(432, 268);
            GraphPictureBox.TabIndex = 6;
            GraphPictureBox.TabStop = false;
            MainToolTip.SetToolTip(GraphPictureBox, "Display the graph of collected Data.");
            // 
            // SampleRateComboBox
            // 
            SampleRateComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SampleRateComboBox.FormattingEnabled = true;
            SampleRateComboBox.Location = new Point(6, 335);
            SampleRateComboBox.Name = "SampleRateComboBox";
            SampleRateComboBox.Size = new Size(170, 33);
            SampleRateComboBox.TabIndex = 1;
            MainToolTip.SetToolTip(SampleRateComboBox, "Sample Rate to select on how much Data is collected.");
            SampleRateComboBox.SelectedIndexChanged += SampleRateComboBox_SelectedIndexChanged;
            // 
            // PortsComboBox
            // 
            PortsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PortsComboBox.FormattingEnabled = true;
            PortsComboBox.Location = new Point(7, 296);
            PortsComboBox.Name = "PortsComboBox";
            PortsComboBox.Size = new Size(169, 33);
            PortsComboBox.TabIndex = 0;
            MainToolTip.SetToolTip(PortsComboBox, "Pick the correct Port to connect to.");
            // 
            // ButtonGroupBox
            // 
            ButtonGroupBox.Controls.Add(StartButton);
            ButtonGroupBox.Controls.Add(StopButton);
            ButtonGroupBox.Controls.Add(SaveButton);
            ButtonGroupBox.Location = new Point(356, 310);
            ButtonGroupBox.Name = "ButtonGroupBox";
            ButtonGroupBox.Size = new Size(444, 98);
            ButtonGroupBox.TabIndex = 2;
            ButtonGroupBox.TabStop = false;
            ButtonGroupBox.Text = "Controls";
            MainToolTip.SetToolTip(ButtonGroupBox, "Select the controls for the Data logging.");
            // 
            // HistoryComboBox
            // 
            HistoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            HistoryComboBox.FormattingEnabled = true;
            HistoryComboBox.Location = new Point(6, 375);
            HistoryComboBox.Name = "HistoryComboBox";
            HistoryComboBox.Size = new Size(170, 33);
            HistoryComboBox.TabIndex = 3;
            MainToolTip.SetToolTip(HistoryComboBox, "Choose how much of the data the graph shows.");
            HistoryComboBox.SelectedIndexChanged += HistoryComboBox_SelectedIndexChanged;
            // 
            // SelectPortLabel
            // 
            SelectPortLabel.AutoSize = true;
            SelectPortLabel.Location = new Point(182, 299);
            SelectPortLabel.Name = "SelectPortLabel";
            SelectPortLabel.Size = new Size(109, 25);
            SelectPortLabel.TabIndex = 7;
            SelectPortLabel.Text = "Select a Port";
            // 
            // SampleRateLabel
            // 
            SampleRateLabel.AutoSize = true;
            SampleRateLabel.Location = new Point(182, 343);
            SampleRateLabel.Name = "SampleRateLabel";
            SampleRateLabel.Size = new Size(162, 25);
            SampleRateLabel.TabIndex = 8;
            SampleRateLabel.Text = "Select Sample Rate";
            // 
            // HistorySelectLabel
            // 
            HistorySelectLabel.AutoSize = true;
            HistorySelectLabel.Location = new Point(182, 383);
            HistorySelectLabel.Name = "HistorySelectLabel";
            HistorySelectLabel.Size = new Size(151, 25);
            HistorySelectLabel.TabIndex = 9;
            HistorySelectLabel.Text = "Select History File";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(HistorySelectLabel);
            Controls.Add(SampleRateLabel);
            Controls.Add(SelectPortLabel);
            Controls.Add(HistoryComboBox);
            Controls.Add(ButtonGroupBox);
            Controls.Add(PortsComboBox);
            Controls.Add(SampleRateComboBox);
            Controls.Add(GraphPictureBox);
            Controls.Add(MainStatusStrip);
            Controls.Add(TopMenuStrip);
            Controls.Add(ComListBox);
            Name = "Form1";
            Text = "Form1";
            MainStatusStrip.ResumeLayout(false);
            MainStatusStrip.PerformLayout();
            TopMenuStrip.ResumeLayout(false);
            TopMenuStrip.PerformLayout();
            GraphContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GraphPictureBox).EndInit();
            ButtonGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ComListBox;
        private Button SaveButton;
        private Button StopButton;
        private Button StartButton;
        private StatusStrip MainStatusStrip;
        private ToolStripStatusLabel LogPathStatusLabel;
        private ToolStripStatusLabel SampleRateStatusLabel;
        private ToolStripStatusLabel ComPortsStatusLabel;
        private MenuStrip TopMenuStrip;
        private ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.Timer MainTimer;
        private ContextMenuStrip GraphContextMenuStrip;
        private ToolStripMenuItem SettingsMenuItem;
        private PictureBox GraphPictureBox;
        private ComboBox SampleRateComboBox;
        private ComboBox PortsComboBox;
        private ToolTip MainToolTip;
        private GroupBox ButtonGroupBox;
        private ComboBox HistoryComboBox;
        private Label SelectPortLabel;
        private Label SampleRateLabel;
        private Label HistorySelectLabel;
        private ToolStripMenuItem ExitMenuItem;
        private ToolStripMenuItem StartContextMenuItem;
        private ToolStripMenuItem StopContextMenuItem;
        private ToolStripMenuItem SaveContextMenuItem;
    }
}

