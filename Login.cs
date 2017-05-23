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
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("workstation id=COLEGIO.mssql.somee.com;packet size=4096;user id=wfvillalba_SQLLogin_1;pwd=umk7o9frdk;data source=COLEGIO.mssql.somee.com;persist security info=False;initial catalog=COLEGIO");

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadsql = "select usuario, contraseña from usuario where contraseña='" + textBox2.Text + "'";

            SqlCommand comando = new SqlCommand(cadsql, con);
            con.Open();

            SqlDataReader leer = comando.ExecuteReader();
            if (leer.Read() == true)
            {
                textBox1.Text = leer["usuario"].ToString();
                textBox2.Text = leer["contraseña"].ToString();
                Form1 es = new Form1();
                es.Visible = true;
                this.Visible = false;
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                MessageBox.Show("Datos no validos");
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OtrasOpcionesLogin op = new OtrasOpcionesLogin();
            op.Visible = true;
        }
    }
}
