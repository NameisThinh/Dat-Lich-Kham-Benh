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
            tsTraCuu.Enabled = false;
            formNoiDung.FormBorderStyle = FormBorderStyle.None;
            formNoiDung.MdiParent = this;
            formNoiDung.Size = panel3.Size;
            panel3.Controls.Add( formNoiDung );
            panel3.Tag = formNoiDung;
            formNoiDung.Show();
            
        }

        private void formChinh_Load(object sender, EventArgs e)
        {
            formGioiThieu gt = new formGioiThieu();
            loadFormNoiDung(gt);
            toolStrip1.Site = panel2.Site;
            //lbThongTin.Text = 
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

        }
    }
}
