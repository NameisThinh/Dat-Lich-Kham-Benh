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
            List<BACSI> listKhoa = db.BACSIs.ToList();
            comboboxKhoa(listKhoa);
            cbbBacSi.SelectedIndex = -1;
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


        private void txtNamsinh_Click_1(object sender, EventArgs e)
        {
            txtNamsinh.Text = "";
            txtNamsinh.ForeColor = Color.Black;
        }


        private void txtLyDo_Click(object sender, EventArgs e)
        {
            txtLyDo.Text = "";
            txtLyDo.ForeColor = Color.Black;
        }

        private void comboboxKhoa(List<BACSI> listKhoa)
        {
            this.cbbBacSi.DataSource = listKhoa;
            this.cbbBacSi.DisplayMember ="TENBS";
            this.cbbBacSi.ValueMember = "MABS";
        
            
        }
        public void getData(string data)
        {
                
        }
         
        private void btnDatLich_Click(object sender, EventArgs e)
        {
            try
            {
                NHANVIEN nv = new NHANVIEN();
                if(txthoten.Text!=""&& txtEmail.Text != "" && txtSdt.Text != "")
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
                        DAKHAMTAI = rdb115.Checked? rdb115.Text:(rdbNhidong.Checked? rdbNhidong.Text:txtKhac.Text),
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
                    if (txtSdt.Text == "")
                    {
                        txtSdt.Text = "Nhập SDT";
                        txtSdt.ForeColor = Color.Red;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Thông tin không hợp lệ!");
            }
            
              

           // Image a = Image.FromFile(@"C:\\Users\\MSIs\\source\\repos\\DoAn\\DoAn\\Image\\" + pictureBacSi.Name + ".jpg");
            //pictureBacSi.Image = Image.FromFile(@"C:\\Users\\MSIs\\source\\repos\\DoAn\\DoAn\\Image\\1.jpg");
            List<BACSI> listBS = db.BACSIs.ToList();
     
                foreach (var item1 in listBS)
                  {
                      if(item1.TENBS.Contains(cbbBacSi.Text)==true)                   
                      {
                               //  pictureBacSi.Image = a;
                                txtHoTenBS.Text = item1.TENBS;
                                txtHocHam.Text = item1.HOCHAM;
                      }
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






        private void cbbBacSi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = cbbBacSi.GetItemText(cbbBacSi.SelectedValue);
            BACSI bs = db.BACSIs.FirstOrDefault(p => p.MABS == s);
            if (bs != null)
            {
                txtHoTenBS.Text = bs.TENBS;
                txtHocHam.Text = bs.HOCHAM;
            }
        }


    }
}
