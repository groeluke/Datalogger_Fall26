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
            fileToolStripMenuItem = new ToolStripMenuItem();
            SettingsMenuItem = new ToolStripMenuItem();
            MainTimer = new System.Windows.Forms.Timer(components);
            ContextMenuStrip = new ContextMenuStrip(components);
            GraphPictureBox = new PictureBox();
            SampleRateComboBox = new ComboBox();
            MinuteRadioButton = new RadioButton();
            SecondRadioButton = new RadioButton();
            PortsComboBox = new ComboBox();
            ToolTip = new ToolTip(components);
            ButtonGroupBox = new GroupBox();
            RadioButtonGroupBox = new GroupBox();
            MillisecondRadioButton = new RadioButton();
            MainStatusStrip.SuspendLayout();
            TopMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GraphPictureBox).BeginInit();
            ButtonGroupBox.SuspendLayout();
            RadioButtonGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ComListBox
            // 
            ComListBox.FormattingEnabled = true;
            ComListBox.Location = new Point(399, 36);
            ComListBox.Name = "ComListBox";
            ComListBox.Size = new Size(389, 229);
            ComListBox.TabIndex = 0;
            ToolTip.SetToolTip(ComListBox, "Display the collected Data.");
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(298, 30);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(140, 62);
            SaveButton.TabIndex = 2;
            SaveButton.Text = "&Save";
            ToolTip.SetToolTip(SaveButton, "Save the Data collected.");
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
            ToolTip.SetToolTip(StopButton, "Stop Data logging.");
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
            ToolTip.SetToolTip(StartButton, "Start Data logging.");
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
            LogPathStatusLabel.Size = new Size(179, 25);
            LogPathStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // SampleRateStatusLabel
            // 
            SampleRateStatusLabel.Name = "SampleRateStatusLabel";
            SampleRateStatusLabel.Size = new Size(179, 25);
            SampleRateStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // ComPortsStatusLabel
            // 
            ComPortsStatusLabel.Name = "ComPortsStatusLabel";
            ComPortsStatusLabel.Size = new Size(179, 25);
            ComPortsStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // TopMenuStrip
            // 
            TopMenuStrip.ImageScalingSize = new Size(24, 24);
            TopMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            TopMenuStrip.Location = new Point(0, 0);
            TopMenuStrip.Name = "TopMenuStrip";
            TopMenuStrip.Size = new Size(800, 33);
            TopMenuStrip.TabIndex = 5;
            TopMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SettingsMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // SettingsMenuItem
            // 
            SettingsMenuItem.Name = "SettingsMenuItem";
            SettingsMenuItem.Size = new Size(178, 34);
            SettingsMenuItem.Text = "Settings";
            SettingsMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // ContextMenuStrip
            // 
            ContextMenuStrip.ImageScalingSize = new Size(24, 24);
            ContextMenuStrip.Name = "contextMenuStrip1";
            ContextMenuStrip.Size = new Size(61, 4);
            // 
            // GraphPictureBox
            // 
            GraphPictureBox.Location = new Point(12, 36);
            GraphPictureBox.Name = "GraphPictureBox";
            GraphPictureBox.Size = new Size(381, 229);
            GraphPictureBox.TabIndex = 6;
            GraphPictureBox.TabStop = false;
            ToolTip.SetToolTip(GraphPictureBox, "Display the graph of collected Data.");
            // 
            // SampleRateComboBox
            // 
            SampleRateComboBox.FormattingEnabled = true;
            SampleRateComboBox.Location = new Point(12, 271);
            SampleRateComboBox.Name = "SampleRateComboBox";
            SampleRateComboBox.Size = new Size(381, 33);
            SampleRateComboBox.TabIndex = 7;
            ToolTip.SetToolTip(SampleRateComboBox, "Sample Rate ");
            // 
            // MinuteRadioButton
            // 
            MinuteRadioButton.AutoSize = true;
            MinuteRadioButton.Location = new Point(6, 30);
            MinuteRadioButton.Name = "MinuteRadioButton";
            MinuteRadioButton.Size = new Size(112, 29);
            MinuteRadioButton.TabIndex = 0;
            MinuteRadioButton.TabStop = true;
            MinuteRadioButton.Text = "1 Minute ";
            ToolTip.SetToolTip(MinuteRadioButton, "1 Minute intervals for collecting.");
            MinuteRadioButton.UseVisualStyleBackColor = true;
            // 
            // SecondRadioButton
            // 
            SecondRadioButton.AutoSize = true;
            SecondRadioButton.Location = new Point(153, 30);
            SecondRadioButton.Name = "SecondRadioButton";
            SecondRadioButton.Size = new Size(111, 29);
            SecondRadioButton.TabIndex = 1;
            SecondRadioButton.TabStop = true;
            SecondRadioButton.Text = "1 Second";
            ToolTip.SetToolTip(SecondRadioButton, "1 Second intervals for collecting.");
            SecondRadioButton.UseVisualStyleBackColor = true;
            // 
            // PortsComboBox
            // 
            PortsComboBox.FormattingEnabled = true;
            PortsComboBox.Location = new Point(399, 271);
            PortsComboBox.Name = "PortsComboBox";
            PortsComboBox.Size = new Size(389, 33);
            PortsComboBox.TabIndex = 0;
            ToolTip.SetToolTip(PortsComboBox, "Pick the correct Port to connect to.");
            // 
            // ButtonGroupBox
            // 
            ButtonGroupBox.Controls.Add(StartButton);
            ButtonGroupBox.Controls.Add(StopButton);
            ButtonGroupBox.Controls.Add(SaveButton);
            ButtonGroupBox.Location = new Point(356, 310);
            ButtonGroupBox.Name = "ButtonGroupBox";
            ButtonGroupBox.Size = new Size(444, 98);
            ButtonGroupBox.TabIndex = 1;
            ButtonGroupBox.TabStop = false;
            ButtonGroupBox.Text = "Controls";
            ToolTip.SetToolTip(ButtonGroupBox, "Select the controls for the Data logging.");
            // 
            // RadioButtonGroupBox
            // 
            RadioButtonGroupBox.Controls.Add(MillisecondRadioButton);
            RadioButtonGroupBox.Controls.Add(MinuteRadioButton);
            RadioButtonGroupBox.Controls.Add(SecondRadioButton);
            RadioButtonGroupBox.Location = new Point(12, 310);
            RadioButtonGroupBox.Name = "RadioButtonGroupBox";
            RadioButtonGroupBox.Size = new Size(338, 98);
            RadioButtonGroupBox.TabIndex = 2;
            RadioButtonGroupBox.TabStop = false;
            RadioButtonGroupBox.Text = "Sampling Intervals";
            ToolTip.SetToolTip(RadioButtonGroupBox, "Sample rate intervals for collecting Analog Data.");
            // 
            // MillisecondRadioButton
            // 
            MillisecondRadioButton.AutoSize = true;
            MillisecondRadioButton.Location = new Point(6, 63);
            MillisecondRadioButton.Name = "MillisecondRadioButton";
            MillisecondRadioButton.Size = new Size(161, 29);
            MillisecondRadioButton.TabIndex = 2;
            MillisecondRadioButton.TabStop = true;
            MillisecondRadioButton.Text = "100 Millisecond";
            ToolTip.SetToolTip(MillisecondRadioButton, "100 Millisecond intervals for collecting.");
            MillisecondRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RadioButtonGroupBox);
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
            ((System.ComponentModel.ISupportInitialize)GraphPictureBox).EndInit();
            ButtonGroupBox.ResumeLayout(false);
            RadioButtonGroupBox.ResumeLayout(false);
            RadioButtonGroupBox.PerformLayout();
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
        private ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Timer MainTimer;
        private ContextMenuStrip ContextMenuStrip;
        private ToolStripMenuItem SettingsMenuItem;
        private PictureBox GraphPictureBox;
        private ComboBox SampleRateComboBox;
        private RadioButton MinuteRadioButton;
        private RadioButton SecondRadioButton;
        private ComboBox PortsComboBox;
        private ToolTip ToolTip;
        private GroupBox ButtonGroupBox;
        private GroupBox RadioButtonGroupBox;
        private RadioButton MillisecondRadioButton;
    }
}
