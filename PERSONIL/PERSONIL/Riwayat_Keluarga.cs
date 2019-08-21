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
    public partial class Riwayat_Keluarga : Form
    {
        SqlDataReader dr;

        public Riwayat_Keluarga()
        {
            InitializeComponent();

        }

        public Riwayat_Keluarga(string nip_nrp)
        {
            InitializeComponent();
            //v_nip_nrp = nip;
            t_nip_nrp.Text = nip_nrp;
            t_nip_nrp.Enabled = false;
            rb_laki.Checked = true;
        }
            
        private void Riwayat_Keluarga_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_Data_Personil.Riwayat_Keluarga' table. You can move, or remove it, as needed.
            this.riwayat_KeluargaTableAdapter.Fill(this.dS_Data_Personil.Riwayat_Keluarga);

          

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand perintahTambah = new SqlCommand();
                SqlConnection conn = Connection.connect();

                perintahTambah.Connection = conn;
                perintahTambah.CommandType = CommandType.Text;
                perintahTambah.CommandText = "insert dbo.Riwayat_Keluarga values(@nama_klg, @jns_kel, @tgl_lhr, @hub_klg, @nip_nrp)";

                perintahTambah.Parameters.AddWithValue("@nama_klg", t_nama_keluarga.Text);
                if(rb_laki.Checked == true){
                    perintahTambah.Parameters.AddWithValue("@jns_kel", "Laki-laki");
                }else if(rb_perempuan.Checked == true){
                    perintahTambah.Parameters.AddWithValue("@jns_kel", "Perempuan");
                }

                perintahTambah.Parameters.AddWithValue("@tgl_lhr", dt_tgl_lahir.Value);
                perintahTambah.Parameters.AddWithValue("@hub_klg", t_hub_klg.Text);
                perintahTambah.Parameters.AddWithValue("@nip_nrp", t_nip_nrp.Text);

                conn.Open();
                int result = perintahTambah.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Disimpan");
                conn.Close();

                t_nip_nrp.Text = "";
                t_nama_keluarga.Text = "";
                dt_tgl_lahir.Value = DateTime.Now; ;
                t_hub_klg.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
