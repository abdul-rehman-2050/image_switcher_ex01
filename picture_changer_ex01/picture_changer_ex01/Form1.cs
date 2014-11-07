using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace picture_changer_ex01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile("1.jpg");
            pictureBox1.Image = image;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile("2.jpg");
            pictureBox1.Image = image;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile("3.jpg");
            pictureBox1.Image = image;
        }
    }
}
