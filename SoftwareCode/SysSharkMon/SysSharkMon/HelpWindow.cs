using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysSharkMon
{
    public partial class HelpWindow : Form
    {
        public HelpWindow()
        {
            InitializeComponent();
        }
        Process myProcess = new Process();
        private void buttonGit_Click(object sender, EventArgs e)
        {
            myProcess.StartInfo.UseShellExecute = true;
            myProcess.StartInfo.FileName = "https://github.com/ErrorVdept/SysShark";
            myProcess.Start();
            //System.Diagnostics.Process.Start("", );
        }

        private void buttonWeb_Click(object sender, EventArgs e)
        {
            myProcess.StartInfo.UseShellExecute = true;
            myProcess.StartInfo.FileName = "https://errorvdept.github.io";
            myProcess.Start();
            
        }
    }
}
