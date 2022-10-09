namespace DoAn
{
    partial class formQuanLy
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
            this.dtpThoiGian = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbChuaXacNhan = new System.Windows.Forms.RadioButton();
            this.rdbDaXacNhan = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.dgvthongTin = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbTraCuu = new System.Windows.Forms.GroupBox();
            this.SoPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThongTin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            this.grbChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongTin)).BeginInit();
            this.panel1.SuspendLayout();
            this.grbTraCuu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpThoiGian
            // 
            this.dtpThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpThoiGian.Location = new System.Drawing.Point(166, 96);
            this.dtpThoiGian.MinDate = new System.DateTime(2022, 10, 9, 0, 0, 0, 0);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.Size = new System.Drawing.Size(330, 31);
            this.dtpThoiGian.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbChuaXacNhan);
            this.groupBox1.Controls.Add(this.rdbDaXacNhan);
            this.groupBox1.Location = new System.Drawing.Point(23, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 122);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tình trạng";
            // 
            // rdbChuaXacNhan
            // 
            this.rdbChuaXacNhan.AutoSize = true;
            this.rdbChuaXacNhan.Location = new System.Drawing.Point(266, 60);
            this.rdbChuaXacNhan.Name = "rdbChuaXacNhan";
            this.rdbChuaXacNhan.Size = new System.Drawing.Size(188, 29);
            this.rdbChuaXacNhan.TabIndex = 0;
            this.rdbChuaXacNhan.TabStop = true;
            this.rdbChuaXacNhan.Text = "Chưa xác nhận";
            this.rdbChuaXacNhan.UseVisualStyleBackColor = true;
            // 
            // rdbDaXacNhan
            // 
            this.rdbDaXacNhan.AutoSize = true;
            this.rdbDaXacNhan.Location = new System.Drawing.Point(42, 60);
            this.rdbDaXacNhan.Name = "rdbDaXacNhan";
            this.rdbDaXacNhan.Size = new System.Drawing.Size(164, 29);
            this.rdbDaXacNhan.TabIndex = 0;
            this.rdbDaXacNhan.TabStop = true;
            this.rdbDaXacNhan.Text = "Đã xác nhận";
            this.rdbDaXacNhan.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thời gian";
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Location = new System.Drawing.Point(194, 350);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(179, 52);
            this.btnTraCuu.TabIndex = 4;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btnThem);
            this.grbChucNang.Controls.Add(this.btnXoa);
            this.grbChucNang.Controls.Add(this.txtTimKiem);
            this.grbChucNang.Controls.Add(this.btnCapNhat);
            this.grbChucNang.Location = new System.Drawing.Point(2, 6);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(569, 501);
            this.grbChucNang.TabIndex = 7;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức năng";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(48, 145);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(179, 52);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(331, 145);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(179, 52);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(331, 295);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(179, 52);
            this.txtTimKiem.TabIndex = 4;
            this.txtTimKiem.Text = "Tìm kiếm";
            this.txtTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(48, 295);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(179, 52);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // dgvthongTin
            // 
            this.dgvthongTin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvthongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvthongTin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoPhieu,
            this.HoTen,
            this.GioiTinh,
            this.SDT,
            this.Gmail,
            this.NgayDat,
            this.ThongTin,
            this.TinhTrang});
            this.dgvthongTin.Enabled = false;
            this.dgvthongTin.Location = new System.Drawing.Point(586, 23);
            this.dgvthongTin.Name = "dgvthongTin";
            this.dgvthongTin.RowHeadersVisible = false;
            this.dgvthongTin.RowHeadersWidth = 82;
            this.dgvthongTin.RowTemplate.Height = 33;
            this.dgvthongTin.Size = new System.Drawing.Size(1485, 1018);
            this.dgvthongTin.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grbTraCuu);
            this.panel1.Controls.Add(this.dgvthongTin);
            this.panel1.Controls.Add(this.grbChucNang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2083, 1114);
            this.panel1.TabIndex = 9;
            // 
            // grbTraCuu
            // 
            this.grbTraCuu.Controls.Add(this.label1);
            this.grbTraCuu.Controls.Add(this.btnTraCuu);
            this.grbTraCuu.Controls.Add(this.groupBox1);
            this.grbTraCuu.Controls.Add(this.dtpThoiGian);
            this.grbTraCuu.Location = new System.Drawing.Point(4, 604);
            this.grbTraCuu.Name = "grbTraCuu";
            this.grbTraCuu.Size = new System.Drawing.Size(567, 437);
            this.grbTraCuu.TabIndex = 9;
            this.grbTraCuu.TabStop = false;
            this.grbTraCuu.Text = "Tra cứu";
            this.grbTraCuu.Visible = false;
            // 
            // SoPhieu
            // 
            this.SoPhieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoPhieu.HeaderText = "Số phiếu";
            this.SoPhieu.MinimumWidth = 10;
            this.SoPhieu.Name = "SoPhieu";
            // 
            // HoTen
            // 
            this.HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.MinimumWidth = 10;
            this.HoTen.Name = "HoTen";
            // 
            // GioiTinh
            // 
            this.GioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 10;
            this.GioiTinh.Name = "GioiTinh";
            // 
            // SDT
            // 
            this.SDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SDT.HeaderText = "Số DT";
            this.SDT.MinimumWidth = 10;
            this.SDT.Name = "SDT";
            // 
            // Gmail
            // 
            this.Gmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gmail.HeaderText = "Gmail";
            this.Gmail.MinimumWidth = 10;
            this.Gmail.Name = "Gmail";
            // 
            // NgayDat
            // 
            this.NgayDat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayDat.HeaderText = "Ngày đặt";
            this.NgayDat.MinimumWidth = 10;
            this.NgayDat.Name = "NgayDat";
            // 
            // ThongTin
            // 
            this.ThongTin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThongTin.HeaderText = "Thông tin";
            this.ThongTin.MinimumWidth = 10;
            this.ThongTin.Name = "ThongTin";
            // 
            // TinhTrang
            // 
            this.TinhTrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TinhTrang.HeaderText = "Tình Trạng";
            this.TinhTrang.MinimumWidth = 10;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TinhTrang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // formQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2083, 1114);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "formQuanLy";
            this.Text = "formQuanLy";
            this.Load += new System.EventHandler(this.formQuanLy_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongTin)).EndInit();
            this.panel1.ResumeLayout(false);
            this.grbTraCuu.ResumeLayout(false);
            this.grbTraCuu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpThoiGian;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbChuaXacNhan;
        private System.Windows.Forms.RadioButton rdbDaXacNhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.GroupBox grbTraCuu;
        private System.Windows.Forms.Button txtTimKiem;
        private System.Windows.Forms.DataGridView dgvthongTin;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThongTin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TinhTrang;
    }
}