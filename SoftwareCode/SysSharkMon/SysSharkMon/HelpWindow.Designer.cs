namespace SysSharkMon
{
    partial class HelpWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            buttonGit = new Button();
            textBox1 = new TextBox();
            buttonWeb = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonGit
            // 
            buttonGit.BackColor = Color.FromArgb(44, 44, 44);
            buttonGit.FlatAppearance.BorderSize = 0;
            buttonGit.FlatStyle = FlatStyle.Flat;
            buttonGit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGit.ForeColor = Color.Silver;
            buttonGit.Location = new Point(12, 295);
            buttonGit.Name = "buttonGit";
            buttonGit.Size = new Size(75, 52);
            buttonGit.TabIndex = 0;
            buttonGit.Text = "GIT";
            buttonGit.UseVisualStyleBackColor = false;
            buttonGit.Click += buttonGit_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(30, 30, 30);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Silver;
            textBox1.Location = new Point(12, 89);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(306, 200);
            textBox1.TabIndex = 1;
            textBox1.Text = "Opensource software for Esp32/Arduino project.\r\n\r\n[INFO]\r\nWhen program minimized was hide in system tray.\r\n\r\nUsed: OpenHardwareMonitorLib\r\nVersion: 1.0\r\nDev: ErrorVdept";
            // 
            // buttonWeb
            // 
            buttonWeb.BackColor = Color.FromArgb(44, 44, 44);
            buttonWeb.FlatAppearance.BorderSize = 0;
            buttonWeb.FlatStyle = FlatStyle.Flat;
            buttonWeb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonWeb.ForeColor = Color.Silver;
            buttonWeb.Location = new Point(93, 295);
            buttonWeb.Name = "buttonWeb";
            buttonWeb.Size = new Size(83, 52);
            buttonWeb.TabIndex = 2;
            buttonWeb.Text = "Website";
            buttonWeb.UseVisualStyleBackColor = false;
            buttonWeb.Click += buttonWeb_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Frame_5;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // HelpWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(330, 356);
            Controls.Add(pictureBox1);
            Controls.Add(buttonWeb);
            Controls.Add(textBox1);
            Controls.Add(buttonGit);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "HelpWindow";
            Text = "SysShark - Help";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGit;
        private TextBox textBox1;
        private Button buttonWeb;
        private PictureBox pictureBox1;
    }
}