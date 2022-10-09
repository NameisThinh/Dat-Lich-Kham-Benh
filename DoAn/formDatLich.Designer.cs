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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDatLich = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.txtNamsinh = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdb115 = new System.Windows.Forms.RadioButton();
            this.rdbNhidong = new System.Windows.Forms.RadioButton();
            this.rdbkhac = new System.Windows.Forms.RadioButton();
            this.txtKhac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpThoiGian = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(18, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(577, 422);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnDatLich
            // 
            this.btnDatLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDatLich.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDatLich.Location = new System.Drawing.Point(232, 1141);
            this.btnDatLich.Name = "btnDatLich";
            this.btnDatLich.Size = new System.Drawing.Size(564, 87);
            this.btnDatLich.TabIndex = 5;
            this.btnDatLich.Text = "Đặt lịch";
            this.btnDatLich.UseVisualStyleBackColor = true;
            this.btnDatLich.Click += new System.EventHandler(this.btnDatLich_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.dtpThoiGian);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtNamsinh);
            this.groupBox1.Controls.Add(this.txtLyDo);
            this.groupBox1.Controls.Add(this.txtSdt);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.rdbNu);
            this.groupBox1.Controls.Add(this.rdbNam);
            this.groupBox1.Controls.Add(this.txthoten);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.Location = new System.Drawing.Point(56, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(919, 1110);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bệnh nhân";
            // 
            // txthoten
            // 
            this.txthoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txthoten.ForeColor = System.Drawing.Color.Silver;
            this.txthoten.Location = new System.Drawing.Point(441, 38);
            this.txthoten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txthoten.Multiline = true;
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(441, 42);
            this.txthoten.TabIndex = 0;
            this.txthoten.Click += new System.EventHandler(this.txthoten_Click);
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rdbNam.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdbNam.Location = new System.Drawing.Point(441, 118);
            this.rdbNam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(95, 33);
            this.rdbNam.TabIndex = 2;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            this.rdbNam.CheckedChanged += new System.EventHandler(this.rdbNam_CheckedChanged);
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rdbNu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdbNu.Location = new System.Drawing.Point(569, 118);
            this.rdbNu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(75, 33);
            this.rdbNu.TabIndex = 3;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            this.rdbNu.CheckedChanged += new System.EventHandler(this.rdbNu_CheckedChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtEmail.ForeColor = System.Drawing.Color.Silver;
            this.txtEmail.Location = new System.Drawing.Point(441, 187);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(441, 45);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            // 
            // txtSdt
            // 
            this.txtSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtSdt.ForeColor = System.Drawing.Color.Silver;
            this.txtSdt.Location = new System.Drawing.Point(441, 263);
            this.txtSdt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSdt.Multiline = true;
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(441, 46);
            this.txtSdt.TabIndex = 5;
            this.txtSdt.Click += new System.EventHandler(this.txtSdt_Click);
            // 
            // txtLyDo
            // 
            this.txtLyDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtLyDo.ForeColor = System.Drawing.Color.Silver;
            this.txtLyDo.Location = new System.Drawing.Point(15, 870);
            this.txtLyDo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLyDo.Multiline = true;
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(843, 202);
            this.txtLyDo.TabIndex = 6;
            this.txtLyDo.Text = "Lý do đăng ký khám bệnh.";
            this.txtLyDo.Click += new System.EventHandler(this.txtLyDo_Click);
            // 
            // txtNamsinh
            // 
            this.txtNamsinh.ForeColor = System.Drawing.Color.Silver;
            this.txtNamsinh.Location = new System.Drawing.Point(441, 348);
            this.txtNamsinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNamsinh.Name = "txtNamsinh";
            this.txtNamsinh.Size = new System.Drawing.Size(441, 35);
            this.txtNamsinh.TabIndex = 16;
            this.txtNamsinh.Click += new System.EventHandler(this.txtNamsinh_Click);
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
            this.groupBox2.Size = new System.Drawing.Size(843, 247);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đã khám Tại Bệnh Viện :";
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
            // txtKhac
            // 
            this.txtKhac.Location = new System.Drawing.Point(161, 157);
            this.txtKhac.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKhac.Name = "txtKhac";
            this.txtKhac.Size = new System.Drawing.Size(538, 35);
            this.txtKhac.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(81, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Họ tên:";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(81, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Năm sinh";
            // 
            // dtpThoiGian
            // 
            this.dtpThoiGian.Location = new System.Drawing.Point(441, 441);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.Size = new System.Drawing.Size(441, 35);
            this.dtpThoiGian.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(81, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 29);
            this.label6.TabIndex = 21;
            this.label6.Text = "Thời gian đặt lịch";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnDatLich);
            this.panel1.Location = new System.Drawing.Point(649, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 1236);
            this.panel1.TabIndex = 23;
            // 
            // formDatLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1665, 1260);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "formDatLich";
            this.Text = "formDatLich";
            this.Load += new System.EventHandler(this.formDatLich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
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
        private System.Windows.Forms.TextBox txtNamsinh;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Panel panel1;
    }
}