using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colegio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mision nm = new mision();
            nm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vision nm = new vision();
            nm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            estudiantes nm = new estudiantes();
            nm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            profesores nm = new profesores();
            nm.Visible = true;
            this.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
           galeria nm = new galeria();
            nm.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            acudiente a = new acudiente();
            a.Show();
            this.Hide();
        }
    }
}
