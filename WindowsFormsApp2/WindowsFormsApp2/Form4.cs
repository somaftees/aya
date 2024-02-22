using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(100, 0, 0, 0);
            label2.BackColor = Color.FromArgb(100, 0, 0, 0);
            label3.BackColor = Color.FromArgb(100, 0, 0, 0);
            label4.BackColor = Color.FromArgb(100, 0, 0, 0);
            label5.BackColor = Color.FromArgb(100, 0, 0, 0);
            label6.BackColor = Color.FromArgb(100, 0, 0, 0);
            label7.BackColor = Color.FromArgb(100, 0, 0, 0);
            label8.BackColor = Color.FromArgb(100, 0, 0, 0);
            label9.BackColor = Color.FromArgb(100, 0, 0, 0);
            label10.BackColor = Color.FromArgb(100, 0, 0, 0);

            
            button1.BackColor = Color.FromArgb(100, 0, 0, 0);
            button10.BackColor = Color.FromArgb(100, 0, 0, 0);
            button7.BackColor = Color.FromArgb(100, 0, 0, 0);
            button8.BackColor = Color.FromArgb(100, 0, 0, 0);
            button9.BackColor = Color.FromArgb(100, 0, 0, 0);

            button2.BackColor = Color.FromArgb(100, 0, 0, 0);
            button3.BackColor = Color.FromArgb(100, 0, 0, 0);
            button6.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            pictureBox2.BackColor = Color.FromArgb(100, 0, 0, 0);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            var frm = new Form1();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var frm = new Form2();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new Form3();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var frm = new Form4();
            frm.Show();
        }
    }
}
