using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colegio1
{
    public partial class acudiente : Form
    {
        SqlConnection con = new SqlConnection("workstation id=COLEGIO.mssql.somee.com;packet size=4096;user id=wfvillalba_SQLLogin_1;pwd=umk7o9frdk;data source=COLEGIO.mssql.somee.com;persist security info=False;initial catalog=COLEGIO");

        public acudiente()
        {
            InitializeComponent();
            ClearControls();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string cadsql = "insert into acudiente values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";

                SqlCommand comando = new SqlCommand(cadsql, con);
                con.Open();
                SqlDataReader leer = comando.ExecuteReader();
                con.Close();
                MessageBox.Show("REGISTRADO");
                ClearControls();
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);

            }
        }

        private void ClearControls()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Visible = true;
            this.Visible = false;
        }
    }
}
