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

namespace _2212390_DNTKhanh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strURL = "https://mail.google.com/mail/u/0/?ogbl#inbox?compose=new";
            this.linkLabel1.Links.Add(0, strURL.Length, strURL);
            strURL = "https://lms.dlu.edu.vn";
            this.linkLabel2.Links.Add(0, strURL.Length, strURL);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strURL = Convert.ToString(e.Link.LinkData);
            if (strURL.StartsWith("https://mail.google.com"))
                Process.Start(strURL);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strURL = Convert.ToString(e.Link.LinkData);
            if (strURL.StartsWith("https://"))
                Process.Start(strURL); //Process.Start("IExplore", strURL)
        }
    }
}
