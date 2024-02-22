using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.BackColor=Color.FromArgb(100, 0, 0, 0);
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
            button2.BackColor = Color.FromArgb(100, 0, 0, 0);
            button3.BackColor = Color.FromArgb(100, 0, 0, 0);
            button4.BackColor = Color.FromArgb(100, 0, 0, 0);
            button5.BackColor = Color.FromArgb(100, 0, 0, 0);
            button6.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new Form3();
            frm.Show();
        }
    }
}
