using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            txthoten.ForeColor = Color.Black;
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtEmail.ForeColor = Color.Black;
        }

        private void txtSdt_Click(object sender, EventArgs e)
        {
            txtSdt.Text = "";
            txtSdt.ForeColor = Color.Black;
        }

        private void txtNamsinh_Click(object sender, EventArgs e)
        {
            txtNamsinh.Text = "";
            txtNamsinh.ForeColor = Color.Black;
        }

       

        private void txtLyDo_Click(object sender, EventArgs e)
        {
            txtLyDo.Text = "";
            txtLyDo.ForeColor = Color.Black;
        }

        private void btnDatLich_Click(object sender, EventArgs e)
        {
            try
            {
                if(txthoten.Text!=""&& txtEmail.Text != "" && txtSdt.Text != "")
                {
                    MessageBox.Show("Đăng ký thành công!. Đợi kết quả đăng ký tại Email");
                }
                else
                {
                    MessageBox.Show("Nhập đủ thông tin cần thiết");
                    if (txthoten.Text == "")
                    {
                        txthoten.Text = "Nhập họ tên";
                        txthoten.ForeColor = Color.Red;
                    }
                    if (txtEmail.Text == "")
                    {
                        txtEmail.Text = "Nhập Email";
                        txtEmail.ForeColor = Color.Red;
                    }
                    if (rdbNam.Checked == false && rdbNu.Checked==false)
                    {
                        rdbNam.ForeColor= Color.Red;
                        rdbNu.ForeColor= Color.Red;
                    }
                    if (txthoten.Text == "")
                    {
                        txtEmail.Text = "Nhập họ tên";
                        txtEmail.ForeColor = Color.Red;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Thông tin không hợp lệ!");
            }
        }

        private void rdbNam_CheckedChanged(object sender, EventArgs e)
        {
            rdbNam.ForeColor = Color.Black;
            rdbNu.ForeColor = Color.Black;
        }

        private void rdbNu_CheckedChanged(object sender, EventArgs e)
        {
            rdbNam.ForeColor = Color.Black;
            rdbNu.ForeColor = Color.Black;
        }

        private void formDatLich_Load(object sender, EventArgs e)
        {
            dtpThoiGian.Format = DateTimePickerFormat.Custom;
            dtpThoiGian.CustomFormat = "MMMM/dd/yyyy/dddd";
        }
    }
}
