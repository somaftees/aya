using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(100, 0, 0, 0);
            button3.BackColor = Color.FromArgb(100, 0, 0, 0);
            button6.BackColor = Color.FromArgb(100, 0, 0, 0);
            button7.BackColor = Color.FromArgb(100, 0, 0, 0);
            button8.BackColor = Color.FromArgb(100, 0, 0, 0);
            button4.BackColor = Color.FromArgb(100, 0, 0, 0);
            button5.BackColor = Color.FromArgb(100, 0, 0, 0);
            button9.BackColor = Color.FromArgb(100, 0, 0, 0);


            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);

            label3.BackColor = Color.FromArgb(100, 0, 0, 0);

            label2.BackColor = Color.FromArgb(100, 0, 0, 0);
            label1.BackColor = Color.FromArgb(100, 0, 0, 0);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new Form1();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var frm = new Form2();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var frm = new Form3();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var frm = new Form4();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var frm = new Form5();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var frm = new Form6();
            frm.Show();
        }
    }
}
