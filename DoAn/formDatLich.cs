using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DoAn
{
    public partial class formDatLich : Form
    {
        public formDatLich()
        {
            InitializeComponent();
            txtKhac.Visible = false;
            
        }
        private void rdbkhac_CheckedChanged(object sender, EventArgs e)
        {
            
           if( rdbkhac.Checked == true)
            {
                txtKhac.Visible = true;
            }
           else
            {
                txtKhac.Visible = false;
            }
        }

        private void txthoten_Click(object sender, EventArgs e)
        {
            txthoten.Text = "";
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
        }

        private void txtSdt_Click(object sender, EventArgs e)
        {
            txtSdt.Text = "";
        }

        private void txtNamsinh_Click(object sender, EventArgs e)
        {
            txtNamsinh.Text = "";
        }

        private void txtThongTinThem_Click(object sender, EventArgs e)
        {
            txtThongTinThem.Text = "";
        }
    }
}
