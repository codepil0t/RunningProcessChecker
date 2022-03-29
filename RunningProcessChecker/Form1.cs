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

namespace BlueIrisRunner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string filePath;
        public string fileName;

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private bool CheckProcessRunning()
        {
            try
            {
                foreach (System.Diagnostics.Process p in System.Diagnostics.Process.GetProcesses())
                {
                    if (p.ProcessName.ToString() == fileName) return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void OpenExecutableFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            filePath = openFileDialog.FileName;
            label3.Text = openFileDialog.SafeFileName;
        }

        private void RunFile(bool asAdmin)
        {
            try
            {
                Process proc = new Process();
                proc.StartInfo.FileName = filePath;
                proc.StartInfo.UseShellExecute = true;
                if (asAdmin) proc.StartInfo.Verb = "runas";
                proc.Start();
            }
            catch(Exception ex)
            {
                timer1.Enabled = false;
                timer1.Stop();
                MessageBox.Show("Error while opening file:\n" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenExecutableFile();
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!CheckProcessRunning()) { RunFile(asAdminCheck.Checked); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            fileName = textBox1.Text;
            if (CheckProcessRunning())
            {
                processStatus.Text = "process found";
                processStatus.ForeColor = Color.Green;
            }
            else
            {
                processStatus.Text = "process not found";
                processStatus.ForeColor = Color.Red;
            }
        }
    }
}
