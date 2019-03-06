using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace qlscl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //test
            InitializeComponent();
            return;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kq;
            kq = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
            lbKq.Text = ""+kq;
        }
    }
}
