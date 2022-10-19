using DoAn.Model;
using Microsoft.Reporting.WinForms;
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
    public partial class formTraCuu : Form
    {
        public formTraCuu()
        {
            InitializeComponent();
        }
        Model1 db = new Model1();

        private void formTraCuu_Load(object sender, EventArgs e)
        {
            cbbThang.SelectedIndex = 0;
            rdoThang.Checked = true;
            cbbThang.Enabled = true;
            dtp1.Enabled = false;   
            dtp2.Enabled = false;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(rdoThang.Checked == true)
            {
                cbbThang.Enabled=true;
                List<CTPHIEUDATLICH> ct = db.CTPHIEUDATLICHes.ToList();
                List<ThongtinReport> list = new List<ThongtinReport>();
                foreach (var item in ct)
                {
                    DateTime dt = item.PHIEUDATLICH.NGAYLAPPHIEU.Value;
                    if(dt.Month == int.Parse(cbbThang.Text))
                    {
                        ThongtinReport tt = new ThongtinReport();
                        tt.MABN = item.PHIEUDATLICH.BENHNHAN.MABN;
                        tt.TENBN = item.PHIEUDATLICH.BENHNHAN.TENBN;
                        tt.NAMSINH = item.PHIEUDATLICH.BENHNHAN.NAMSINH.Value;
                        tt.EMAIL = item.PHIEUDATLICH.BENHNHAN.EMAIL;
                        tt.SDT = item.PHIEUDATLICH.BENHNHAN.SDT;
                        if (item.TINHTRANG == true)
                        {
                            tt.TINHTRANG = "Đã xác nhận";
                        }
                        else
                        {
                            tt.TINHTRANG = "Chưa xác nhận";
                        }
                        list.Add(tt);
                    }
                    
                }
                this.reportViewer1.LocalReport.ReportPath = "..//..//Report1.rdlc";
                var datasource = new ReportDataSource("DataSet1", list);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(datasource);
                this.reportViewer1.RefreshReport();
            }
            else
            {
               
                List<CTPHIEUDATLICH> ct = db.CTPHIEUDATLICHes.ToList();
                List<ThongtinReport> list = new List<ThongtinReport>();
                foreach (var item in ct)
                {
                    DateTime dt = item.PHIEUDATLICH.NGAYLAPPHIEU.Value;
                    if (dt>= dtp1.Value && dt<= dtp2.Value)
                    {
                        ThongtinReport tt = new ThongtinReport();
                        tt.MABN = item.PHIEUDATLICH.BENHNHAN.MABN;
                        tt.TENBN = item.PHIEUDATLICH.BENHNHAN.TENBN;
                        tt.NAMSINH = item.PHIEUDATLICH.BENHNHAN.NAMSINH.Value;
                        tt.EMAIL = item.PHIEUDATLICH.BENHNHAN.EMAIL;
                        tt.SDT = item.PHIEUDATLICH.BENHNHAN.SDT;
                        if (item.TINHTRANG == true)
                        {
                            tt.TINHTRANG = "Đã xác nhận";
                        }
                        else
                        {
                            tt.TINHTRANG = "Chưa xác nhận";
                        }
                        list.Add(tt);
                    }

                }
                this.reportViewer1.LocalReport.ReportPath = "..//..//Report1.rdlc";
                var datasource = new ReportDataSource("DataSet1", list);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(datasource);
                this.reportViewer1.RefreshReport();

            } 
        }

        private void rdoThang_CheckedChanged(object sender, EventArgs e)
        {
            cbbThang.Enabled = true;
            dtp1.Enabled = false;
            dtp2.Enabled = false;
        }

        private void rdoThoigian_CheckedChanged(object sender, EventArgs e)
        {
            cbbThang.Enabled = false;
            dtp1.Enabled = true;
            dtp2.Enabled = true;
        }
    }
}
