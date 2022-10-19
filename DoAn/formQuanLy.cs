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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static DoAn.formQuanLy;

namespace DoAn
{

    public partial class formQuanLy : Form
    {
        Model1 db = new Model1();
        public formQuanLy()
        {
            InitializeComponent();
        }
        private void formQuanLy_Load(object sender, EventArgs e)
        {
            List<CTPHIEUDATLICH> ct = db.CTPHIEUDATLICHes.ToList();
            list(ct,false);
            grbTraCuu.Visible = false;
            rdbDaXacNhan.Checked = true;
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = true;
        }
        public void list(List<CTPHIEUDATLICH> listCTphieudatlich,bool check)
        {
            dgvthongTin.Rows.Clear();

            foreach (var item in listCTphieudatlich)
            {
                if (item.TINHTRANG == check)
                {
                    int index = dgvthongTin.Rows.Add();
                    dgvthongTin.Rows[index].Cells[0].Value = item.PHIEUDATLICH.MAPHIEUDL;
                    dgvthongTin.Rows[index].Cells[1].Value = item.PHIEUDATLICH.BENHNHAN.TENBN;
                    if (item.PHIEUDATLICH.BENHNHAN.GIOITINH == true)
                    {
                        dgvthongTin.Rows[index].Cells[2].Value = "NAM";
                    }
                    else
                    {
                        dgvthongTin.Rows[index].Cells[2].Value = "NỮ";
                    }

                    dgvthongTin.Rows[index].Cells[3].Value = item.PHIEUDATLICH.BENHNHAN.SDT;
                    dgvthongTin.Rows[index].Cells[4].Value = item.PHIEUDATLICH.BENHNHAN.EMAIL;
                    dgvthongTin.Rows[index].Cells[5].Value = item.PHIEUDATLICH.NGAYLAPPHIEU;
                    dgvthongTin.Rows[index].Cells[6].Value = item.LYDO;
                    dgvthongTin.Rows[index].Cells[7].Value = item.TINHTRANG;
                }


            }
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
            //BENHNHAN bn = new BENHNHAN();
            List<CTPHIEUDATLICH> listbn = new List<CTPHIEUDATLICH>();
            bool check;
            int kt = 0;
            listbn.Clear();
            try
            {

                for (int i = 0; i < dgvthongTin.RowCount - 1; i++)
                {
                    DataGridViewRow row = dgvthongTin.Rows[i];
                    check = bool.Parse(row.Cells[7].Value.ToString());
                    if (check == true)
                    {
                        var mabn = int.Parse(row.Cells[0].Value.ToString());
                        var bnhan = db.CTPHIEUDATLICHes.FirstOrDefault(p => p.PHIEUDATLICH.BENHNHAN.MABN == mabn);
                        if (bnhan != null)
                        {
                            listbn.Add(bnhan);
                        }

                    }
                }
                foreach (var item in listbn)
                {
                    var ct = db.CTPHIEUDATLICHes.FirstOrDefault(p => p.PHIEUDATLICH.BENHNHAN.MABN == item.PHIEUDATLICH.BENHNHAN.MABN);
                    if (ct != null)
                    {
                        ct.TINHTRANG = true;
                        db.SaveChanges();
                        DateTime dt = item.PHIEUDATLICH.NGAYLAPPHIEU.Value;
                        
                        email.Send(item.PHIEUDATLICH.BENHNHAN.EMAIL, "XÁC NHẬN ĐĂNG KÝ THÀNH CÔNG!", "Xin chào " + item.PHIEUDATLICH.BENHNHAN.TENBN + ","+"\nCảm ơn bạn đã tin tưởng dịch vụ chăm sóc sức khoẻ Hoàn Mỹ.\nĐơn đăng ký của bạn đã được duyệt.\n\n\tMã số: " + item.PHIEUDATLICH.BENHNHAN.MABN + "\n\tHọ tên: "+item.PHIEUDATLICH.BENHNHAN.TENBN+"\n\tEmail: "+item.PHIEUDATLICH.BENHNHAN.EMAIL+"\n\tSDT: "+item.PHIEUDATLICH.BENHNHAN.SDT + "\n\tThời gian khám là: "+dt.Day+ "/" +dt.Month+"/"+dt.Year+ "\n\nKính mong bạn sắp xếp thời gian đến đúng lịch hẹn.\nXin cảm ơn.!");
                        kt++;   
                    }

                }
                formQuanLy_Load(sender, e);
                if (kt == 0)
                {
                    MessageBox.Show("Vui lòng chọn dữ liệu để cập nhật");
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công");
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Cập nhật thất bại...!");
            }


        }



        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            List<CTPHIEUDATLICH> ct = db.CTPHIEUDATLICHes.Where(p=> p.PHIEUDATLICH.NGAYLAPPHIEU>=dtpThoiGian1.Value && p.PHIEUDATLICH.NGAYLAPPHIEU <= dtpThoiGian2.Value).ToList();
            if (rdbDaXacNhan.Checked == true)
            {
                list(ct, true);
                btnCapNhat.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                list(ct, false);
                btnCapNhat.Enabled=true;    
                btnXoa.Enabled = true;
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xoá?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                List<BENHNHAN> listbn = new List<BENHNHAN>();
                bool check;
                int kt = 0;
                listbn.Clear();
                try
                {

                    for (int i = 0; i < dgvthongTin.RowCount - 1; i++)
                    {
                        DataGridViewRow row = dgvthongTin.Rows[i];
                        check = bool.Parse(row.Cells[7].Value.ToString());
                        if (check == true)
                        {
                            var mabn = int.Parse(row.Cells[0].Value.ToString());
                            var bnhan = db.BENHNHANs.FirstOrDefault(p => p.MABN == mabn);
                            if (bnhan != null)
                            {
                                listbn.Add(bnhan);
                            }

                        }
                    }
                    foreach (var item in listbn)
                    {
                        var ct = db.CTPHIEUDATLICHes.FirstOrDefault(p => p.PHIEUDATLICH.BENHNHAN.MABN == item.MABN);
                        if (ct != null)
                        {
                            PHIEUDATLICH pdl = db.PHIEUDATLICHes.FirstOrDefault(p => p.MAPHIEUDL == ct.MAPHIEUDL);
                            BENHNHAN bn = db.BENHNHANs.FirstOrDefault(p => p.MABN == pdl.MABN);
                            db.CTPHIEUDATLICHes.Remove(ct);
                            db.PHIEUDATLICHes.Remove(pdl);
                            db.BENHNHANs.Remove(bn);
                            db.SaveChanges();
                            kt ++;
                        }

                    }
                    formQuanLy_Load(sender, e);
                    if (kt == 0)
                    {
                        MessageBox.Show("Vui lòng chọn dữ liệu để xoá");
                    }
                    else
                    {
                        MessageBox.Show("xoá thành công");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            grbTraCuu.Visible = true;
            
        }
    }
}
