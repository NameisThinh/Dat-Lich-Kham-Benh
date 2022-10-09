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


namespace DoAn
{
     
    public partial class formQuanLy : Form
    {
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
            Email email = new Email();
            //tạo list lưu email vào 
            // dung for  duyệt list và gửi nội dung
            email.Send("phuchieu20.01@gmail.com", "Gửi Demo", "Xin chào, đây là email demo");
            //
        }

        private void formQuanLy_Load(object sender, EventArgs e)
        {
            
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            grbTraCuu.Visible = true;
        }
    }
}
