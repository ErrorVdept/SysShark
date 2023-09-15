using LibreHardwareMonitor.Hardware;

using System.Diagnostics;
using System.IO.Ports;
using System.Text.Json;

namespace SysSharkMon
{
    public partial class Form1 : Form
    {
        public bool IsStarted = false;
        private static SerialPort SelectedCom;

        private Thread MonitThread;
        private Computer computer = new Computer
        {
            IsCpuEnabled = true,
            IsGpuEnabled = true,
            IsMemoryEnabled = true,
            IsMotherboardEnabled = true,
            IsControllerEnabled = true,
            IsNetworkEnabled = false,
            IsStorageEnabled = false
        };
        public Form1()
        {
            InitializeComponent();



            RescanCom();


        }
        private void RescanCom()
        {
            comboBoxCom.Items.Clear();

            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBoxCom.Items.Add(port);
            }
        }


        private void buttonStartStop_Click(object sender, EventArgs e)
        {

            if (IsStarted)
            {


                try
                {
                    IsStarted = false;
                    buttonStartStop.Text = "Start";
                    SelectedCom.Close();
                    computer.Close();
                    textBoxLog.Text += "\r\n [Monitoring stopped]";
                    labelStatusText.Text = "Monitoring off";
                    labelStatusText.ForeColor = Color.Red;
                }
                catch (Exception ex)
                {
                    textBoxLog.Text += "\r\n [ERROR]: " + ex.Message;
                }
            }
            else
            {
                if (!String.IsNullOrEmpty(comboBoxCom.Text))
                {
                    try
                    {
                        IsStarted = true;
                        buttonStartStop.Text = "Stop";
                        SelectedCom.Open();

                        MonitThread = new Thread(StartMonit);
                        MonitThread.Start();
                        textBoxLog.Text += "\r\n [Monitoring started]";
                        labelStatusText.Text = "Monitoring on";
                        labelStatusText.ForeColor = Color.Yellow;
                    }
                    catch (Exception ex)
                    {
                        textBoxLog.Text += "\r\n [ERROR]: " + ex.Message;
                    }

                }

            }
        }


        private void GetCpuLoad()
        {

        }

        public StatusModel status = new StatusModel();
        private string JsonStatus = "";
        private void StartMonit()
        {
            computer.Open();
            computer.Accept(new UpdateVisitor());
            while (IsStarted)
            {
                try
                {

                    status = new StatusModel();


                    foreach (IHardware hardware in computer.Hardware)
                    {
                        hardware.Update();
                        if (hardware.HardwareType == HardwareType.Cpu || true)
                        {
                            foreach (ISensor sensor in hardware.Sensors)
                            {

                                if (sensor.SensorType == SensorType.Load || true)
                                {
                                    if (sensor.Name == "CPU Total")
                                    {
                                        status.cpuLoad = Convert.ToInt32(sensor.Value);

                                    }
                                }
                                if (sensor.SensorType == SensorType.Temperature || true)
                                {
                                    if (sensor.Name == "Package")
                                    {
                                        status.cpuTemp = Convert.ToInt32(sensor.Value);

                                    }
                                }

                            }
                        }
                        if (hardware.HardwareType == HardwareType.GpuNvidia || hardware.HardwareType == HardwareType.GpuIntel || hardware.HardwareType == HardwareType.GpuAmd || true)
                        {
                            foreach (ISensor sensor in hardware.Sensors)
                            {
                                if (sensor.SensorType == SensorType.Load || true)
                                {
                                    if (sensor.Name == "GPU Core")
                                    {
                                        status.gpuLoad = Convert.ToInt32(sensor.Value);

                                    }
                                }
                                if (sensor.SensorType == SensorType.Temperature || true)
                                {
                                    if (sensor.Name == "GPU Core")
                                    {
                                        status.gpuTemp = Convert.ToInt32(sensor.Value);

                                    }
                                }

                            }
                        }
                        if (hardware.HardwareType == HardwareType.Memory || true)
                        {
                            foreach (ISensor sensor in hardware.Sensors)
                            {
                                if (sensor.SensorType == SensorType.Load || true)
                                {
                                    if (sensor.Name == "Memory Used")
                                    {
                                        status.ramLoad = Convert.ToInt32(sensor.Value);

                                    }
                                }


                            }
                        }
                    }


                    JsonStatus = JsonSerializer.Serialize(status);


                    SelectedCom.Write(JsonStatus);
                    Thread.Sleep(1000);
                    Debug.WriteLine("1");
                }
                catch
                {
                    Invoke(new Action(() => { textBoxLog.Text += "\r\n [Monitoring ERROR]"; }));
                }

            }
        }

        private void comboBoxCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(comboBoxCom.Text))
            {
                SelectedCom = new SerialPort();
                SelectedCom.PortName = comboBoxCom.Text;
                SelectedCom.BaudRate = 115200;
            }
        }

        private void buttonRescanCom_Click(object sender, EventArgs e)
        {
            RescanCom();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            IsStarted = false;

        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
                MessageBox.Show("Program minimized to tray");
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
                notifyIcon1.Visible = false;
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            HelpWindow helpWindow = new HelpWindow();
            helpWindow.Show();
        }
    }
}