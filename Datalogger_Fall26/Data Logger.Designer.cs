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
            MainTimer = new System.Windows.Forms.Timer(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            settingsToolStripMenuItem = new ToolStripMenuItem();
            GraphPictureBox = new PictureBox();
            comboBox1 = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            comboBox2 = new ComboBox();
            MainStatusStrip.SuspendLayout();
            TopMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GraphPictureBox).BeginInit();
            SuspendLayout();
            // 
            // ComListBox
            // 
            ComListBox.FormattingEnabled = true;
            ComListBox.Location = new Point(399, 36);
            ComListBox.Name = "ComListBox";
            ComListBox.Size = new Size(389, 254);
            ComListBox.TabIndex = 0;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(648, 354);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(140, 62);
            SaveButton.TabIndex = 1;
            SaveButton.Text = "&Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // StopButton
            // 
            StopButton.Location = new Point(502, 354);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(140, 62);
            StopButton.TabIndex = 2;
            StopButton.Text = "S&top";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(356, 354);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(140, 62);
            StartButton.TabIndex = 3;
            StartButton.Text = "St&art";
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
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { settingsToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(24, 24);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(270, 34);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // GraphPictureBox
            // 
            GraphPictureBox.Location = new Point(12, 36);
            GraphPictureBox.Name = "GraphPictureBox";
            GraphPictureBox.Size = new Size(381, 254);
            GraphPictureBox.TabIndex = 6;
            GraphPictureBox.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 296);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(381, 33);
            comboBox1.TabIndex = 7;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(22, 375);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(141, 29);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(169, 375);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(141, 29);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(399, 296);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(389, 33);
            comboBox2.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox2);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(comboBox1);
            Controls.Add(GraphPictureBox);
            Controls.Add(MainStatusStrip);
            Controls.Add(TopMenuStrip);
            Controls.Add(StartButton);
            Controls.Add(StopButton);
            Controls.Add(SaveButton);
            Controls.Add(ComListBox);
            Name = "Form1";
            Text = "Form1";
            MainStatusStrip.ResumeLayout(false);
            MainStatusStrip.PerformLayout();
            TopMenuStrip.ResumeLayout(false);
            TopMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GraphPictureBox).EndInit();
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
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private PictureBox GraphPictureBox;
        private ComboBox comboBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private ComboBox comboBox2;
    }
}
