﻿namespace Home.FrmCon.FrmBaoCao
{
    partial class UCBaoCaoHoaDon
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
            this.guna2Panel9 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel8 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_Xoa = new Guna.UI.WinForms.GunaAdvenceButton();
            this.cboDonMua = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelSP = new System.Windows.Forms.FlowLayoutPanel();
            this.panelNoiDung = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel9
            // 
            this.guna2Panel9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2Panel9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel9.Location = new System.Drawing.Point(0, 49);
            this.guna2Panel9.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel9.Name = "guna2Panel9";
            this.guna2Panel9.Size = new System.Drawing.Size(1358, 3);
            this.guna2Panel9.TabIndex = 21;
            // 
            // guna2Panel8
            // 
            this.guna2Panel8.BackColor = System.Drawing.Color.White;
            this.guna2Panel8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel8.Controls.Add(this.btn_Xoa);
            this.guna2Panel8.Controls.Add(this.cboDonMua);
            this.guna2Panel8.Controls.Add(this.label4);
            this.guna2Panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel8.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel8.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel8.Name = "guna2Panel8";
            this.guna2Panel8.Size = new System.Drawing.Size(1358, 49);
            this.guna2Panel8.TabIndex = 20;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.AnimationHoverSpeed = 0.07F;
            this.btn_Xoa.AnimationSpeed = 0.03F;
            this.btn_Xoa.BackColor = System.Drawing.Color.Transparent;
            this.btn_Xoa.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Xoa.BorderColor = System.Drawing.Color.Black;
            this.btn_Xoa.CheckedBaseColor = System.Drawing.Color.DimGray;
            this.btn_Xoa.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Xoa.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Xoa.CheckedImage = null;
            this.btn_Xoa.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Xoa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Xoa.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Image = null;
            this.btn_Xoa.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Xoa.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Xoa.Location = new System.Drawing.Point(1033, 9);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Xoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Xoa.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Xoa.OnHoverImage = null;
            this.btn_Xoa.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Xoa.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Xoa.Radius = 5;
            this.btn_Xoa.Size = new System.Drawing.Size(140, 36);
            this.btn_Xoa.TabIndex = 37;
            this.btn_Xoa.Text = "Xóa hóa đơn";
            this.btn_Xoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // cboDonMua
            // 
            this.cboDonMua.BackColor = System.Drawing.Color.Transparent;
            this.cboDonMua.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboDonMua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDonMua.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboDonMua.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboDonMua.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboDonMua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboDonMua.ItemHeight = 30;
            this.cboDonMua.Location = new System.Drawing.Point(1190, 9);
            this.cboDonMua.Margin = new System.Windows.Forms.Padding(2);
            this.cboDonMua.Name = "cboDonMua";
            this.cboDonMua.Size = new System.Drawing.Size(166, 36);
            this.cboDonMua.TabIndex = 17;
            this.cboDonMua.SelectedIndexChanged += new System.EventHandler(this.cboDonMua_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "Đơn hàng đã mua";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 435);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1358, 3);
            this.guna2Panel1.TabIndex = 24;
            // 
            // panelSP
            // 
            this.panelSP.AutoScroll = true;
            this.panelSP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSP.Location = new System.Drawing.Point(0, 438);
            this.panelSP.Margin = new System.Windows.Forms.Padding(2);
            this.panelSP.Name = "panelSP";
            this.panelSP.Size = new System.Drawing.Size(1358, 234);
            this.panelSP.TabIndex = 23;
            // 
            // panelNoiDung
            // 
            this.panelNoiDung.AutoScroll = true;
            this.panelNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNoiDung.Location = new System.Drawing.Point(0, 52);
            this.panelNoiDung.Margin = new System.Windows.Forms.Padding(2);
            this.panelNoiDung.Name = "panelNoiDung";
            this.panelNoiDung.Size = new System.Drawing.Size(1358, 383);
            this.panelNoiDung.TabIndex = 25;
            // 
            // UCBaoCaoHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelNoiDung);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel9);
            this.Controls.Add(this.guna2Panel8);
            this.Controls.Add(this.panelSP);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCBaoCaoHoaDon";
            this.Size = new System.Drawing.Size(1358, 672);
            this.Load += new System.EventHandler(this.UCBaoCaoHoaDon_Load);
            this.guna2Panel8.ResumeLayout(false);
            this.guna2Panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel9;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel8;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cboDonMua;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.FlowLayoutPanel panelSP;
        private System.Windows.Forms.FlowLayoutPanel panelNoiDung;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Xoa;
    }
}