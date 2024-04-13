namespace Home.FrmCon.FrmHienThi
{
    partial class ODonHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ODonHang));
            this.panelTong = new Guna.UI2.WinForms.Guna2Panel();
            this.panelGiua = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2CustomCheckBox1 = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnXoa = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.numSL = new Guna.UI.WinForms.GunaNumeric();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.panelTrai = new Guna.UI2.WinForms.Guna2Panel();
            this.panelPhai = new Guna.UI2.WinForms.Guna2Panel();
            this.panelTong.SuspendLayout();
            this.panelGiua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTong
            // 
            this.panelTong.Controls.Add(this.panelGiua);
            this.panelTong.Controls.Add(this.panelTrai);
            this.panelTong.Controls.Add(this.panelPhai);
            this.panelTong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTong.Location = new System.Drawing.Point(0, 0);
            this.panelTong.Name = "panelTong";
            this.panelTong.Size = new System.Drawing.Size(2048, 200);
            this.panelTong.TabIndex = 0;
            // 
            // panelGiua
            // 
            this.panelGiua.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelGiua.Controls.Add(this.guna2CustomGradientPanel1);
            this.panelGiua.Controls.Add(this.guna2CustomCheckBox1);
            this.panelGiua.Controls.Add(this.guna2PictureBox1);
            this.panelGiua.Controls.Add(this.btnXoa);
            this.panelGiua.Controls.Add(this.label1);
            this.panelGiua.Controls.Add(this.lblSoLuong);
            this.panelGiua.Controls.Add(this.numSL);
            this.panelGiua.Controls.Add(this.lblGia);
            this.panelGiua.Controls.Add(this.lblTenSP);
            this.panelGiua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGiua.Location = new System.Drawing.Point(587, 0);
            this.panelGiua.Name = "panelGiua";
            this.panelGiua.Size = new System.Drawing.Size(874, 200);
            this.panelGiua.TabIndex = 6;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Tomato;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(874, 35);
            this.guna2CustomGradientPanel1.TabIndex = 27;
            // 
            // guna2CustomCheckBox1
            // 
            this.guna2CustomCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomCheckBox1.CheckedState.BorderColor = System.Drawing.Color.Tomato;
            this.guna2CustomCheckBox1.CheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox1.CheckedState.BorderThickness = 2;
            this.guna2CustomCheckBox1.CheckedState.FillColor = System.Drawing.Color.Tomato;
            this.guna2CustomCheckBox1.Location = new System.Drawing.Point(65, 108);
            this.guna2CustomCheckBox1.Name = "guna2CustomCheckBox1";
            this.guna2CustomCheckBox1.Size = new System.Drawing.Size(20, 20);
            this.guna2CustomCheckBox1.TabIndex = 29;
            this.guna2CustomCheckBox1.Text = "guna2CustomCheckBox1";
            this.guna2CustomCheckBox1.UncheckedState.BorderColor = System.Drawing.Color.Silver;
            this.guna2CustomCheckBox1.UncheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox1.UncheckedState.BorderThickness = 2;
            this.guna2CustomCheckBox1.UncheckedState.FillColor = System.Drawing.Color.White;
            this.guna2CustomCheckBox1.Click += new System.EventHandler(this.guna2CustomCheckBox1_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(110, 39);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(178, 178);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 28;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnXoa
            // 
            this.btnXoa.AnimationHoverSpeed = 0.07F;
            this.btnXoa.AnimationSpeed = 0.03F;
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnXoa.BorderColor = System.Drawing.Color.Black;
            this.btnXoa.CheckedBaseColor = System.Drawing.Color.DimGray;
            this.btnXoa.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnXoa.CheckedForeColor = System.Drawing.Color.White;
            this.btnXoa.CheckedImage = null;
            this.btnXoa.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnXoa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXoa.FocusedColor = System.Drawing.Color.Empty;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = null;
            this.btnXoa.ImageSize = new System.Drawing.Size(20, 20);
            this.btnXoa.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnXoa.Location = new System.Drawing.Point(532, 131);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXoa.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXoa.OnHoverImage = null;
            this.btnXoa.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnXoa.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoa.Radius = 15;
            this.btnXoa.Size = new System.Drawing.Size(180, 42);
            this.btnXoa.TabIndex = 35;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(573, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 41);
            this.label1.TabIndex = 34;
            this.label1.Text = "81.775.637 VNĐ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.lblSoLuong.Font = new System.Drawing.Font("UVN Nhan", 10F);
            this.lblSoLuong.ForeColor = System.Drawing.Color.Black;
            this.lblSoLuong.Location = new System.Drawing.Point(324, 105);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(128, 33);
            this.lblSoLuong.TabIndex = 33;
            this.lblSoLuong.Text = "Số lượng";
            this.lblSoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numSL
            // 
            this.numSL.BackColor = System.Drawing.Color.Transparent;
            this.numSL.BaseColor = System.Drawing.Color.White;
            this.numSL.BorderColor = System.Drawing.Color.Silver;
            this.numSL.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.numSL.ButtonForeColor = System.Drawing.Color.White;
            this.numSL.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numSL.ForeColor = System.Drawing.Color.Black;
            this.numSL.Location = new System.Drawing.Point(328, 143);
            this.numSL.Maximum = ((long)(9999999));
            this.numSL.Minimum = ((long)(0));
            this.numSL.Name = "numSL";
            this.numSL.Radius = 5;
            this.numSL.Size = new System.Drawing.Size(101, 30);
            this.numSL.TabIndex = 31;
            this.numSL.Text = "gunaNumeric1";
            this.numSL.Value = ((long)(1));
            // 
            // lblGia
            // 
            this.lblGia.Font = new System.Drawing.Font("Segoe UI", 12.2F, System.Drawing.FontStyle.Bold);
            this.lblGia.ForeColor = System.Drawing.Color.Tomato;
            this.lblGia.Location = new System.Drawing.Point(502, 50);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(265, 41);
            this.lblGia.TabIndex = 30;
            this.lblGia.Text = "Giá: 80.775.637 VNĐ";
            this.lblGia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTenSP
            // 
            this.lblTenSP.Font = new System.Drawing.Font("Segoe UI", 15.2F, System.Drawing.FontStyle.Bold);
            this.lblTenSP.ForeColor = System.Drawing.Color.Black;
            this.lblTenSP.Location = new System.Drawing.Point(320, 47);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(247, 49);
            this.lblTenSP.TabIndex = 32;
            this.lblTenSP.Text = "SH 150i";
            this.lblTenSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelTrai
            // 
            this.panelTrai.BackColor = System.Drawing.SystemColors.Control;
            this.panelTrai.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTrai.Location = new System.Drawing.Point(0, 0);
            this.panelTrai.Name = "panelTrai";
            this.panelTrai.Size = new System.Drawing.Size(587, 200);
            this.panelTrai.TabIndex = 4;
            // 
            // panelPhai
            // 
            this.panelPhai.BackColor = System.Drawing.SystemColors.Control;
            this.panelPhai.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelPhai.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelPhai.Location = new System.Drawing.Point(1461, 0);
            this.panelPhai.Name = "panelPhai";
            this.panelPhai.Size = new System.Drawing.Size(587, 200);
            this.panelPhai.TabIndex = 5;
            // 
            // ODonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelTong);
            this.Name = "ODonHang";
            this.Size = new System.Drawing.Size(2048, 200);
            this.Load += new System.EventHandler(this.ODonHang_Load);
            this.panelTong.ResumeLayout(false);
            this.panelGiua.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelTong;
        private Guna.UI2.WinForms.Guna2Panel panelGiua;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CustomCheckBox guna2CustomCheckBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI.WinForms.GunaAdvenceButton btnXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSoLuong;
        private Guna.UI.WinForms.GunaNumeric numSL;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblTenSP;
        private Guna.UI2.WinForms.Guna2Panel panelTrai;
        private Guna.UI2.WinForms.Guna2Panel panelPhai;
    }
}
