using DoAn.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        Model2 db = new Model2();
        public formDatLich()
        {
            InitializeComponent();
            txtKhac.Visible = false;
            groupBox3.Visible = false;
            List<BACSI> listBS = db.BACSIs.ToList();
            comboboxBacSi(listBS);
            

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

        private void themthongtin(List<BENHNHAN> thongtinbenhnhan)
        {
            
            
        }
        private void comboboxBacSi(List<BACSI> listBS)
        {
            this.cbbBacSi.DataSource = listBS;
            this.cbbBacSi.DisplayMember ="TenBS";
            this.cbbBacSi.ValueMember = "MaBS";
        
            
        }
        public void getData(string data)
        {
                
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
                    if (txtSdt.Text == "")
                    {
                        txtSdt.Text = "Nhập họ tên";
                        txtSdt.ForeColor = Color.Red;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Thông tin không hợp lệ!");
            }
            BENHNHAN bn = new BENHNHAN();

            bn.TENBN = txthoten.Text;
            bn.GIOITINH = rdbNam;
            bn.Email = txtEmail.Text;
            bn.SDT = txtSdt.Text;
            bn.NAMSINH = int.Parse(txtNamsinh.Text);
            bn.NGAYDAT = DateTime.UtcNow;
            bn.GHICHU = txtLyDo.Text;
               
            db.BENHNHANs.Add(bn);
              

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

            groupBox3.Visible = true;

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

        private void groupBoxBacSi_Enter(object sender, EventArgs e)
        {
          
        }
        /// GROUPBOX hiển thị bác sĩ
        private void groupBox3_Enter(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
