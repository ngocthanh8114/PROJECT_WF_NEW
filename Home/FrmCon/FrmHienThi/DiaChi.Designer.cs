namespace Home.FrmCon.FrmHienThi
{
    partial class DiaChi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiaChi));
            this.guna2Panel8 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnXoa = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel9 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelNoiDung = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel8
            // 
            this.guna2Panel8.BackColor = System.Drawing.Color.White;
            this.guna2Panel8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel8.Controls.Add(this.btnXoa);
            this.guna2Panel8.Controls.Add(this.label4);
            this.guna2Panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel8.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel8.Name = "guna2Panel8";
            this.guna2Panel8.Size = new System.Drawing.Size(1174, 75);
            this.guna2Panel8.TabIndex = 21;
            // 
            // btnXoa
            // 
            this.btnXoa.AnimationHoverSpeed = 0.07F;
            this.btnXoa.AnimationSpeed = 0.03F;
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
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
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageSize = new System.Drawing.Size(20, 20);
            this.btnXoa.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnXoa.Location = new System.Drawing.Point(907, 17);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXoa.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXoa.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.OnHoverImage")));
            this.btnXoa.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnXoa.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoa.Radius = 5;
            this.btnXoa.Size = new System.Drawing.Size(248, 42);
            this.btnXoa.TabIndex = 42;
            this.btnXoa.Text = "Thêm địa chỉ mới";
            this.btnXoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 32);
            this.label4.TabIndex = 16;
            this.label4.Text = "Đơn hàng đã mua";
            // 
            // guna2Panel9
            // 
            this.guna2Panel9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2Panel9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel9.Location = new System.Drawing.Point(0, 75);
            this.guna2Panel9.Name = "guna2Panel9";
            this.guna2Panel9.Size = new System.Drawing.Size(1174, 4);
            this.guna2Panel9.TabIndex = 22;
            // 
            // panelNoiDung
            // 
            this.panelNoiDung.AutoScroll = true;
            this.panelNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNoiDung.Location = new System.Drawing.Point(0, 79);
            this.panelNoiDung.Name = "panelNoiDung";
            this.panelNoiDung.Size = new System.Drawing.Size(1174, 736);
            this.panelNoiDung.TabIndex = 23;
            // 
            // DiaChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelNoiDung);
            this.Controls.Add(this.guna2Panel9);
            this.Controls.Add(this.guna2Panel8);
            this.Name = "DiaChi";
            this.Size = new System.Drawing.Size(1174, 815);
            this.Load += new System.EventHandler(this.DiaChi_Load);
            this.guna2Panel8.ResumeLayout(false);
            this.guna2Panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel8;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel9;
        private Guna.UI.WinForms.GunaAdvenceButton btnXoa;
        private System.Windows.Forms.FlowLayoutPanel panelNoiDung;
    }
}
