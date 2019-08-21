using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;

namespace PERSONIL
{
    public partial class LoginForm : Form
    {
        SqlConnection conn;
        SqlDataReader dr;

        public string v_nip_nrp;

        public LoginForm()
        {
            InitializeComponent();
        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            SqlCommand perintahLogin = new SqlCommand();
            conn = Connection.connect();
            perintahLogin.Connection = conn; 
            

            perintahLogin.CommandType = CommandType.Text;
            perintahLogin.CommandText = "select * from dbo.personil where nip_nrp=@nip_nrp and password=@password and role=@role";

            perintahLogin.Parameters.Add("@nip_nrp", SqlDbType.VarChar);
            perintahLogin.Parameters.Add("@password", SqlDbType.VarChar);
            perintahLogin.Parameters.Add("@role", SqlDbType.VarChar);
            perintahLogin.Parameters["@nip_nrp"].Value = t_nip_nrp.Text.Trim();
            perintahLogin.Parameters["@password"].Value = t_password.Text.Trim();
            perintahLogin.Parameters["@role"].Value = cb_role.Text.Trim();

            conn.Open();
            dr = perintahLogin.ExecuteReader();

            if (dr.Read() == true)
            {
                MessageBox.Show("Berhasil Login");

                Riwayat_Keluarga rk = new Riwayat_Keluarga(t_nip_nrp.Text);
                rk.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Maaf tidak dapat login silahkan cek username dan password anda.!");
            }

            conn.Close();
        }
    }
}
