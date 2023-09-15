namespace SysSharkMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonStartStop = new Button();
            comboBoxCom = new ComboBox();
            label1 = new Label();
            panel1 = new Panel();
            labelStatusText = new Label();
            labelStatus = new Label();
            pictureBox1 = new PictureBox();
            textBoxLog = new TextBox();
            buttonRescanCom = new Button();
            notifyIcon1 = new NotifyIcon(components);
            buttonHelp = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonStartStop
            // 
            buttonStartStop.BackColor = Color.FromArgb(51, 51, 51);
            buttonStartStop.FlatAppearance.BorderColor = Color.FromArgb(53, 53, 53);
            buttonStartStop.FlatStyle = FlatStyle.Flat;
            buttonStartStop.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStartStop.ForeColor = Color.Silver;
            buttonStartStop.Location = new Point(12, 189);
            buttonStartStop.Name = "buttonStartStop";
            buttonStartStop.Size = new Size(120, 46);
            buttonStartStop.TabIndex = 0;
            buttonStartStop.Text = "Start";
            buttonStartStop.UseVisualStyleBackColor = false;
            buttonStartStop.Click += buttonStartStop_Click;
            // 
            // comboBoxCom
            // 
            comboBoxCom.FormattingEnabled = true;
            comboBoxCom.Location = new Point(79, 59);
            comboBoxCom.Name = "comboBoxCom";
            comboBoxCom.Size = new Size(197, 23);
            comboBoxCom.TabIndex = 1;
            comboBoxCom.SelectedIndexChanged += comboBoxCom_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 2;
            label1.Text = "COM:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 44, 44);
            panel1.Controls.Add(buttonHelp);
            panel1.Controls.Add(labelStatusText);
            panel1.Controls.Add(labelStatus);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 53);
            panel1.TabIndex = 3;
            // 
            // labelStatusText
            // 
            labelStatusText.AutoSize = true;
            labelStatusText.FlatStyle = FlatStyle.Flat;
            labelStatusText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelStatusText.ForeColor = Color.Red;
            labelStatusText.Location = new Point(186, 9);
            labelStatusText.Name = "labelStatusText";
            labelStatusText.Size = new Size(100, 17);
            labelStatusText.TabIndex = 5;
            labelStatusText.Text = "Monitoring off";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.FlatStyle = FlatStyle.Flat;
            labelStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelStatus.ForeColor = Color.Silver;
            labelStatus.Location = new Point(130, 9);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(50, 17);
            labelStatus.TabIndex = 4;
            labelStatus.Text = "Status:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Frame_5;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // textBoxLog
            // 
            textBoxLog.BackColor = Color.FromArgb(44, 44, 44);
            textBoxLog.BorderStyle = BorderStyle.None;
            textBoxLog.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxLog.ForeColor = Color.Silver;
            textBoxLog.Location = new Point(12, 88);
            textBoxLog.Multiline = true;
            textBoxLog.Name = "textBoxLog";
            textBoxLog.Size = new Size(483, 92);
            textBoxLog.TabIndex = 4;
            // 
            // buttonRescanCom
            // 
            buttonRescanCom.BackColor = Color.FromArgb(51, 51, 51);
            buttonRescanCom.FlatAppearance.BorderSize = 0;
            buttonRescanCom.FlatStyle = FlatStyle.Flat;
            buttonRescanCom.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRescanCom.ForeColor = Color.Silver;
            buttonRescanCom.Location = new Point(282, 59);
            buttonRescanCom.Name = "buttonRescanCom";
            buttonRescanCom.Size = new Size(52, 23);
            buttonRescanCom.TabIndex = 5;
            buttonRescanCom.Text = "Rescan";
            buttonRescanCom.UseVisualStyleBackColor = false;
            buttonRescanCom.Click += buttonRescanCom_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            notifyIcon1.Click += notifyIcon1_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.FromArgb(30, 30, 30);
            buttonHelp.FlatAppearance.BorderColor = Color.FromArgb(30, 30, 30);
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonHelp.ForeColor = Color.Silver;
            buttonHelp.Location = new Point(463, 12);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(32, 28);
            buttonHelp.TabIndex = 6;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(507, 247);
            Controls.Add(buttonRescanCom);
            Controls.Add(textBoxLog);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(comboBoxCom);
            Controls.Add(buttonStartStop);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "SysShark";
            Deactivate += Form1_Deactivate;
            FormClosing += Form1_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStartStop;
        private ComboBox comboBoxCom;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label labelStatus;
        private TextBox textBoxLog;
        private Button buttonRescanCom;
        private NotifyIcon notifyIcon1;
        private Label labelStatusText;
        private Button buttonHelp;
    }
}