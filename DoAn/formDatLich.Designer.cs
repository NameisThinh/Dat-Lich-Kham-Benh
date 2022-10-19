namespace DoAn
{
    partial class formDatLich
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDatLich = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbBacSi = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpThoiGian = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKhac = new System.Windows.Forms.TextBox();
            this.rdbkhac = new System.Windows.Forms.RadioButton();
            this.rdbNhidong = new System.Windows.Forms.RadioButton();
            this.rdb115 = new System.Windows.Forms.RadioButton();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.txtNamsinh = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBoxBacSi = new System.Windows.Forms.GroupBox();
            this.txtHocHam = new System.Windows.Forms.TextBox();
            this.txtHoTenBS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBacSi = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxBacSi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBacSi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDatLich
            // 
            this.btnDatLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDatLich.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDatLich.Location = new System.Drawing.Point(1347, 1184);
            this.btnDatLich.Name = "btnDatLich";
            this.btnDatLich.Size = new System.Drawing.Size(564, 88);
            this.btnDatLich.TabIndex = 5;
            this.btnDatLich.Text = "Đặt lịch";
            this.btnDatLich.UseVisualStyleBackColor = true;
            this.btnDatLich.Click += new System.EventHandler(this.btnDatLich_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.cbbBacSi);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtpThoiGian);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtLyDo);
            this.groupBox1.Controls.Add(this.txtNamsinh);
            this.groupBox1.Controls.Add(this.txtSdt);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.rdbNu);
            this.groupBox1.Controls.Add(this.rdbNam);
            this.groupBox1.Controls.Add(this.txthoten);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.Location = new System.Drawing.Point(1172, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(896, 1128);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // cbbBacSi
            // 
            this.cbbBacSi.FormattingEnabled = true;
            this.cbbBacSi.Location = new System.Drawing.Point(441, 430);
            this.cbbBacSi.Name = "cbbBacSi";
            this.cbbBacSi.Size = new System.Drawing.Size(440, 37);
            this.cbbBacSi.TabIndex = 23;
            this.cbbBacSi.SelectedIndexChanged += new System.EventHandler(this.cbbBacSi_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(86, 438);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 29);
            this.label9.TabIndex = 22;
            this.label9.Text = "Bác sĩ";
            // 
            // dtpThoiGian
            // 
            this.dtpThoiGian.CustomFormat = "yyy-MM-dd";
            this.dtpThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGian.Location = new System.Drawing.Point(441, 505);
            this.dtpThoiGian.MinDate = new System.DateTime(2022, 10, 12, 0, 0, 0, 0);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.Size = new System.Drawing.Size(440, 35);
            this.dtpThoiGian.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(81, 509);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 29);
            this.label6.TabIndex = 21;
            this.label6.Text = "Thời gian đặt lịch";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(81, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Năm sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(81, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 29);
            this.label4.TabIndex = 21;
            this.label4.Text = "SDT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(81, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(81, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Giới tính:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(81, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Họ tên:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKhac);
            this.groupBox2.Controls.Add(this.rdbkhac);
            this.groupBox2.Controls.Add(this.rdbNhidong);
            this.groupBox2.Controls.Add(this.rdb115);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox2.Location = new System.Drawing.Point(15, 580);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(867, 247);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đã khám Tại Bệnh Viện :";
            // 
            // txtKhac
            // 
            this.txtKhac.Location = new System.Drawing.Point(160, 156);
            this.txtKhac.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKhac.Name = "txtKhac";
            this.txtKhac.Size = new System.Drawing.Size(538, 35);
            this.txtKhac.TabIndex = 18;
            // 
            // rdbkhac
            // 
            this.rdbkhac.AutoSize = true;
            this.rdbkhac.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdbkhac.Location = new System.Drawing.Point(26, 159);
            this.rdbkhac.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbkhac.Name = "rdbkhac";
            this.rdbkhac.Size = new System.Drawing.Size(104, 33);
            this.rdbkhac.TabIndex = 14;
            this.rdbkhac.TabStop = true;
            this.rdbkhac.Text = "Khác ";
            this.rdbkhac.UseVisualStyleBackColor = true;
            this.rdbkhac.CheckedChanged += new System.EventHandler(this.rdbkhac_CheckedChanged);
            // 
            // rdbNhidong
            // 
            this.rdbNhidong.AutoSize = true;
            this.rdbNhidong.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdbNhidong.Location = new System.Drawing.Point(438, 88);
            this.rdbNhidong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbNhidong.Name = "rdbNhidong";
            this.rdbNhidong.Size = new System.Drawing.Size(261, 33);
            this.rdbNhidong.TabIndex = 13;
            this.rdbNhidong.TabStop = true;
            this.rdbNhidong.Text = "Bệnh Viện Nhi Đồng";
            this.rdbNhidong.UseVisualStyleBackColor = true;
            // 
            // rdb115
            // 
            this.rdb115.AutoSize = true;
            this.rdb115.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdb115.Location = new System.Drawing.Point(26, 88);
            this.rdb115.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdb115.Name = "rdb115";
            this.rdb115.Size = new System.Drawing.Size(199, 33);
            this.rdb115.TabIndex = 12;
            this.rdb115.TabStop = true;
            this.rdb115.Text = "Bệnh Viện 115";
            this.rdb115.UseVisualStyleBackColor = true;
            // 
            // txtLyDo
            // 
            this.txtLyDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtLyDo.ForeColor = System.Drawing.Color.Silver;
            this.txtLyDo.Location = new System.Drawing.Point(15, 870);
            this.txtLyDo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLyDo.Multiline = true;
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(866, 202);
            this.txtLyDo.TabIndex = 6;
            this.txtLyDo.Text = "Lý do đăng ký khám bệnh.";
            this.txtLyDo.Click += new System.EventHandler(this.txtLyDo_Click);
            // 
            // txtNamsinh
            // 
            this.txtNamsinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNamsinh.ForeColor = System.Drawing.Color.Silver;
            this.txtNamsinh.Location = new System.Drawing.Point(441, 338);
            this.txtNamsinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNamsinh.Multiline = true;
            this.txtNamsinh.Name = "txtNamsinh";
            this.txtNamsinh.Size = new System.Drawing.Size(440, 46);
            this.txtNamsinh.TabIndex = 5;
            this.txtNamsinh.Click += new System.EventHandler(this.txtNamsinh_Click_1);
            // 
            // txtSdt
            // 
            this.txtSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtSdt.ForeColor = System.Drawing.Color.Silver;
            this.txtSdt.Location = new System.Drawing.Point(441, 262);
            this.txtSdt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSdt.Multiline = true;
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(440, 46);
            this.txtSdt.TabIndex = 5;
            this.txtSdt.Click += new System.EventHandler(this.txtSdt_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtEmail.ForeColor = System.Drawing.Color.Silver;
            this.txtEmail.Location = new System.Drawing.Point(441, 188);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(440, 45);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rdbNu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdbNu.Location = new System.Drawing.Point(568, 119);
            this.rdbNu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(75, 33);
            this.rdbNu.TabIndex = 3;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rdbNam.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdbNam.Location = new System.Drawing.Point(441, 119);
            this.rdbNam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(95, 33);
            this.rdbNam.TabIndex = 2;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // txthoten
            // 
            this.txthoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txthoten.ForeColor = System.Drawing.Color.Silver;
            this.txthoten.Location = new System.Drawing.Point(441, 38);
            this.txthoten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txthoten.Multiline = true;
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(440, 42);
            this.txthoten.TabIndex = 0;
            this.txthoten.Click += new System.EventHandler(this.txthoten_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnDatLich);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2241, 1335);
            this.panel1.TabIndex = 23;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBoxBacSi);
            this.groupBox3.Controls.Add(this.pictureBacSi);
            this.groupBox3.Location = new System.Drawing.Point(74, 23);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(1034, 831);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // groupBoxBacSi
            // 
            this.groupBoxBacSi.Controls.Add(this.txtHocHam);
            this.groupBoxBacSi.Controls.Add(this.txtHoTenBS);
            this.groupBoxBacSi.Controls.Add(this.label8);
            this.groupBoxBacSi.Controls.Add(this.label7);
            this.groupBoxBacSi.Location = new System.Drawing.Point(130, 495);
            this.groupBoxBacSi.Name = "groupBoxBacSi";
            this.groupBoxBacSi.Size = new System.Drawing.Size(758, 231);
            this.groupBoxBacSi.TabIndex = 7;
            this.groupBoxBacSi.TabStop = false;
            this.groupBoxBacSi.Text = "Bác sĩ";
            // 
            // txtHocHam
            // 
            this.txtHocHam.Enabled = false;
            this.txtHocHam.Location = new System.Drawing.Point(158, 155);
            this.txtHocHam.Multiline = true;
            this.txtHocHam.Name = "txtHocHam";
            this.txtHocHam.Size = new System.Drawing.Size(558, 38);
            this.txtHocHam.TabIndex = 1;
            // 
            // txtHoTenBS
            // 
            this.txtHoTenBS.Enabled = false;
            this.txtHoTenBS.Location = new System.Drawing.Point(158, 66);
            this.txtHoTenBS.Multiline = true;
            this.txtHoTenBS.Name = "txtHoTenBS";
            this.txtHoTenBS.Size = new System.Drawing.Size(558, 38);
            this.txtHoTenBS.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Học hàm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Họ tên";
            // 
            // pictureBacSi
            // 
            this.pictureBacSi.BackColor = System.Drawing.Color.Silver;
            this.pictureBacSi.Location = new System.Drawing.Point(274, 33);
            this.pictureBacSi.Name = "pictureBacSi";
            this.pictureBacSi.Size = new System.Drawing.Size(471, 403);
            this.pictureBacSi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBacSi.TabIndex = 6;
            this.pictureBacSi.TabStop = false;
            // 
            // formDatLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2241, 1335);
            this.Controls.Add(this.panel1);
            this.Name = "formDatLich";
            this.Text = "formDatLich";
            this.Load += new System.EventHandler(this.formDatLich_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBoxBacSi.ResumeLayout(false);
            this.groupBoxBacSi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBacSi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDatLich;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpThoiGian;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtKhac;
        private System.Windows.Forms.RadioButton rdbkhac;
        private System.Windows.Forms.RadioButton rdbNhidong;
        private System.Windows.Forms.RadioButton rdb115;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxBacSi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBacSi;
        private System.Windows.Forms.TextBox txtHocHam;
        private System.Windows.Forms.TextBox txtHoTenBS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNamsinh;
        private System.Windows.Forms.ComboBox cbbBacSi;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}