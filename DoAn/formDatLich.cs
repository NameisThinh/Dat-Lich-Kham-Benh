using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class formDatLich : Form
    {
        public formDatLich()
        {
            InitializeComponent();
            txtKhac.Visible = false;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
    }
}
