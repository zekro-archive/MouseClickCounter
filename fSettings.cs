using Microsoft.Win32;
using mouseCounter.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static mouseCounter.cConst;

namespace mouseCounter
{
    public partial class fSettings : Form
    {
        bool autoStartChanged = false;

        public fSettings()
        {
            InitializeComponent();
        }

        private void fSettings_Load(object sender, EventArgs e)
        {
            nudLeftValue.Value = Settings.Default.leftMouseCounter;
            nudRightValue.Value = Settings.Default.rightMouseCounter;

            cbUpdateNotify.Checked = Settings.Default.testForUpdate;
            cbAutoStart.Checked = Settings.Default.autoStart;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btResetleft_Click(object sender, EventArgs e)
        {
            Settings.Default.leftMouseCounter = 0;
        }

        private void btResetRight_Click(object sender, EventArgs e)
        {
            Settings.Default.rightMouseCounter = 0;
        }

        private void nudLeftValue_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.leftMouseCounter = (long)nudLeftValue.Value;
        }

        private void nudRightValue_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.rightMouseCounter = (long)nudRightValue.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.Default.testForUpdate = cbUpdateNotify.Checked;
            Settings.Default.Save();

            
            if (Settings.Default.autoStart && autoStartChanged)
            {
                
                RegistryKey autostart = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                autostart.SetValue("CAutoStart", Application.ExecutablePath.ToString());
                autostart.Close();

            } else if (!Settings.Default.autoStart && autoStartChanged)
            {
                
                RegistryKey autostart = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                autostart.SetValue("CAutoStart", 0);
                autostart.Close();
            }
            
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            autoStartChanged = true;
            Settings.Default.autoStart = cbAutoStart.Checked;
        }
    }
}
