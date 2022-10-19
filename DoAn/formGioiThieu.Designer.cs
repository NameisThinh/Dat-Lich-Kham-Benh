namespace DoAn
{
    partial class formGioiThieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formGioiThieu));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnITG = new DoAn.custom_btn();
            this.btnYT = new DoAn.custom_btn();
            this.btnGG = new DoAn.custom_btn();
            this.btnFb = new DoAn.custom_btn();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(108, -5);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1044, 750);
            this.webBrowser1.TabIndex = 6;
            // 
            // btnITG
            // 
            this.btnITG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnITG.Image = ((System.Drawing.Image)(resources.GetObject("btnITG.Image")));
            this.btnITG.Location = new System.Drawing.Point(-4, 558);
            this.btnITG.Name = "btnITG";
            this.btnITG.Size = new System.Drawing.Size(111, 103);
            this.btnITG.TabIndex = 2;
            this.btnITG.UseVisualStyleBackColor = true;
            this.btnITG.Click += new System.EventHandler(this.btnITG_Click);
            // 
            // btnYT
            // 
            this.btnYT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYT.Image = ((System.Drawing.Image)(resources.GetObject("btnYT.Image")));
            this.btnYT.Location = new System.Drawing.Point(-3, 404);
            this.btnYT.Name = "btnYT";
            this.btnYT.Size = new System.Drawing.Size(110, 113);
            this.btnYT.TabIndex = 3;
            this.btnYT.UseVisualStyleBackColor = true;
            this.btnYT.Click += new System.EventHandler(this.btnYT_Click);
            // 
            // btnGG
            // 
            this.btnGG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGG.Image = ((System.Drawing.Image)(resources.GetObject("btnGG.Image")));
            this.btnGG.Location = new System.Drawing.Point(-4, 245);
            this.btnGG.Name = "btnGG";
            this.btnGG.Size = new System.Drawing.Size(111, 109);
            this.btnGG.TabIndex = 4;
            this.btnGG.UseVisualStyleBackColor = true;
            this.btnGG.Click += new System.EventHandler(this.btnGG_Click);
            // 
            // btnFb
            // 
            this.btnFb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFb.Image = ((System.Drawing.Image)(resources.GetObject("btnFb.Image")));
            this.btnFb.Location = new System.Drawing.Point(-4, 108);
            this.btnFb.Name = "btnFb";
            this.btnFb.Size = new System.Drawing.Size(111, 103);
            this.btnFb.TabIndex = 5;
            this.btnFb.UseVisualStyleBackColor = true;
            this.btnFb.Click += new System.EventHandler(this.btnFb_Click);
            // 
            // formGioiThieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1151, 745);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnITG);
            this.Controls.Add(this.btnYT);
            this.Controls.Add(this.btnGG);
            this.Controls.Add(this.btnFb);
            this.Name = "formGioiThieu";
            this.Text = "Giới thiệu";
            this.Load += new System.EventHandler(this.formGioiThieu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private custom_btn btnITG;
        private custom_btn btnYT;
        private custom_btn btnGG;
        private custom_btn btnFb;
    }
}