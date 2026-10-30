using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;

/*Luke Groesbeck
*Fall 2026
*RCET 3371
*DartGame
*Advanced Programming Techniques & GUI Development
*https://github.com/groeluke/Datalogger_Fall26.git
*/
namespace Datalogger_Fall26
{
    public partial class Form1 : Form
    {
        // fields
        SerialPort serialPort = new SerialPort();
        List<byte> rxBuffer = new List<byte>();
        bool picFound = false;
        string verifiedPort = "";
        bool waiting = false;
        DateTime replyDeadline;
        DateTime nextSearchTime = DateTime.Now;

        List<(int adc, DateTime time)> samples = new List<(int, DateTime)>();
        bool isSampling = false;
        string currentLogPath = "";
        const int MAX_SAMPLES = 2000;

        public Form1()
        {
            InitializeComponent();
            SetupForm();
        }
        
        void SetupForm()
        {
            SampleRateComboBox.Items.Add(new object[]
            {
                "10 minutes", "5 Minutes", "1 Minute", "30 Senconds",
                "10 Seconds", "5 Seconds", "1 Seconds", "500 ms",
                "200 ms", "100 ms"
            }); // add all the times for that Sample rate for data

            SampleRateComboBox.SelectedIndex = 6;  // 1 second

            HistoryComboBox.Items.Add(new object[]
            {
                "Full History", "Last 30 Seconds"
            });

            HistoryComboBox.SelectedIndex = 0;

            // picture box
            GraphPictureBox.BackColor = Color.White;
            GraphPictureBox.BorderStyle = BorderStyle.FixedSingle;
            GraphPictureBox.Paint += GraphPictureBox_Paint;
            GraphPictureBox.ContextMenuStrip = GraphContextMenuStrip;

            // timer
            MainTimer.Interval = 200;          // checks connection often
            MainTimer.Tick += MainTimer_Tick;
            MainTimer.Start();

            UpdateStatusBar();
        }

        //  STATUS + LOG
        void UpdateStatusBar()
        {
            LogPathStatusLabel.Text = string.IsNullOrEmpty(currentLogPath)
                ? "Log: None"
                : "Log: " + Path.GetFileName(currentLogPath);

            SampleRateStatusLabel.Text = "Rate: " +
                (SampleRateComboBox.SelectedItem?.ToString() ?? "---");

            ComPortsStatusLabel.Text = picFound
                ? "COM: " + verifiedPort
                : "COM: not connected";
        }

        void SaveLog()
        {
            if (samples.Count == 0)
            {
                MessageBox.Show("Nothing to save yet.");
                return;
            }

            string defaultName = "log_" + DateTime.Now.ToString("yyMMddHH") + ".log";

            using (SaveFileDialog log = new SaveFileDialog())
            {
                log.Filter = "Log files (*.log)|*.log";
                log.FileName = defaultName;
                log.InitialDirectory = Application.StartupPath;

                if (log.ShowDialog() != DialogResult.OK) return;

                try
                {
                    using (StreamWriter writer = new StreamWriter(dlg.FileName))
                    {
                        writer.WriteLine("PIC Datalogger - " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        writer.WriteLine("Format: $$AN1,HighByte,LowByte,Timestamp");
                        writer.WriteLine();

                        foreach (var s in samples)
                        {
                            byte high = (byte)((s.adc >> 8) & 0x03);
                            byte low = (byte)(s.adc & 0xFF);
                            string stamp = s.time.ToString("yyMMddHHmmssff");
                            writer.WriteLine($"$$AN1,{high},{low},{stamp}");
                        }
                    }

                    currentLogPath = log.FileName;
                    AddEvent("Saved " + samples.Count + " samples");
                    UpdateStatusBar();
                    MessageBox.Show("Saved OK");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Save failed: " + ex.Message);
                }
            }
        }

        void StartSampling()
        {
            if (!picFound)
            {
                MessageBox.Show("No PIC connected.");
                return;
            }

            int ms = GetIntervalMs();
            if (ms <= 0)
            {
                MessageBox.Show("Pick a sample rate first.");
                return;
            }

            MainTimer.Interval = ms;
            isSampling = true;
            AddEvent("Sampling started");
            UpdateStatusBar();
        }

        void StopSampling()
        {
            isSampling = false;
            AddEvent("Sampling stopped");
            UpdateStatusBar();
        }

        //Event Handlers*******************************************************
        private void SettingsMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Use the Sample Rate and History boxes on the form.");
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartSampling();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            StopSampling();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveLog();
        }

        private void SampleRateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StartContextMenuItem_Click(object sender, EventArgs e)
        {
            StartSampling();
        }

        private void StopContextMenuItem_Click(object sender, EventArgs e)
        {
            StopSampling();
        }

        private void SaveContextMenuItem_Click(object sender, EventArgs e)
        {
            SaveLog();
        }

        private void HistoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
