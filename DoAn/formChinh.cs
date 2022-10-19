using DoAn.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class formChinh : Form
    {
        public formChinh()
        {
            InitializeComponent();
        }
        Model1 db = new Model1();
        
        public void loadNoiDung(Form formNoiDung )
        {
            
            formNoiDung.FormBorderStyle = FormBorderStyle.None;
            formNoiDung.MdiParent = this;
            formNoiDung.Size = panel3.Size;
            panel3.Controls.Add( formNoiDung );
            panel3.Tag = formNoiDung;
            formNoiDung.Show();
            
        }

        private void formChinh_Load(object sender, EventArgs e)
        {
            tsThongKe.Visible = false;
            tsQuanLy.Visible = false;
            tsDangXuat.Enabled = false;
            panel3.Controls.Clear();
            lbThongTin.Text = tsGioiThieu.Text.ToUpper();
            formGioiThieu gt = new formGioiThieu();
            loadNoiDung(gt);
            toolStrip1.Site = panel2.Site;
            lbNhanVien.Visible = false;
        }

        private void tsDatLich_Click(object sender, EventArgs e)
        {
            lbThongTin.Text = tsDatLich.Text.ToUpper();
            panel3.Controls.Clear();
            formDatLich dl = new formDatLich();
            loadNoiDung(dl);
        }

        private void tsThoat_Click(object sender, EventArgs e)
        {
           DialogResult dr =  MessageBox.Show("Xác Nhận Thoát?", "Đóng Chương Trình", MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tsHuongDan_Click(object sender, EventArgs e)
        {
            lbThongTin.Text = tsHuongDan.Text.ToUpper();
            panel3.Controls.Clear();
            formHuongDan hd = new formHuongDan();
            loadNoiDung(hd);

        }

  

        private void tsGioiThieu_Click(object sender, EventArgs e)
        {
            lbThongTin.Text = tsGioiThieu.Text.ToUpper();
            panel3.Controls.Clear();
            formGioiThieu gt = new formGioiThieu();
            loadNoiDung(gt);

        }


        private void tsQuanLy_Click(object sender, EventArgs e)
        {
            lbThongTin.Text = tsQuanLy.Text.ToUpper();
            panel3.Controls.Clear();
            formQuanLy ql = new formQuanLy();
            loadNoiDung(ql);
        }
        private void tsDangNhap_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn là quản trị viên?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                formDangNhap dn = new formDangNhap();               
                dn.ShowDialog();
                if (dn.check == false)
                {
                    tsThongKe.Visible = true;
                    tsQuanLy.Visible = true;
                    tsDatLich.Visible = false;
                    tsHuongDan.Visible = false;
                    tsDangNhap.Enabled = false;
                    tsDangXuat.Enabled = true;
                    panel3.Controls.Clear();
                    formQuanLy ql = new formQuanLy();
                    loadNoiDung(ql);
                    lbThongTin.Text = tsQuanLy.Text.ToUpper();
                    lbNhanVien.Visible = true;
                    NHANVIEN nv = db.NHANVIENs.FirstOrDefault(p=>p.MATK == dn.matk);
                    lbNhanVien.Text = nv.TENNV;
                }
            

            }
        }
        private void tsDangXuat_Click(object sender, EventArgs e)
        {
            formChinh_Load(sender, e);
            tsDatLich.Visible = true;
            tsHuongDan.Visible = true;
            tsDangNhap.Enabled = true;
        }

        private void tsThongKe_Click(object sender, EventArgs e)
        {
            lbThongTin.Text = tsThongKe.Text.ToUpper();
            panel3.Controls.Clear();
            formTraCuu tc = new formTraCuu();
            loadNoiDung(tc);
        }

    }
}
