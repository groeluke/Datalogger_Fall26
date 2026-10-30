using System.IO.Ports;
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
        SerialPort serialPort = new SerialPort();  //the serial port we talk to the PIC on
        List<byte> rxBuffer = new List<byte>();  //temporary storage for bytes coming from the PIC
        bool picFound = false;  //true once we successfully found the PIC
        string verifiedPort = "";  //which COM port the PIC is on
        bool waiting = false;  //true while we are waiting for a reply from the PIC
        DateTime replyDeadline;  //when we should give up waiting for a reply
        DateTime nextSearchTime = DateTime.Now;  //when we should try looking for the PIC again

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
            SampleRateComboBox.Items.AddRange(new object[]
            {
                "10 Minutes", "5 Minutes", "1 Minute", "30 Seconds",
                "10 Seconds", "5 Seconds", "1 Seconds", "500 ms",
                "200 ms", "100 ms"
            }); // add all the times for that Sample rate for data

            SampleRateComboBox.SelectedIndex = 6;  // 1 second

            HistoryComboBox.Items.AddRange(new object[]
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
        void AddEvent(string message)
        {
            string line = DateTime.Now.ToString("HH:mm:ss.fff") + "  " + message;
            ComListBox.Items.Add(line);
            ComListBox.TopIndex = ComListBox.Items.Count - 1;
        }

        // SaveLog is when the save button is pressed it adds a new file that will save the logged data 
        void SaveLog()
        {
            if (samples.Count == 0)
            {
                MessageBox.Show("Nothing to save yet.");
                return;
            }

            // always save in the same folder as the program
            string folder = Application.StartupPath;

            // find next free number: datalogged1.log, datalogged2.log, ...
            int number = 1;
            string fileName;
            do
            {
                fileName = Path.Combine(folder, "datalogged" + number + ".log");
                number++;
            }
            while (File.Exists(fileName));

            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine("PIC Datalogger - " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    writer.WriteLine("Format: $$AN1,HighByte,LowByte,Timestamp");
                    writer.WriteLine();

                    foreach (var s in samples)
                    {
                        byte high = (byte)((s.adc >> 8) & 0x03);
                        byte low = (byte)(s.adc & 0xFF);
                        string stamp = s.time.ToString("yy:MM:dd:HH:mm:ss:ff");
                        writer.WriteLine($"$$AN1,{high},{low},{stamp}");
                    }
                }

                currentLogPath = fileName;
                AddEvent("Saved → " + Path.GetFileName(fileName));
                UpdateStatusBar();
                MessageBox.Show("Saved as " + Path.GetFileName(fileName));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save failed: " + ex.Message);
            }
        }

        //StartSampling will check to make sure the pic is connected and then it will 
        //start sampling the data at whatever rate is selected
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

        //StopSampling will just stop the sampling when it is selected
        void StopSampling()
        {
            isSampling = false;
            AddEvent("Sampling stopped");
            UpdateStatusBar();
        }

        //GetIntervalsMS ties in with the combo box so when someone 
        // selects a time it links that name with this amount of time
        int GetIntervalMs()
        {
            string text = SampleRateComboBox.SelectedItem?.ToString() ?? "";

            if (text.Contains("10 Minutes")) return 600000;
            if (text.Contains("5 Minutes")) return 300000;
            if (text.Contains("1 Minute")) return 60000;
            if (text.Contains("30 Seconds")) return 30000;
            if (text.Contains("10 Seconds")) return 10000;
            if (text.Contains("5 Seconds")) return 5000;
            if (text.Contains("1 Second")) return 1000;
            if (text.Contains("500 ms")) return 500;
            if (text.Contains("200 ms")) return 200;
            if (text.Contains("100 ms")) return 100;

            return 0;
        } 


        void MainTimer_Tick(object sender, EventArgs e)
        {
            if (!picFound)
            {
                if (DateTime.Now >= nextSearchTime)
                    FindPic();
                return;
            }

            if (!PortStillExists())
            {
                DisconnectPic("COM port gone");
                return;
            }

            ReadIncomingBytes();

            if (isSampling && !waiting)
                SendAdcRequest();

            if (waiting && DateTime.Now > replyDeadline)
                DisconnectPic("PIC timeout");
        }

        //This is currently set up for my COM6 port which is were my RS232
        // cable is connected. This looks for the port and connects
        void FindPic()
        {
            // TEMPORARY – only test COM6
            string port = "COM6";

            AddEvent("Trying " + port + "...");

            if (TryPort(port))
            {
                picFound = true;
                verifiedPort = port;
                PortsComboBox.Items.Clear();
                PortsComboBox.Items.Add(port);
                PortsComboBox.SelectedIndex = 0;
                AddEvent("PIC found on " + port);
                UpdateStatusBar();
            }
            else
            {
                AddEvent("COM6 failed");
                nextSearchTime = DateTime.Now.AddSeconds(2);
            }
        }

        //TryPort verifies that this port is connected to the PIC 
        //This was tied to the assembly code from LAB_8_Part_4_UART code
        bool TryPort(string portName)
        {
            try
            {
                ClosePort();

                serialPort = new SerialPort(portName, 9600, Parity.None, 8, StopBits.One);
                serialPort.ReadTimeout = 300;
                serialPort.WriteTimeout = 300;
                serialPort.Open();
                serialPort.DiscardInBuffer();
                serialPort.DiscardOutBuffer();

                // send ID request
                serialPort.Write(new byte[] { 0x24, 0x49, 0x00 }, 0, 3);

                // give the PIC time to answer
                System.Threading.Thread.Sleep(250);

                // read whatever is actually there
                int available = serialPort.BytesToRead;
                if (available < 5)
                {
                    AddEvent(portName + " - only " + available + " bytes");
                    return false;
                }

                byte[] buf = new byte[available];
                serialPort.Read(buf, 0, available);

                // show what we received (helpful for debugging)
                AddEvent(portName + " RX: " + BitConverter.ToString(buf));

                // look for the ID reply anywhere in the data
                for (int i = 0; i <= buf.Length - 5; i++)
                {
                    if (buf[i] == 0x24 &&
                        buf[i + 1] == 0x49 &&
                        buf[i + 2] == 0x02 &&
                        buf[i + 3] == 0x33 &&
                        buf[i + 4] == 0x75)
                    {
                        return true;   // found the PIC
                    }
                }
            }
            catch (Exception ex)
            {
                AddEvent(portName + " error: " + ex.Message);
            }

            ClosePort();
            return false;
        }

        //Every interval is sends a new request for an ADC value
        void SendAdcRequest()
        {
            if (!picFound || serialPort == null || !serialPort.IsOpen) return;

            try
            {
                serialPort.Write(new byte[] { 0x24, 0x41, 0x01, 0x00 }, 0, 4);
                waiting = true;
                replyDeadline = DateTime.Now.AddMilliseconds(400);
                AddEvent("TX ADC request");
            }
            catch
            {
                DisconnectPic("Send failed");
            }
        }

        void ReadIncomingBytes()
        {
            if (serialPort == null || !serialPort.IsOpen) return;

            try
            {
                while (serialPort.BytesToRead > 0)
                {
                    int count = serialPort.BytesToRead;
                    byte[] data = new byte[count];
                    serialPort.Read(data, 0, count);
                    rxBuffer.AddRange(data);
                }

                while (GetOnePacket(out byte[] packet))
                {
                    waiting = false;
                    HandlePacket(packet);
                }
            }
            catch
            {
                DisconnectPic("Receive failed");
            }
        }

        bool GetOnePacket(out byte[] packet)
        {
            packet = null;

            while (rxBuffer.Count > 0 && rxBuffer[0] != 0x24)
                rxBuffer.RemoveAt(0);

            if (rxBuffer.Count < 3) return false;

            int total = 3 + rxBuffer[2];
            if (total > 64 || rxBuffer.Count < total) return false;

            packet = rxBuffer.GetRange(0, total).ToArray();
            rxBuffer.RemoveRange(0, total);
            return true;
        }

        void HandlePacket(byte[] packet)
        {
            AddEvent("RX " + BitConverter.ToString(packet));

            if (packet.Length == 6 && packet[1] == 0x41)
            {
                int adc = ((packet[4] & 0x03) << 8) | packet[5];
                StoreSample(adc);
            }
        }

        void StoreSample(int adc)
        {
            if (!isSampling) return;

            samples.Add((adc, DateTime.Now));
            if (samples.Count > MAX_SAMPLES)
                samples.RemoveAt(0);

            ComListBox.Items.Add(DateTime.Now.ToString("HH:mm:ss.fff") + "  ADC = " + adc);
            ComListBox.TopIndex = ComListBox.Items.Count - 1;

            GraphPictureBox.Invalidate();
        }

        void DisconnectPic(string reason)
        {
            picFound = false;
            verifiedPort = "";
            waiting = false;
            rxBuffer.Clear();
            ClosePort();
            nextSearchTime = DateTime.Now.AddSeconds(1);
            AddEvent("Disconnected: " + reason);
            UpdateStatusBar();
        }

        void ClosePort()
        {
            try
            {
                if (serialPort != null && serialPort.IsOpen)
                    serialPort.Close();
            }
            catch { }
        }

        bool PortStillExists()
        {
            return SerialPort.GetPortNames()
                .Any(p => string.Equals(p, verifiedPort, StringComparison.OrdinalIgnoreCase));
        }

        void GraphPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            if (samples.Count < 2) return;

            List<(int adc, DateTime time)> points;
            if (HistoryComboBox.SelectedIndex == 1)
            {
                DateTime cutoff = DateTime.Now.AddSeconds(-30);
                points = samples.Where(s => s.time >= cutoff).ToList();
            }
            else
            {
                points = samples;
            }

            if (points.Count < 2) return;

            int w = GraphPictureBox.Width;
            int h = GraphPictureBox.Height;

            int min = points.Min(p => p.adc);
            int max = points.Max(p => p.adc);
            if (max == min) max = min + 1;

            using (Pen pen = new Pen(Color.Blue, 2))
            {
                Point prev = Point.Empty;
                for (int i = 0; i < points.Count; i++)
                {
                    int x = i * (w - 1) / (points.Count - 1);
                    int y = h - 1 - (points[i].adc - min) * (h - 1) / (max - min);
                    Point cur = new Point(x, y);
                    if (i > 0)
                        g.DrawLine(pen, prev, cur);
                    prev = cur;
                }
            }
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
            if (isSampling)
                MainTimer.Interval = GetIntervalMs();
            UpdateStatusBar();
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
            GraphPictureBox.Invalidate();
        }
    }
}
