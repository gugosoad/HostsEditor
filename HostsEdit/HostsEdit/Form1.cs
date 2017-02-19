using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HostsEdit
{
    public partial class Form1 : Form
    {
        string HostsPath = Environment.ExpandEnvironmentVariables("%SystemDrive%\\Windows\\System32\\drivers\\etc\\hosts");
        //string HostsPath = "c:\\hosts1"; // try
        string backup;
        string defaulthosts = "# Copyright (c) 1993-2006 Microsoft Corp." + "\r\n#" + "\r\n# This is a sample HOSTS file used by Microsoft TCP/IP for Windows." + "\r\n#" + "\r\n# This file contains the mappings of IP addresses to host names. Each" + "\r\n# entry should be kept on an individual line. The IP address should" + "\r\n# be placed in the first column followed by the corresponding host name." + "\r\n# The IP address and the host name should be separated by at least one" + "\r\n# space." + "\r\n#" + "\r\n# Additionally, comments (such as these) may be inserted on individual" + "\r\n# lines or following the machine name denoted by a '#' symbol." + "\r\n#" + "\r\n# For example:" + "\r\n#" + "\r\n#      102.54.94.97     rhino.acme.com          # source server" + "\r\n#       38.25.63.10     x.acme.com              # x client host" + "\r\n" + "\r\n# localhost name resolution is handle within DNS itself." + "\r\n#       127.0.0.1       localhost\n#       ::1             localhost";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)   // form loading
        {
            tb2.Text = File.ReadAllText(HostsPath).ToString();//read hosts file
            backup = File.ReadAllText(HostsPath).ToString();  //hosts file backup
        }
        private void savebtn_Click(object sender, EventArgs e)//saving hosts
        {
            if (String.IsNullOrEmpty(tb2.Text) || String.IsNullOrWhiteSpace(tb2.Text))
            {
                MessageBox.Show("Hosts reset!", "Warning!!!");
                tb2.Text = backup;
            }
            else
            {
                File.WriteAllText(HostsPath, tb2.Lines[0] + Environment.NewLine);
                for (int i = 1; i < tb2.Lines.Count(); i++)
                {
                    File.AppendAllText(HostsPath, tb2.Lines[i] + Environment.NewLine);
                }
            }
        }
        private void Reset_Click(object sender, EventArgs e) //reset to old version
        {
            tb2.Text = backup;                     //reset changes
            //File.WriteAllText(HostsPath, backup);//reset hosts file
        }
        private void addBtn_Click(object sender, EventArgs e)//adding new address to hosts
        {
            if (String.IsNullOrEmpty(tb1.Text) || String.IsNullOrWhiteSpace(tb1.Text)) //bug catch
            {
                tb1.ResetText();
            }
            else
            {
                for (int i = 0; i < tb1.Lines.Count(); i++)
                {
                    tb2.AppendText("\n" + "127.0.0.1 " + tb1.Lines[i]);
                }
            }
        }
        private void defaultTb_Click(object sender, EventArgs e)//default hosts file load
        {
            tb2.Text = defaulthosts;
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Light program for Hosts editing. \nJust type address(es) in the left part \nand press Add To Hosts--> \n2017© ", "About");
        }
    }
}