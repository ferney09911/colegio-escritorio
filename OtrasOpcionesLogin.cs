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
    public partial class OtrasOpcionesLogin : Form
    {
        SqlConnection con = new SqlConnection("workstation id=COLEGIO.mssql.somee.com;packet size=4096;user id=wfvillalba_SQLLogin_1;pwd=umk7o9frdk;data source=COLEGIO.mssql.somee.com;persist security info=False;initial catalog=COLEGIO");

        public OtrasOpcionesLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cadsql = "select contraseña from usuario where usuario='" + textBox3.Text + "'";

            SqlCommand comando = new SqlCommand(cadsql, con);
            con.Open();

            SqlDataReader leer = comando.ExecuteReader();
            if (leer.Read() == true)
            {
                string contraseña;
                contraseña = leer["contraseña"].ToString();

                label1.Visible = true;
                label2.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;

                label3.Visible = false;
                textBox3.Visible = false;
                button4.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
            }
            con.Close(); 
        }
    }
}
