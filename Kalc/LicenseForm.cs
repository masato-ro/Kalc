using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kalc
{
    public partial class FormLic : Form
    {
        public FormLic()
        {
            InitializeComponent();
            
            string lgplContent = Properties.Resources.lgpl_3_0;
            richTextBox1.Text = lgplContent;

            string ncalcContent = Properties.Resources.ncalcLICENSE;
            richTextBox2.Text = ncalcContent;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
