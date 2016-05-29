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
            Settings.Default.Save();

            if (Settings.Default.autoStart && autoStartChanged)
            {
                StreamWriter sw = new StreamWriter("autostart_create.bat");
                sw.WriteLine("copy " + AppDomain.CurrentDomain.FriendlyName + " \"%appdata%/Microsoft/Windows/Start Menu/Programs/Startup\" /y");
                sw.WriteLine("del autostart_create.bat");
                sw.Close();
                System.Diagnostics.Process.Start("autostart_create.bat");

            } else if (!Settings.Default.autoStart && autoStartChanged)
            {
                StreamWriter sw = new StreamWriter("autostart_delete.bat");
                sw.WriteLine(@"cd %appdata%\Microsoft\Windows\Start Menu\Programs\Startup\");
                sw.WriteLine("del " + AppDomain.CurrentDomain.FriendlyName);
                sw.WriteLine(@"cd " + Application.StartupPath.ToString());
                sw.WriteLine("del autostart_delete.bat");
                sw.Close();
                System.Diagnostics.Process.Start("autostart_delete.bat");
            }

            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAutoStart.Checked)
                Settings.Default.autoStart = true;
            else
                Settings.Default.autoStart = false;

            autoStartChanged = true;
        }
    }
}
