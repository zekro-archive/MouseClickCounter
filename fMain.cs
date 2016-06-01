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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            if (Settings.Default.testForUpdate) cUpdate.update();

            timer.Start();
            cMouseHookLEFT.Start();
            cMouseHookLEFT.MouseAction += new EventHandler(eventMouseLEFT);
            cMouseHookRIGHT.Start();
            cMouseHookRIGHT.MouseAction += new EventHandler(eventMouseRIGHT);

            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add("Settings", new EventHandler(openSettings));
            cm.MenuItems.Add("Help", new EventHandler(openHelp));
            this.ContextMenu = cm;

            lbRightCounter.Text = lableRightCounter + Settings.Default.rightMouseCounter;
            lbLeftCounter.Text = lableLeftCounter + Settings.Default.leftMouseCounter;
        }

        private void eventMouseRIGHT(object sender, EventArgs e)
        {
            Settings.Default.rightMouseCounter++;
            lbRightCounter.Text = lableRightCounter + Settings.Default.rightMouseCounter;
        }

        private void eventMouseLEFT(object sender, EventArgs e)
        {
            Settings.Default.leftMouseCounter++;
            lbLeftCounter.Text = lableLeftCounter + Settings.Default.leftMouseCounter;
        }

        private void openSettings(object sender, EventArgs e)
        {
            fSettings settings = new fSettings();
            settings.ShowDialog();
        }

        private void openHelp(object sender, EventArgs e)
        {
            fInfo info = new fInfo();
            info.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            notifyIcon.Visible = true;
            this.Hide();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            maximize();
        }

        private void cms_Opening(object sender, CancelEventArgs e)
        {
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbRightCounter.Text = lableRightCounter + Settings.Default.rightMouseCounter;
            lbLeftCounter.Text = lableLeftCounter + Settings.Default.leftMouseCounter;
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Save();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Default.Save();
            Application.Exit();
        }

        private void resizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            maximize();
        }

        private void maximize()
        {
            this.ShowInTaskbar = true;
            notifyIcon.Visible = false;
            this.Show();
        }
    }
}
