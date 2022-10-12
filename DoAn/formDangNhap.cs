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
        static Model2 context = new Model2();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                User dn = context.Users.First(p => p.taikhoan == txtTenDangNhap.Text && p.matkhau == txtMatKhau.Text);
                if (dn != null)
                {
                    check = false;
                    this.Hide();
                }
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
                
                List<User> facultyList = context.Users.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
