using DoAn.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class formDangNhap : Form
    {
        public formDangNhap()
        {
            InitializeComponent();
        }
        public bool check =true;
        static Model1 context = new Model1();
        public string matk = "";
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
               TAIKHOAN dn = context.TAIKHOANs.First(p => p.TENDANGNHAP == txtTenDangNhap.Text && p.MATKHAU == txtMatKhau.Text);
                if (dn != null)
                {
                    check = false;
                    this.Hide();
                }
                matk = dn.MATK;
            }
            catch
            {
                MessageBox.Show("sai tên đăng nhập hoặc mật khẩu!");
            }
        }

        private void formDangNhap_Load(object sender, EventArgs e)
        {
            try
            {
                
                List<TAIKHOAN> facultyList = context.TAIKHOANs.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
