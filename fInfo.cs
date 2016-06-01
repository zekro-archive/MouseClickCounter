using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mouseCounter
{
    partial class fInfo : Form
    {
        public fInfo()
        {
            InitializeComponent();
            this.Text = String.Format("Information");
            this.lbVersion.Text = "Client version: " + AssemblyVersion;
        }

        #region Assemblyattributaccessoren

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void fInfo_Load(object sender, EventArgs e)
        {

        }

        private void start(string path)
        {
            System.Diagnostics.Process.Start(path);
        }

        private void llbGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            start("http://github.com/zekrotja");
        }

        private void llbWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            start("http://zekro.jimdo.com");
        }

        private void llbYouTube_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            start("https://www.youtube.com/c/zekrommaster110");
        }

        private void llbTwitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            start("https://twitter.com/zekrotja");
        }
    }
}
