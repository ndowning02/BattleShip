using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Noah_Ruben
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int[,] a = new int[,] { { 6, 3 }, { 54, 3 }, { 150, 3 }, { 198, 3 }, { 246, 3 } { , } };           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void label116_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 101; ++i)
            {
                if (textBox1.Text == "0" & textBox2.Text == "0")
                {
                    //replace square with ship icon.
                }
            }
        }
    }
}
