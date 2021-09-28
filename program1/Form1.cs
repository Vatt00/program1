using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            data1.Text = DateTime.Now.ToShortDateString();
            godzina1.Text = DateTime.Now.ToLongTimeString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            godzina1.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
