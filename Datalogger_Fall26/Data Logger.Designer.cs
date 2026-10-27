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
            MainMenuStrip = new MenuStrip();
            MainTimer = new System.Windows.Forms.Timer(components);
            fileToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            MainStatusStrip.SuspendLayout();
            MainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // ComListBox
            // 
            ComListBox.FormattingEnabled = true;
            ComListBox.Location = new Point(168, 36);
            ComListBox.Name = "ComListBox";
            ComListBox.Size = new Size(620, 254);
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
            // 
            // StopButton
            // 
            StopButton.Location = new Point(502, 354);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(140, 62);
            StopButton.TabIndex = 2;
            StopButton.Text = "S&top";
            StopButton.UseVisualStyleBackColor = true;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(356, 354);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(140, 62);
            StartButton.TabIndex = 3;
            StartButton.Text = "St&art";
            StartButton.UseVisualStyleBackColor = true;
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
            // MainMenuStrip
            // 
            MainMenuStrip.ImageScalingSize = new Size(24, 24);
            MainMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            MainMenuStrip.Location = new Point(0, 0);
            MainMenuStrip.Name = "MainMenuStrip";
            MainMenuStrip.Size = new Size(800, 33);
            MainMenuStrip.TabIndex = 5;
            MainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainStatusStrip);
            Controls.Add(MainMenuStrip);
            Controls.Add(StartButton);
            Controls.Add(StopButton);
            Controls.Add(SaveButton);
            Controls.Add(ComListBox);
            MainMenuStrip = MainMenuStrip;
            Name = "Form1";
            Text = "Form1";
            MainStatusStrip.ResumeLayout(false);
            MainStatusStrip.PerformLayout();
            MainMenuStrip.ResumeLayout(false);
            MainMenuStrip.PerformLayout();
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
        private MenuStrip MainMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Timer MainTimer;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
    }
}
