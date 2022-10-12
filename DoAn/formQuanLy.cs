using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using DoAn.Model;

namespace DoAn
{
     
    public partial class formQuanLy : Form
    {
        Model2 db = new Model2();
        public formQuanLy()
        {
            InitializeComponent();
        }

        public class Email
        {
            public static string Address = "phuchieu1213@gmail.com"; //Địa chỉ email của bạn
            public static string Password = "rdjcfyuvacvznsvm"; //Mật khẩu ứng dụng

            public void Send(string sendTo, string subject, string message)
            {
                using (SmtpClient smtp = new SmtpClient())
                {
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.Credentials = new NetworkCredential(Address, Password);
                    smtp.Send(Address, sendTo, subject, message);
                }
            }
        }



        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                Email email = new Email();
                //tạo list lưu email vào 
                // dung for  duyệt list và gửi nội dung
                email.Send("phuchieu20.01@gmail.com", "Gửi Demo", "Xin chào, đây là email demo");
                //
            }
            catch
            {
                MessageBox.Show("Gửi mail thất bại...!");
            }


        }

        private void formQuanLy_Load(object sender, EventArgs e)
        {
            
        }
        public void list(List<BENHNHAN> listBenhNhan)
        {
            dgvthongTin.Rows.Clear(); 

            foreach (var item in listBenhNhan)
            {
                int index = dgvthongTin.Rows.Add();
                dgvthongTin.Rows[index].Cells[0].Value = (dgvthongTin.Rows.Count +1).ToString();
                dgvthongTin.Rows[index].Cells[1].Value = item.TENBN;
                dgvthongTin.Rows[index].Cells[2].Value =item.GIOITINH;       
                dgvthongTin.Rows[index].Cells[3].Value = item.SDT;
                dgvthongTin.Rows[index].Cells[4].Value = item.Email;
                dgvthongTin.Rows[index].Cells[5].Value = item.NGAYDAT;
                dgvthongTin.Rows[index].Cells[6].Value = item.GHICHU;

            }
        }
        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            grbTraCuu.Visible = true;
           
     
        }

        private void dgvthongTin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            if(rdbDaXacNhan.Checked == true)
            {
                dgvthongTin.Rows.
            }
            if(rdbChuaXacNhan.Checked == true)
            {

            }

        }
    }
}
