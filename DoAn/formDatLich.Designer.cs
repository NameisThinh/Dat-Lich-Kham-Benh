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
            this.txtKhac = new System.Windows.Forms.TextBox();
            this.txtNamsinh = new System.Windows.Forms.TextBox();
            this.rdbkhac = new System.Windows.Forms.RadioButton();
            this.rdbNhidong = new System.Windows.Forms.RadioButton();
            this.rdb115 = new System.Windows.Forms.RadioButton();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textSdt = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtNamsinh);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textSdt);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.rdbNu);
            this.groupBox1.Controls.Add(this.rdbNam);
            this.groupBox1.Controls.Add(this.txthoten);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(402, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 617);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bệnh nhân";
            // 
            // txtKhac
            // 
            this.txtKhac.Location = new System.Drawing.Point(107, 102);
            this.txtKhac.Name = "txtKhac";
            this.txtKhac.Size = new System.Drawing.Size(302, 24);
            this.txtKhac.TabIndex = 18;
            // 
            // txtNamsinh
            // 
            this.txtNamsinh.ForeColor = System.Drawing.Color.Silver;
            this.txtNamsinh.Location = new System.Drawing.Point(19, 219);
            this.txtNamsinh.Name = "txtNamsinh";
            this.txtNamsinh.Size = new System.Drawing.Size(516, 24);
            this.txtNamsinh.TabIndex = 16;
            this.txtNamsinh.Text = "Năm sinh";
            // 
            // rdbkhac
            // 
            this.rdbkhac.AutoSize = true;
            this.rdbkhac.Location = new System.Drawing.Point(17, 102);
            this.rdbkhac.Name = "rdbkhac";
            this.rdbkhac.Size = new System.Drawing.Size(67, 22);
            this.rdbkhac.TabIndex = 14;
            this.rdbkhac.TabStop = true;
            this.rdbkhac.Text = "Khác ";
            this.rdbkhac.UseVisualStyleBackColor = true;
            this.rdbkhac.CheckedChanged += new System.EventHandler(this.rdbkhac_CheckedChanged);
            // 
            // rdbNhidong
            // 
            this.rdbNhidong.AutoSize = true;
            this.rdbNhidong.Location = new System.Drawing.Point(366, 56);
            this.rdbNhidong.Name = "rdbNhidong";
            this.rdbNhidong.Size = new System.Drawing.Size(161, 22);
            this.rdbNhidong.TabIndex = 13;
            this.rdbNhidong.TabStop = true;
            this.rdbNhidong.Text = "Bệnh Viện Nhi Đồng";
            this.rdbNhidong.UseVisualStyleBackColor = true;
            // 
            // rdb115
            // 
            this.rdb115.AutoSize = true;
            this.rdb115.Location = new System.Drawing.Point(17, 56);
            this.rdb115.Name = "rdb115";
            this.rdb115.Size = new System.Drawing.Size(123, 22);
            this.rdb115.TabIndex = 12;
            this.rdb115.TabStop = true;
            this.rdb115.Text = "Bệnh Viện 115";
            this.rdb115.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.ForeColor = System.Drawing.Color.Silver;
            this.textBox4.Location = new System.Drawing.Point(19, 522);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(594, 72);
            this.textBox4.TabIndex = 11;
            this.textBox4.Text = "Thông tin thêm ( Nếu có )";
            this.textBox4.Click += new System.EventHandler(this.textBox4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Lí do khám :";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(19, 440);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(598, 68);
            this.textBox3.TabIndex = 6;
            // 
            // textSdt
            // 
            this.textSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSdt.ForeColor = System.Drawing.Color.Silver;
            this.textSdt.Location = new System.Drawing.Point(19, 161);
            this.textSdt.Multiline = true;
            this.textSdt.Name = "textSdt";
            this.textSdt.Size = new System.Drawing.Size(516, 31);
            this.textSdt.TabIndex = 5;
            this.textSdt.Text = "Số điện thoại";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Silver;
            this.txtEmail.Location = new System.Drawing.Point(19, 115);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(516, 30);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Text = "Email(*)";
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNu.Location = new System.Drawing.Point(112, 78);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(48, 22);
            this.rdbNu.TabIndex = 3;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNam.Location = new System.Drawing.Point(27, 78);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(61, 22);
            this.rdbNam.TabIndex = 2;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // txthoten
            // 
            this.txthoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthoten.ForeColor = System.Drawing.Color.Silver;
            this.txthoten.Location = new System.Drawing.Point(19, 30);
            this.txthoten.Multiline = true;
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(495, 28);
            this.txthoten.TabIndex = 0;
            this.txthoten.Text = "Họ và tên bệnh nhân (*)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 115);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKhac);
            this.groupBox2.Controls.Add(this.rdbkhac);
            this.groupBox2.Controls.Add(this.rdbNhidong);
            this.groupBox2.Controls.Add(this.rdb115);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(639, 158);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đã khám Tại Bệnh Viện :";
            // 
            // formDatLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1059, 620);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formDatLich";
            this.Text = "formDatLich";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textSdt;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKhac;
        private System.Windows.Forms.TextBox txtNamsinh;
        private System.Windows.Forms.RadioButton rdbkhac;
        private System.Windows.Forms.RadioButton rdbNhidong;
        private System.Windows.Forms.RadioButton rdb115;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}