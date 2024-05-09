namespace Home.FrmCon.FrmConAdmin
{
    partial class UCDichVu_BaoHanh
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
            this.btnBaoHanh = new Guna.UI2.WinForms.Guna2Button();
            this.btnDichVu = new Guna.UI2.WinForms.Guna2Button();
            this.PanelNoidung = new Guna.UI2.WinForms.Guna2Panel();
            this.sanPhamTrong1 = new Home.FrmCon.FrmConUser.UCThanhPhan.OTrong.SanPhamTrong();
            this.guna2Panel1.SuspendLayout();
            this.PanelNoidung.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.btnBaoHanh);
            this.guna2Panel1.Controls.Add(this.btnDichVu);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(2050, 69);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnBaoHanh
            // 
            this.btnBaoHanh.BorderRadius = 5;
            this.btnBaoHanh.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnBaoHanh.CheckedState.FillColor = System.Drawing.Color.Brown;
            this.btnBaoHanh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBaoHanh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBaoHanh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBaoHanh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBaoHanh.FillColor = System.Drawing.Color.Tomato;
            this.btnBaoHanh.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnBaoHanh.ForeColor = System.Drawing.Color.White;
            this.btnBaoHanh.Location = new System.Drawing.Point(246, 14);
            this.btnBaoHanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBaoHanh.Name = "btnBaoHanh";
            this.btnBaoHanh.Size = new System.Drawing.Size(221, 39);
            this.btnBaoHanh.TabIndex = 3;
            this.btnBaoHanh.Text = "Bảo hành";            // 
            // btnDichVu
            // 
            this.btnDichVu.BorderRadius = 5;
            this.btnDichVu.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDichVu.CheckedState.FillColor = System.Drawing.Color.Brown;
            this.btnDichVu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDichVu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDichVu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDichVu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDichVu.FillColor = System.Drawing.Color.Tomato;
            this.btnDichVu.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnDichVu.ForeColor = System.Drawing.Color.White;
            this.btnDichVu.Location = new System.Drawing.Point(19, 14);
            this.btnDichVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Size = new System.Drawing.Size(221, 39);
            this.btnDichVu.TabIndex = 2;
            this.btnDichVu.Text = "Dịch vụ";
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);
            // 
            // PanelNoidung
            // 
            this.PanelNoidung.BorderThickness = 3;
            this.PanelNoidung.Controls.Add(this.sanPhamTrong1);
            this.PanelNoidung.CustomBorderColor = System.Drawing.Color.Black;
            this.PanelNoidung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelNoidung.Location = new System.Drawing.Point(0, 69);
            this.PanelNoidung.Name = "PanelNoidung";
            this.PanelNoidung.Size = new System.Drawing.Size(2050, 797);
            this.PanelNoidung.TabIndex = 1;
            // 
            // sanPhamTrong1
            // 
            this.sanPhamTrong1.Location = new System.Drawing.Point(3, 3);
            this.sanPhamTrong1.Name = "sanPhamTrong1";
            this.sanPhamTrong1.Size = new System.Drawing.Size(2044, 791);
            this.sanPhamTrong1.TabIndex = 0;
            // 
            // UCDichVu_BaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelNoidung);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UCDichVu_BaoHanh";
            this.Size = new System.Drawing.Size(2050, 866);
            this.Load += new System.EventHandler(this.UCDichVu_BaoHanh_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.PanelNoidung.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnDichVu;
        private Guna.UI2.WinForms.Guna2Button btnBaoHanh;
        private Guna.UI2.WinForms.Guna2Panel PanelNoidung;
        private FrmConUser.UCThanhPhan.OTrong.SanPhamTrong sanPhamTrong1;
    }
}
