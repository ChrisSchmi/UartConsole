using System;
using System.Diagnostics.Eventing.Reader;
using System.IO.Ports;
using System.Windows.Forms;

namespace UartConsole
{
    public partial class ComForm : Form
    {
        private SerialPort _serialPort;

        public ComForm()
        {
            InitializeComponent();
            _serialPort = new SerialPort();
            _serialPort.DataReceived += SerialPort_DataReceived;

            LoadSerialSettings();
            ConfigConsoleLayout();
        }

        private void LoadSerialSettings()
        {
            // Ports finden
            cmbPort.Items.AddRange(SerialPort.GetPortNames());
            if (cmbPort.Items.Count > 0) cmbPort.SelectedIndex = 0;

            // Standard Baudraten
            cmbBaud.Items.AddRange(new object[] { "9600", "19200", "38400", "57600", "115200" });
            cmbBaud.SelectedIndex = 0;

            // Enums für Parität und Stopbits direkt binden
            cmbParity.DataSource = Enum.GetValues(typeof(Parity));
            cmbStopBits.DataSource = Enum.GetValues(typeof(StopBits))
                                         .Cast<StopBits>()
                                         .Where(sb => sb != StopBits.None)
                                         .ToList();

            cmbDataBits.Items.AddRange(new object[] { "7", "8" });
            cmbDataBits.SelectedIndex = 1;

            btnSend.Enabled = false;
        }

        private void ConfigConsoleLayout()
        {
            txtLog.BackColor = Color.Black;
            txtLog.ForeColor = Color.LightGreen;
            txtLog.Font = new Font("Consolas", 12.0f);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_serialPort.IsOpen)
                {
                    _serialPort.PortName = cmbPort.Text;
                    _serialPort.BaudRate = int.Parse(cmbBaud.Text);
                    _serialPort.DataBits = int.Parse(cmbDataBits.Text);
                    _serialPort.Parity = (Parity)cmbParity.SelectedItem;
                    _serialPort.StopBits = (StopBits)cmbStopBits.SelectedItem;

                    _serialPort.Open();
                    btnConnect.Text = "Disconnect";
                    btnConnect.BackColor = System.Drawing.Color.LightCoral;
                    SetControlState(false);
                    LogText("Connected...");
                }
                else
                {
                    _serialPort.Close();
                    btnConnect.Text = "Connect";
                    btnConnect.BackColor = System.Drawing.Color.LightGreen;
                    SetControlState(true);
                    LogText("Disconnected...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler: {ex.Message}", "Verbindungsfehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LogText(string text = "")
        {
            var logtext = $"{text}{Environment.NewLine}";

            if (InvokeRequired)
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    txtLog.AppendText(logtext);
                    // Automatisch nach unten scrollen
                    txtLog.SelectionStart = txtLog.Text.Length;
                    txtLog.ScrollToCaret();
                }));
            }
            else
            {
                txtLog.AppendText(logtext);
                // Automatisch nach unten scrollen
                txtLog.SelectionStart = txtLog.Text.Length;
                txtLog.ScrollToCaret();
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Thread-sicheres Schreiben in die Textbox
            string incomingData = _serialPort.ReadExisting();
            LogText(incomingData);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (_serialPort.IsOpen && !string.IsNullOrWhiteSpace(txtInput.Text))
            {
                _serialPort.WriteLine(txtInput.Text);
                txtInput.Clear();
                txtInput.Focus();
            }
        }

        private void SetControlState(bool enabled)
        {
            cmbPort.Enabled = cmbBaud.Enabled = cmbDataBits.Enabled = cmbParity.Enabled = cmbStopBits.Enabled = enabled;
            btnSend.Enabled = _serialPort.IsOpen;
        }
    }
}