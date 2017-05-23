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
    public partial class mision : Form
    {
        SqlConnection con = new SqlConnection("workstation id=COLEGIO.mssql.somee.com;packet size=4096;user id=wfvillalba_SQLLogin_1;pwd=umk7o9frdk;data source=COLEGIO.mssql.somee.com;persist security info=False;initial catalog=COLEGIO");

        public mision()
        {
            InitializeComponent();
            BuscarMision();
        }

        public void BuscarMision()
        {
            string cadsql = "select mision from colegio";

            SqlCommand comando = new SqlCommand(cadsql, con);
            con.Open();

            SqlDataReader leer = comando.ExecuteReader();

            if (leer.Read() == true)
            {
                label1.Text = leer["mision"].ToString();
            }
            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
