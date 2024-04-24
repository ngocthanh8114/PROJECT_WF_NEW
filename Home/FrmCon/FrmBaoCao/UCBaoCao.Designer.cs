namespace Home.FrmCon.FrmBaoCao
{
    partial class UCBaoCao
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnBCNhaphang = new Guna.UI2.WinForms.Guna2Button();
            this.btnBCDoanhThu = new Guna.UI2.WinForms.Guna2Button();
            this.PanelNoidung = new Guna.UI2.WinForms.Guna2Panel();
            this.btnHoaDon = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel1.Controls.Add(this.btnHoaDon);
            this.guna2Panel1.Controls.Add(this.btnBCDoanhThu);
            this.guna2Panel1.Controls.Add(this.btnBCNhaphang);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(2050, 69);
            this.guna2Panel1.TabIndex = 4;
            // 
            // btnBCNhaphang
            // 
            this.btnBCNhaphang.BorderRadius = 5;
            this.btnBCNhaphang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBCNhaphang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBCNhaphang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBCNhaphang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBCNhaphang.FillColor = System.Drawing.Color.Brown;
            this.btnBCNhaphang.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBCNhaphang.ForeColor = System.Drawing.Color.White;
            this.btnBCNhaphang.Location = new System.Drawing.Point(3, 12);
            this.btnBCNhaphang.Name = "btnBCNhaphang";
            this.btnBCNhaphang.Size = new System.Drawing.Size(221, 39);
            this.btnBCNhaphang.TabIndex = 0;
            this.btnBCNhaphang.Text = "Báo cáo nhập hàng";
            this.btnBCNhaphang.Click += new System.EventHandler(this.btnBCNhaphang_Click);
            // 
            // btnBCDoanhThu
            // 
            this.btnBCDoanhThu.BorderRadius = 5;
            this.btnBCDoanhThu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBCDoanhThu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBCDoanhThu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBCDoanhThu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBCDoanhThu.FillColor = System.Drawing.Color.Brown;
            this.btnBCDoanhThu.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBCDoanhThu.ForeColor = System.Drawing.Color.White;
            this.btnBCDoanhThu.Location = new System.Drawing.Point(230, 12);
            this.btnBCDoanhThu.Name = "btnBCDoanhThu";
            this.btnBCDoanhThu.Size = new System.Drawing.Size(221, 39);
            this.btnBCDoanhThu.TabIndex = 1;
            this.btnBCDoanhThu.Text = "Báo cáo doanh thu";
            // 
            // PanelNoidung
            // 
            this.PanelNoidung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelNoidung.Location = new System.Drawing.Point(0, 69);
            this.PanelNoidung.Name = "PanelNoidung";
            this.PanelNoidung.Size = new System.Drawing.Size(2050, 819);
            this.PanelNoidung.TabIndex = 5;
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.BorderRadius = 5;
            this.btnHoaDon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHoaDon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHoaDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHoaDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHoaDon.FillColor = System.Drawing.Color.Brown;
            this.btnHoaDon.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnHoaDon.Location = new System.Drawing.Point(457, 12);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(221, 39);
            this.btnHoaDon.TabIndex = 2;
            this.btnHoaDon.Text = "Báo cáo hóa đơn";
            // 
            // UCBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelNoidung);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UCBaoCao";
            this.Size = new System.Drawing.Size(2050, 888);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnBCDoanhThu;
        private Guna.UI2.WinForms.Guna2Button btnBCNhaphang;
        private Guna.UI2.WinForms.Guna2Panel PanelNoidung;
        private Guna.UI2.WinForms.Guna2Button btnHoaDon;
    }
}
