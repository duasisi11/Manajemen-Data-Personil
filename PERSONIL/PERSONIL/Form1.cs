using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PERSONIL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b_home_Click(object sender, EventArgs e)
        {
            Form1 Frm = new Form1();
            Frm.Show();
            this.Hide();
        }

        private void b_data_pokok_Click(object sender, EventArgs e)
        {
            DataPokok dtPokok = new DataPokok();
            dtPokok.Show();
            this.Hide();
        }

        private void b_kartu_identitas_Click(object sender, EventArgs e)
        {
            Kartu_Identitas krident = new Kartu_Identitas();
            krident.ShowDialog();
        }

        private void b_satker_Click(object sender, EventArgs e)
        {
            Satuan_Kerja satker = new Satuan_Kerja();
            satker.ShowDialog();
        }

        private void b_r_pangkat_Click(object sender, EventArgs e)
        {
            Riwayat_Pangkat rpang = new Riwayat_Pangkat();
            rpang.ShowDialog();
        }

        private void b_r_jabatan_Click(object sender, EventArgs e)
        {
            Riwayat_Jabatan rjab = new Riwayat_Jabatan();
            rjab.ShowDialog();
        }

        private void b_dikum_Click(object sender, EventArgs e)
        {
            Pendidikan_Umum pendum = new Pendidikan_Umum();
            pendum.ShowDialog();
        }

        private void b_diktuk_Click(object sender, EventArgs e)
        {
            Pendidikan_mil_pembentukan pendmil = new Pendidikan_mil_pembentukan();
            pendmil.ShowDialog();
        }
    }
}
