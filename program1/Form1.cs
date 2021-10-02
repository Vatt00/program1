using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
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
            godzina1.Text = DateTime.Now.ToString("HH:mm");
            textBox2.ForeColor = Color.Blue;
            maskedTextBox1.ForeColor = Color.Blue;
            BackColor = Color.LightSlateGray;
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                richTextBox1.Clear();
                return;
            }
            richTextBox1.Text = textBox1.Text;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                richTextBox1.Clear();
                return;
            }
            richTextBox1.Text = textBox2.Text;
        }
        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBox1.Text))
            {
                richTextBox1.Clear();
                return;
            }
            richTextBox1.Text = maskedTextBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fd.Font;
            }//
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog theDialog = new SaveFileDialog();
            theDialog.Title = "Save Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.AppendAllText(theDialog.FileName, data1.Text);
                    File.AppendAllText(theDialog.FileName, " ");
                    File.AppendAllText(theDialog.FileName, godzina1.Text);
                    File.AppendAllText(theDialog.FileName, " ");
                    File.AppendAllText(theDialog.FileName, textBox1.Text);
                    File.AppendAllText(theDialog.FileName, " ");
                    File.AppendAllText(theDialog.FileName, textBox2.Text);
                    File.AppendAllText(theDialog.FileName, " ");
                    File.AppendAllText(theDialog.FileName, maskedTextBox1.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not save file. Original error: " + ex.Message);
                }
            }
        }
    }
}
