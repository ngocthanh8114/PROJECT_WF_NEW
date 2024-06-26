﻿namespace Home.FrmCon
{
    partial class SanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPham));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.cbLocGia = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnTimKiem = new Guna.UI.WinForms.GunaCircleButton();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboLoaiSP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelNoiDung = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel1.Controls.Add(this.cbLocGia);
            this.guna2Panel1.Controls.Add(this.btnTimKiem);
            this.guna2Panel1.Controls.Add(this.txtTimKiem);
            this.guna2Panel1.Controls.Add(this.cboLoaiSP);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(2051, 75);
            this.guna2Panel1.TabIndex = 3;
            // 
            // cbLocGia
            // 
            this.cbLocGia.AutoRoundedCorners = true;
            this.cbLocGia.BackColor = System.Drawing.Color.Transparent;
            this.cbLocGia.BorderColor = System.Drawing.Color.Gray;
            this.cbLocGia.BorderRadius = 17;
            this.cbLocGia.DisabledState.BorderColor = System.Drawing.Color.Tomato;
            this.cbLocGia.DisabledState.ForeColor = System.Drawing.Color.Tomato;
            this.cbLocGia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLocGia.DropDownHeight = 200;
            this.cbLocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocGia.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLocGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cbLocGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbLocGia.HoverState.BorderColor = System.Drawing.Color.Tomato;
            this.cbLocGia.HoverState.ForeColor = System.Drawing.Color.Tomato;
            this.cbLocGia.IntegralHeight = false;
            this.cbLocGia.ItemHeight = 30;
            this.cbLocGia.Items.AddRange(new object[] {
            "Dưới 20 triệu",
            "Từ 20 triệu đến 50 triệu",
            "Từ 50 triệu đến 150 triệu",
            "Trừ 150 triệu đến 300 triệu",
            "Trên 300 triệu",
            "Dưới 20 triệu",
            "Từ 20 triệu đến 50 triệu",
            "Từ 50 triệu đến 150 triệu",
            "Từ 150 triệu đến 300 triệu",
            "Trên 300 triệu"});
            this.cbLocGia.Location = new System.Drawing.Point(17, 17);
            this.cbLocGia.Margin = new System.Windows.Forms.Padding(2);
            this.cbLocGia.Name = "cbLocGia";
            this.cbLocGia.Size = new System.Drawing.Size(279, 36);
            this.cbLocGia.TabIndex = 6;
            this.cbLocGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbLocGia.TextOffset = new System.Drawing.Point(10, 3);
            this.cbLocGia.SelectedIndexChanged += new System.EventHandler(this.cbLocGia_SelectedIndexChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Animated = true;
            this.btnTimKiem.AnimationHoverSpeed = 0.07F;
            this.btnTimKiem.AnimationSpeed = 0.03F;
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.BackgroundImage")));
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiem.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTimKiem.BorderColor = System.Drawing.Color.Black;
            this.btnTimKiem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTimKiem.FocusedColor = System.Drawing.Color.Empty;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTimKiem.Location = new System.Drawing.Point(1963, 20);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.OnHoverBaseColor = System.Drawing.Color.Coral;
            this.btnTimKiem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTimKiem.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTimKiem.OnHoverImage = null;
            this.btnTimKiem.OnPressedColor = System.Drawing.Color.Black;
            this.btnTimKiem.Size = new System.Drawing.Size(50, 47);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Animated = true;
            this.txtTimKiem.AutoRoundedCorners = true;
            this.txtTimKiem.BorderColor = System.Drawing.Color.Gray;
            this.txtTimKiem.BorderRadius = 22;
            this.txtTimKiem.BorderThickness = 2;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.Tomato;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Location = new System.Drawing.Point(1626, 20);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "Tìm kiếm";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(324, 47);
            this.txtTimKiem.TabIndex = 4;
            // 
            // cboLoaiSP
            // 
            this.cboLoaiSP.AutoRoundedCorners = true;
            this.cboLoaiSP.BackColor = System.Drawing.Color.Transparent;
            this.cboLoaiSP.BorderColor = System.Drawing.Color.Gray;
            this.cboLoaiSP.BorderRadius = 17;
            this.cboLoaiSP.DisabledState.BorderColor = System.Drawing.Color.Tomato;
            this.cboLoaiSP.DisabledState.ForeColor = System.Drawing.Color.Tomato;
            this.cboLoaiSP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLoaiSP.DropDownHeight = 200;
            this.cboLoaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiSP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLoaiSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cboLoaiSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLoaiSP.HoverState.BorderColor = System.Drawing.Color.Tomato;
            this.cboLoaiSP.HoverState.ForeColor = System.Drawing.Color.Tomato;
            this.cboLoaiSP.IntegralHeight = false;
            this.cboLoaiSP.ItemHeight = 30;
            this.cboLoaiSP.Location = new System.Drawing.Point(754, 21);
            this.cboLoaiSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboLoaiSP.Name = "cboLoaiSP";
            this.cboLoaiSP.Size = new System.Drawing.Size(542, 36);
            this.cboLoaiSP.TabIndex = 3;
            this.cboLoaiSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cboLoaiSP.TextOffset = new System.Drawing.Point(10, 3);
            this.cboLoaiSP.SelectedIndexChanged += new System.EventHandler(this.cboLoaiSP_SelectedIndexChanged);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Gray;
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 75);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(2051, 4);
            this.guna2Panel2.TabIndex = 1;
            // 
            // panelNoiDung
            // 
            this.panelNoiDung.AutoScroll = true;
            this.panelNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNoiDung.Location = new System.Drawing.Point(0, 79);
            this.panelNoiDung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelNoiDung.Name = "panelNoiDung";
            this.panelNoiDung.Size = new System.Drawing.Size(2051, 810);
            this.panelNoiDung.TabIndex = 4;
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelNoiDung);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SanPham";
            this.Size = new System.Drawing.Size(2051, 889);
            this.Load += new System.EventHandler(this.SanPham_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ComboBox cboLoaiSP;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI.WinForms.GunaCircleButton btnTimKiem;
        private Guna.UI2.WinForms.Guna2ComboBox cbLocGia;
        private System.Windows.Forms.FlowLayoutPanel panelNoiDung;
    }
}
