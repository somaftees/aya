using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var frm = new Form1();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(100, 0, 0, 0);
            button10.BackColor = Color.FromArgb(100, 0, 0, 0);
            button7.BackColor = Color.FromArgb(100, 0, 0, 0);
            button8.BackColor = Color.FromArgb(100, 0, 0, 0);
            button9.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
           label2.BackColor = Color.FromArgb(100, 0, 0, 0);
            label7.BackColor = Color.FromArgb(100, 0, 0, 0);

            pictureBox2.BackColor = Color.FromArgb(100, 0, 0, 0);


        }

        private void button10_Click(object sender, EventArgs e)
        {
            var frm = new Form2();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
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
