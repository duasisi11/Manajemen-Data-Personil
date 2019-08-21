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
    public partial class DataPokok : Form
    {
        public DataPokok()
        {
            InitializeComponent();
        }

        private void b_home_Click(object sender, EventArgs e)
        {
            Form1 Frm = new Form1();
            Frm.Show();
            this.Hide();
        }
    }
}
