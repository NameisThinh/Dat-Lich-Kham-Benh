using DoAn.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace DoAn
{

    public partial class formDatLich : Form
    {
        //private formQuanLy form1;

        Model1 db = new Model1();
        public formDatLich()
        {
            InitializeComponent();
        }
        private void formDatLich_Load(object sender, EventArgs e)
        {
            txtKhac.Visible = false;
            List<BACSI> listBS = db.BACSIs.ToList();
            comboboxBacSi(listBS);
            cbbBacSi.SelectedIndex = -1;
            dtpThoiGian.MinDate = DateTime.Now;
            dtpThoiGian.MaxDate = DateTime.Now.AddMonths(1);
        }
        private void comboboxBacSi(List<BACSI> listKhoa)
        {
            this.cbbBacSi.DataSource = listKhoa;
            this.cbbBacSi.DisplayMember = "TENBS";
            this.cbbBacSi.ValueMember = "MABS";


        }
        private void rdbkhac_CheckedChanged(object sender, EventArgs e)
        {

            if (rdbkhac.Checked == true)
            {
                txtKhac.Visible = true;
            }
            else
            {
                txtKhac.Visible = false;
            }
        }

        private void btnDatLich_Click(object sender, EventArgs e)
        {
            try
            {
                NHANVIEN nv = new NHANVIEN();
                if (txthoten.Text != "" && txtEmail.Text != "" && txtSdt.Text != "")
                {
                    if (txtNamsinh.Text.Length == 4) //&& int.Parse(txtNamsinh.Text) <= DateTime.Now.Year && int.Parse(txtNamsinh.Text) >= 1900)
                    {
                        try 
                        {
                            int.Parse(txtNamsinh.Text);    
                            if(txtSdt.Text.Length == 10 && txtSdt.Text[0] == '0') 
                            {
                                try
                                {
                                    int.Parse(txtSdt.Text);
                                    if (checkEmail(txtEmail.Text) == true)
                                    {
                                        BENHNHAN bn = new BENHNHAN()
                                        {
                                            TENBN = txthoten.Text,
                                            NAMSINH = int.Parse(txtNamsinh.Text),
                                            GIOITINH = rdbNam.Checked ? true : false,
                                            EMAIL = txtEmail.Text,
                                            SDT = txtSdt.Text,
                                        };
                                        PHIEUDATLICH pdl = new PHIEUDATLICH()
                                        {
                                            NGAYLAPPHIEU = dtpThoiGian.Value,
                                            MABN = bn.MABN,
                                        };
                                        CTPHIEUDATLICH ct = new CTPHIEUDATLICH()
                                        {
                                            MAPHIEUDL = pdl.MAPHIEUDL,
                                            MABS = cbbBacSi.SelectedValue.ToString(),
                                            DAKHAMTAI = rdb115.Checked ? rdb115.Text : (rdbNhidong.Checked ? rdbNhidong.Text : txtKhac.Text),
                                            LYDO = txtLyDo.Text,
                                            TINHTRANG = false,
                                        };
                                        db.BENHNHANs.Add(bn);
                                        db.PHIEUDATLICHes.Add(pdl);
                                        db.CTPHIEUDATLICHes.Add(ct);
                                        db.SaveChanges();
                                        MessageBox.Show("Đăng ký thành công!. Đợi kết quả đăng ký tại Email");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Sai Email");
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Sai SDT");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Sai SDT.");
                            }        
                        }
                        catch
                        {
                            MessageBox.Show("Sai năm sinh.");
                        } 
                    }
                    else
                    {
                        MessageBox.Show("Sai năm sinh.");
                    }
                }
                else
                {
                    MessageBox.Show("Nhập đủ thông tin cần thiết");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // MessageBox.Show("Thông tin không hợp lệ!");
            }
        }
        private bool checkEmail(string s)
        {

            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            if(Regex.IsMatch(s, pattern)) 
            {
                return true;
            }
            else
            {
                return false;
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

    }
}
