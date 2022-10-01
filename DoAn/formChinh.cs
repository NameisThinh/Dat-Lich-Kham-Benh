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
    public partial class formChinh : Form
    {
        public formChinh()
        {
            InitializeComponent();
        }

        public void loadFormNoiDung(Form formNoiDung )
        {
            
            formNoiDung.FormBorderStyle = FormBorderStyle.None;
            formNoiDung.MdiParent = this;
            formNoiDung.Size = panel3.Size;
            panel3.Controls.Add( formNoiDung );
            panel3.Tag = formNoiDung;
            formNoiDung.Show();
            
        }
        public void loadFormQuanLy()
        {
            tsTraCuu.Visible = true;
            tsQuanLy.Visible = true;
            
            

        }

        private void formChinh_Load(object sender, EventArgs e)
        {
            tsTraCuu.Visible = false;
            tsQuanLy.Visible = false;
            tsDangXuat.Enabled = false;
            panel3.Controls.Clear();
            formGioiThieu gt = new formGioiThieu();
            loadFormNoiDung(gt);
            toolStrip1.Site = panel2.Site;
        }

        private void tsDatLich_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            formDatLich dl = new formDatLich();
            loadFormNoiDung(dl);
        }

        private void tsThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsHuongDan_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            formHuongDan hd = new formHuongDan();
            loadFormNoiDung(hd);

        }

        private void tsTraCuu_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            formTraCuu tc = new formTraCuu();
            loadFormNoiDung(tc);

        }

        private void tsGioiThieu_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            formGioiThieu gt = new formGioiThieu();
            loadFormNoiDung(gt);

        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDangNhap dn = new formDangNhap();
            dn.ShowDialog();
            loadFormQuanLy();
            if (tsQuanLy.Visible == true)
            {
                tsDangNhap.Enabled = false;
                tsDangXuat.Enabled = true;
                panel3.Controls.Clear();
                formQuanLy ql = new formQuanLy();
                loadFormNoiDung(ql);

            }
           
        }

        private void btnHenDatLich_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            formBtnDatLich dl = new formBtnDatLich();
            loadFormNoiDung(dl);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tsQuanLy_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            formQuanLy ql = new formQuanLy();
            loadFormNoiDung(ql);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formChinh_Load(sender, e);
            tsDangNhap.Enabled = true;

        }
    }
}
