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
        Label[][] Board;
        Image FirstShip = Image.FromFile("boat1.PNG");
        Image SecondShip = Image.FromFile("boat2.PNG");
        Image ThirdShip = Image.FromFile("boat3.PNG");
        Image FourthShip = Image.FromFile("boat4.PNG");
        Image FifthShip = Image.FromFile("boat5.PNG");
        Image SixthShip = Image.FromFile("boat6.PNG");

        public Form1()
        {
            InitializeComponent();
            Label[] row1 = new Label[] { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10 };
            Label[] row2 = new Label[] { label11, label12, label13, label14, label15, label16, label17, label18, label19, label20 };
            Label[] row3 = new Label[] { label21, label22, label23, label24, label25, label26, label27, label28, label29, label30 };
            Label[] row4 = new Label[] { label31, label32, label33, label34, label35, label36, label37, label38, label39, label40 };
            Label[] row5 = new Label[] { label41, label42, label43, label44, label45, label46, label47, label48, label49, label50 };
            Label[] row6 = new Label[] { label51, label52, label53, label54, label55, label56, label57, label58, label59, label60 };
            Label[] row7 = new Label[] { label61, label62, label63, label64, label65, label66, label67, label68, label69, label70 };
            Label[] row8 = new Label[] { label71, label72, label73, label74, label75, label76, label77, label78, label79, label80 };
            Label[] row9 = new Label[] { label81, label82, label83, label84, label85, label86, label87, label88, label89, label90 };
            Label[] row10 = new Label[] { label91, label92, label93, label94, label95, label96, label97, label98, label99, label100 };
            Board = new Label[][] { row1, row2, row3, row4, row5, row6, row7, row8, row9, row10 };


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

            Board[Convert.ToInt32(textBox1.Text)][Convert.ToInt32(textBox2.Text)].Image = FirstShip;
            Board[Convert.ToInt32(textBox4.Text)][Convert.ToInt32(textBox3.Text)].Image = SecondShip;
            Board[Convert.ToInt32(textBox6.Text)][Convert.ToInt32(textBox5.Text)].Image = ThirdShip;
            Board[Convert.ToInt32(textBox12.Text)][Convert.ToInt32(textBox11.Text)].Image = FourthShip;
            Board[Convert.ToInt32(textBox10.Text)][Convert.ToInt32(textBox9.Text)].Image = FifthShip;
            Board[Convert.ToInt32(textBox8.Text)][Convert.ToInt32(textBox7.Text)].Image = SixthShip;

        }
    }
}
