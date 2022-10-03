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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKhac = new System.Windows.Forms.TextBox();
            this.rdbkhac = new System.Windows.Forms.RadioButton();
            this.rdbNhidong = new System.Windows.Forms.RadioButton();
            this.rdb115 = new System.Windows.Forms.RadioButton();
            this.txtNamsinh = new System.Windows.Forms.TextBox();
            this.txtThongTinThem = new System.Windows.Forms.TextBox();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtNamsinh);
            this.groupBox1.Controls.Add(this.txtThongTinThem);
            this.groupBox1.Controls.Add(this.txtLyDo);
            this.groupBox1.Controls.Add(this.txtSdt);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.rdbNu);
            this.groupBox1.Controls.Add(this.rdbNam);
            this.groupBox1.Controls.Add(this.txthoten);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(603, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(982, 950);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bệnh nhân";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKhac);
            this.groupBox2.Controls.Add(this.rdbkhac);
            this.groupBox2.Controls.Add(this.rdbNhidong);
            this.groupBox2.Controls.Add(this.rdb115);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 406);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(923, 247);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đã khám Tại Bệnh Viện :";
            // 
            // txtKhac
            // 
            this.txtKhac.Location = new System.Drawing.Point(160, 159);
            this.txtKhac.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKhac.Name = "txtKhac";
            this.txtKhac.Size = new System.Drawing.Size(451, 35);
            this.txtKhac.TabIndex = 18;
            // 
            // rdbkhac
            // 
            this.rdbkhac.AutoSize = true;
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
            this.rdbNhidong.Location = new System.Drawing.Point(549, 88);
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
            this.rdb115.Location = new System.Drawing.Point(26, 88);
            this.rdb115.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdb115.Name = "rdb115";
            this.rdb115.Size = new System.Drawing.Size(199, 33);
            this.rdb115.TabIndex = 12;
            this.rdb115.TabStop = true;
            this.rdb115.Text = "Bệnh Viện 115";
            this.rdb115.UseVisualStyleBackColor = true;
            // 
            // txtNamsinh
            // 
            this.txtNamsinh.ForeColor = System.Drawing.Color.Silver;
            this.txtNamsinh.Location = new System.Drawing.Point(28, 342);
            this.txtNamsinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNamsinh.Name = "txtNamsinh";
            this.txtNamsinh.Size = new System.Drawing.Size(417, 35);
            this.txtNamsinh.TabIndex = 16;
            this.txtNamsinh.Text = "Năm sinh";
            this.txtNamsinh.Click += new System.EventHandler(this.txtNamsinh_Click);
            // 
            // txtThongTinThem
            // 
            this.txtThongTinThem.ForeColor = System.Drawing.Color.Silver;
            this.txtThongTinThem.Location = new System.Drawing.Point(15, 802);
            this.txtThongTinThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtThongTinThem.Multiline = true;
            this.txtThongTinThem.Name = "txtThongTinThem";
            this.txtThongTinThem.Size = new System.Drawing.Size(923, 110);
            this.txtThongTinThem.TabIndex = 11;
            this.txtThongTinThem.Text = "Thông tin thêm ( Nếu có )";
            this.txtThongTinThem.Click += new System.EventHandler(this.txtThongTinThem_Click);
            // 
            // txtLyDo
            // 
            this.txtLyDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLyDo.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtLyDo.Location = new System.Drawing.Point(15, 676);
            this.txtLyDo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLyDo.Multiline = true;
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(923, 104);
            this.txtLyDo.TabIndex = 6;
            this.txtLyDo.Text = "Lý do đăng ký khám bệnh.";
            this.txtLyDo.Click += new System.EventHandler(this.txtLyDo_Click);
            // 
            // txtSdt
            // 
            this.txtSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSdt.ForeColor = System.Drawing.Color.Silver;
            this.txtSdt.Location = new System.Drawing.Point(28, 252);
            this.txtSdt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSdt.Multiline = true;
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(417, 46);
            this.txtSdt.TabIndex = 5;
            this.txtSdt.Text = "Số điện thoại";
            this.txtSdt.Click += new System.EventHandler(this.txtSdt_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Silver;
            this.txtEmail.Location = new System.Drawing.Point(28, 180);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(417, 45);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Text = "Email(*)";
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNu.Location = new System.Drawing.Point(168, 122);
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
            this.rdbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNam.Location = new System.Drawing.Point(40, 122);
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
            this.txthoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthoten.ForeColor = System.Drawing.Color.Silver;
            this.txthoten.Location = new System.Drawing.Point(28, 47);
            this.txthoten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txthoten.Multiline = true;
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(417, 42);
            this.txthoten.TabIndex = 0;
            this.txthoten.Text = "Họ và tên bệnh nhân (*)";
            this.txthoten.Click += new System.EventHandler(this.txthoten_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pictureBox1.Location = new System.Drawing.Point(18, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 180);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(467, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(458, 35);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button1.Location = new System.Drawing.Point(757, 992);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(564, 87);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // formDatLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1705, 1191);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "formDatLich";
            this.Text = "formDatLich";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtThongTinThem;
        private System.Windows.Forms.TextBox txtKhac;
        private System.Windows.Forms.TextBox txtNamsinh;
        private System.Windows.Forms.RadioButton rdbkhac;
        private System.Windows.Forms.RadioButton rdbNhidong;
        private System.Windows.Forms.RadioButton rdb115;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
    }
}