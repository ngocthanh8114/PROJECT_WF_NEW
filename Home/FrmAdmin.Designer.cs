﻿namespace Home
{
    partial class FrmAdmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.panelHienThi = new Guna.UI.WinForms.GunaPanel();
            this.panelTong = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.btnTaiKhoan = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnBaoCao = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnHoaDon = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnKhachHang = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnSanPham = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panelMenu = new Guna.UI.WinForms.GunaPanel();
            this.panelThanhTieuDe = new Guna.UI.WinForms.GunaPanel();
            this.lblTieude = new Guna.UI.WinForms.GunaLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnDong = new Guna.UI.WinForms.GunaAdvenceButton();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.panelTong.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            this.panelThanhTieuDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHienThi
            // 
            this.panelHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHienThi.Location = new System.Drawing.Point(0, 135);
            this.panelHienThi.Name = "panelHienThi";
            this.panelHienThi.Size = new System.Drawing.Size(1251, 916);
            this.panelHienThi.TabIndex = 21;
            // 
            // panelTong
            // 
            this.panelTong.Controls.Add(this.panelHienThi);
            this.panelTong.Controls.Add(this.gunaPanel2);
            this.panelTong.Controls.Add(this.panelMenu);
            this.panelTong.Controls.Add(this.panelThanhTieuDe);
            this.panelTong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTong.Location = new System.Drawing.Point(0, 0);
            this.panelTong.Name = "panelTong";
            this.panelTong.Size = new System.Drawing.Size(1251, 1051);
            this.panelTong.TabIndex = 1;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gunaPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaPanel2.Controls.Add(this.btnTaiKhoan);
            this.gunaPanel2.Controls.Add(this.btnBaoCao);
            this.gunaPanel2.Controls.Add(this.btnHoaDon);
            this.gunaPanel2.Controls.Add(this.btnKhachHang);
            this.gunaPanel2.Controls.Add(this.btnSanPham);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 85);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(1251, 50);
            this.gunaPanel2.TabIndex = 14;
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Animated = true;
            this.btnTaiKhoan.AnimationHoverSpeed = 0.07F;
            this.btnTaiKhoan.AnimationSpeed = 0.03F;
            this.btnTaiKhoan.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTaiKhoan.BorderColor = System.Drawing.Color.Black;
            this.btnTaiKhoan.CheckedBaseColor = System.Drawing.Color.Tomato;
            this.btnTaiKhoan.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btnTaiKhoan.CheckedForeColor = System.Drawing.Color.White;
            this.btnTaiKhoan.CheckedImage = null;
            this.btnTaiKhoan.CheckedLineColor = System.Drawing.Color.Tomato;
            this.btnTaiKhoan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTaiKhoan.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTaiKhoan.FocusedColor = System.Drawing.Color.Empty;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnTaiKhoan.Image = null;
            this.btnTaiKhoan.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTaiKhoan.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnTaiKhoan.Location = new System.Drawing.Point(1000, 0);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.OnHoverBaseColor = System.Drawing.Color.Tomato;
            this.btnTaiKhoan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTaiKhoan.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTaiKhoan.OnHoverImage = null;
            this.btnTaiKhoan.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnTaiKhoan.OnPressedColor = System.Drawing.Color.Black;
            this.btnTaiKhoan.Size = new System.Drawing.Size(250, 50);
            this.btnTaiKhoan.TabIndex = 4;
            this.btnTaiKhoan.Text = "Tài khoản";
            this.btnTaiKhoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Animated = true;
            this.btnBaoCao.AnimationHoverSpeed = 0.07F;
            this.btnBaoCao.AnimationSpeed = 0.03F;
            this.btnBaoCao.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBaoCao.BorderColor = System.Drawing.Color.Black;
            this.btnBaoCao.CheckedBaseColor = System.Drawing.Color.Tomato;
            this.btnBaoCao.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btnBaoCao.CheckedForeColor = System.Drawing.Color.White;
            this.btnBaoCao.CheckedImage = null;
            this.btnBaoCao.CheckedLineColor = System.Drawing.Color.Tomato;
            this.btnBaoCao.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBaoCao.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBaoCao.FocusedColor = System.Drawing.Color.Empty;
            this.btnBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnBaoCao.Image = null;
            this.btnBaoCao.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBaoCao.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBaoCao.Location = new System.Drawing.Point(750, 0);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.OnHoverBaseColor = System.Drawing.Color.Tomato;
            this.btnBaoCao.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBaoCao.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBaoCao.OnHoverImage = null;
            this.btnBaoCao.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBaoCao.OnPressedColor = System.Drawing.Color.Black;
            this.btnBaoCao.Size = new System.Drawing.Size(250, 50);
            this.btnBaoCao.TabIndex = 3;
            this.btnBaoCao.Text = "Báo cáo";
            this.btnBaoCao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Animated = true;
            this.btnHoaDon.AnimationHoverSpeed = 0.07F;
            this.btnHoaDon.AnimationSpeed = 0.03F;
            this.btnHoaDon.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHoaDon.BorderColor = System.Drawing.Color.Black;
            this.btnHoaDon.CheckedBaseColor = System.Drawing.Color.Tomato;
            this.btnHoaDon.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btnHoaDon.CheckedForeColor = System.Drawing.Color.White;
            this.btnHoaDon.CheckedImage = null;
            this.btnHoaDon.CheckedLineColor = System.Drawing.Color.Tomato;
            this.btnHoaDon.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHoaDon.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHoaDon.FocusedColor = System.Drawing.Color.Empty;
            this.btnHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnHoaDon.Image = null;
            this.btnHoaDon.ImageSize = new System.Drawing.Size(20, 20);
            this.btnHoaDon.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnHoaDon.Location = new System.Drawing.Point(500, 0);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.OnHoverBaseColor = System.Drawing.Color.Tomato;
            this.btnHoaDon.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHoaDon.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHoaDon.OnHoverImage = null;
            this.btnHoaDon.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnHoaDon.OnPressedColor = System.Drawing.Color.Black;
            this.btnHoaDon.Size = new System.Drawing.Size(250, 50);
            this.btnHoaDon.TabIndex = 2;
            this.btnHoaDon.Text = "Hóa đơn";
            this.btnHoaDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Animated = true;
            this.btnKhachHang.AnimationHoverSpeed = 0.07F;
            this.btnKhachHang.AnimationSpeed = 0.03F;
            this.btnKhachHang.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnKhachHang.BorderColor = System.Drawing.Color.Black;
            this.btnKhachHang.CheckedBaseColor = System.Drawing.Color.Tomato;
            this.btnKhachHang.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btnKhachHang.CheckedForeColor = System.Drawing.Color.White;
            this.btnKhachHang.CheckedImage = null;
            this.btnKhachHang.CheckedLineColor = System.Drawing.Color.Tomato;
            this.btnKhachHang.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnKhachHang.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnKhachHang.FocusedColor = System.Drawing.Color.Empty;
            this.btnKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnKhachHang.Image = null;
            this.btnKhachHang.ImageSize = new System.Drawing.Size(20, 20);
            this.btnKhachHang.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnKhachHang.Location = new System.Drawing.Point(250, 0);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.OnHoverBaseColor = System.Drawing.Color.Tomato;
            this.btnKhachHang.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnKhachHang.OnHoverForeColor = System.Drawing.Color.White;
            this.btnKhachHang.OnHoverImage = null;
            this.btnKhachHang.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnKhachHang.OnPressedColor = System.Drawing.Color.Black;
            this.btnKhachHang.Size = new System.Drawing.Size(250, 50);
            this.btnKhachHang.TabIndex = 1;
            this.btnKhachHang.Text = "Khách hàng";
            this.btnKhachHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.Animated = true;
            this.btnSanPham.AnimationHoverSpeed = 0.07F;
            this.btnSanPham.AnimationSpeed = 0.03F;
            this.btnSanPham.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSanPham.BorderColor = System.Drawing.Color.Transparent;
            this.btnSanPham.CheckedBaseColor = System.Drawing.Color.Tomato;
            this.btnSanPham.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btnSanPham.CheckedForeColor = System.Drawing.Color.White;
            this.btnSanPham.CheckedImage = null;
            this.btnSanPham.CheckedLineColor = System.Drawing.Color.IndianRed;
            this.btnSanPham.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSanPham.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSanPham.FocusedColor = System.Drawing.Color.Empty;
            this.btnSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanPham.ForeColor = System.Drawing.Color.White;
            this.btnSanPham.Image = null;
            this.btnSanPham.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSanPham.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSanPham.Location = new System.Drawing.Point(0, 0);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.OnHoverBaseColor = System.Drawing.Color.Tomato;
            this.btnSanPham.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnSanPham.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSanPham.OnHoverImage = null;
            this.btnSanPham.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSanPham.OnPressedColor = System.Drawing.Color.Black;
            this.btnSanPham.Size = new System.Drawing.Size(250, 50);
            this.btnSanPham.TabIndex = 0;
            this.btnSanPham.Text = "Sản phẩm";
            this.btnSanPham.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.MistyRose;
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.panelMenu.Location = new System.Drawing.Point(0, 40);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1251, 45);
            this.panelMenu.TabIndex = 23;
            // 
            // panelThanhTieuDe
            // 
            this.panelThanhTieuDe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelThanhTieuDe.Controls.Add(this.lblTieude);
            this.panelThanhTieuDe.Controls.Add(this.guna2PictureBox1);
            this.panelThanhTieuDe.Controls.Add(this.btnDong);
            this.panelThanhTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelThanhTieuDe.Location = new System.Drawing.Point(0, 0);
            this.panelThanhTieuDe.Name = "panelThanhTieuDe";
            this.panelThanhTieuDe.Size = new System.Drawing.Size(1251, 40);
            this.panelThanhTieuDe.TabIndex = 13;
            this.panelThanhTieuDe.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // lblTieude
            // 
            this.lblTieude.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTieude.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieude.Location = new System.Drawing.Point(50, 0);
            this.lblTieude.Name = "lblTieude";
            this.lblTieude.Size = new System.Drawing.Size(194, 40);
            this.lblTieude.TabIndex = 15;
            this.lblTieude.Text = "Smotorycycle";
            this.lblTieude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(50, 40);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 14;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnDong
            // 
            this.btnDong.Animated = true;
            this.btnDong.AnimationHoverSpeed = 0.07F;
            this.btnDong.AnimationSpeed = 0.03F;
            this.btnDong.BaseColor = System.Drawing.Color.Transparent;
            this.btnDong.BorderColor = System.Drawing.Color.Black;
            this.btnDong.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnDong.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnDong.CheckedForeColor = System.Drawing.Color.White;
            this.btnDong.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnDong.CheckedImage")));
            this.btnDong.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDong.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDong.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDong.FocusedColor = System.Drawing.Color.Empty;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDong.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDong.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDong.Location = new System.Drawing.Point(1211, 0);
            this.btnDong.Name = "btnDong";
            this.btnDong.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btnDong.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDong.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDong.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnDong.OnHoverImage")));
            this.btnDong.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDong.OnPressedColor = System.Drawing.Color.Black;
            this.btnDong.Size = new System.Drawing.Size(40, 40);
            this.btnDong.TabIndex = 13;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_VER_NEGATIVE;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 1051);
            this.Controls.Add(this.panelTong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdmin";
            this.Text = "FrmAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelTong.ResumeLayout(false);
            this.gunaPanel2.ResumeLayout(false);
            this.panelThanhTieuDe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel panelHienThi;
        private Guna.UI.WinForms.GunaPanel panelTong;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaAdvenceButton btnBaoCao;
        private Guna.UI.WinForms.GunaAdvenceButton btnHoaDon;
        private Guna.UI.WinForms.GunaAdvenceButton btnKhachHang;
        private Guna.UI.WinForms.GunaAdvenceButton btnSanPham;
        private Guna.UI.WinForms.GunaPanel panelMenu;
        private Guna.UI.WinForms.GunaPanel panelThanhTieuDe;
        private Guna.UI.WinForms.GunaLabel lblTieude;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI.WinForms.GunaAdvenceButton btnDong;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI.WinForms.GunaAdvenceButton btnTaiKhoan;
    }
}