using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AI_Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label4.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label4.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            label1.Visible = true;
        }
    }
}
