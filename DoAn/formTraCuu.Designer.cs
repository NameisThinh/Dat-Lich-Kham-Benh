namespace DoAn
{
    partial class formTraCuu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.rdoThang = new System.Windows.Forms.RadioButton();
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.rdoThoigian = new System.Windows.Forms.RadioButton();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1815, 1048);
            this.panel1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DoAn.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 388);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1791, 648);
            this.reportViewer1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtp2);
            this.groupBox1.Controls.Add(this.rdoThang);
            this.groupBox1.Controls.Add(this.cbbThang);
            this.groupBox1.Controls.Add(this.rdoThoigian);
            this.groupBox1.Controls.Add(this.dtp1);
            this.groupBox1.Location = new System.Drawing.Point(30, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1133, 244);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // dtp2
            // 
            this.dtp2.CustomFormat = "yyyy-MM-dd";
            this.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp2.Location = new System.Drawing.Point(783, 148);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(200, 31);
            this.dtp2.TabIndex = 1;
            // 
            // rdoThang
            // 
            this.rdoThang.AutoSize = true;
            this.rdoThang.Location = new System.Drawing.Point(43, 59);
            this.rdoThang.Name = "rdoThang";
            this.rdoThang.Size = new System.Drawing.Size(230, 29);
            this.rdoThang.TabIndex = 0;
            this.rdoThang.TabStop = true;
            this.rdoThang.Text = "Báo cáo theo tháng";
            this.rdoThang.UseVisualStyleBackColor = true;
            this.rdoThang.CheckedChanged += new System.EventHandler(this.rdoThang_CheckedChanged);
            // 
            // cbbThang
            // 
            this.cbbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbThang.FormattingEnabled = true;
            this.cbbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbbThang.Location = new System.Drawing.Point(474, 55);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(121, 33);
            this.cbbThang.TabIndex = 2;
            // 
            // rdoThoigian
            // 
            this.rdoThoigian.AutoSize = true;
            this.rdoThoigian.Location = new System.Drawing.Point(43, 148);
            this.rdoThoigian.Name = "rdoThoigian";
            this.rdoThoigian.Size = new System.Drawing.Size(335, 29);
            this.rdoThoigian.TabIndex = 0;
            this.rdoThoigian.TabStop = true;
            this.rdoThoigian.Text = "Báo cáo theo khoảng thời gian";
            this.rdoThoigian.UseVisualStyleBackColor = true;
            this.rdoThoigian.CheckedChanged += new System.EventHandler(this.rdoThoigian_CheckedChanged);
            // 
            // dtp1
            // 
            this.dtp1.CustomFormat = "yyyy-MM-dd";
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp1.Location = new System.Drawing.Point(474, 148);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(200, 31);
            this.dtp1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(960, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 60);
            this.button1.TabIndex = 3;
            this.button1.Text = "Xuất báo cáo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(707, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "==>";
            // 
            // formTraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1815, 1048);
            this.Controls.Add(this.panel1);
            this.Name = "formTraCuu";
            this.Text = "formTraCuu";
            this.Load += new System.EventHandler(this.formTraCuu_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.RadioButton rdoThang;
        private System.Windows.Forms.ComboBox cbbThang;
        private System.Windows.Forms.RadioButton rdoThoigian;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
    }
}