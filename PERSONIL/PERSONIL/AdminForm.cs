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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void b_data_pokok_Click(object sender, EventArgs e)
        {
            RekapDataPersonil rdp = new RekapDataPersonil();
            rdp.Show();
            this.Hide();
        }
    }
}
