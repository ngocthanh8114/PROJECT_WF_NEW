namespace Home.FrmCon.FrmConAdmin.UCThanhPhan
{
    partial class OXuLiDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OXuLiDichVu));
            this.lblTenKhachHang = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSoDienThoai = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTrangThai = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnXuLi = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.lblTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKhachHang.Location = new System.Drawing.Point(2, 137);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(133, 24);
            this.lblTenKhachHang.TabIndex = 1;
            this.lblTenKhachHang.Text = "Tên khách hàng";
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.BackColor = System.Drawing.Color.Transparent;
            this.lblSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDienThoai.Location = new System.Drawing.Point(3, 166);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(108, 24);
            this.lblSoDienThoai.TabIndex = 2;
            this.lblSoDienThoai.Text = "Số điện thoại";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Controls.Add(this.lblTrangThai);
            this.guna2Panel1.Controls.Add(this.btnXuLi);
            this.guna2Panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2Panel1.Controls.Add(this.lblTenKhachHang);
            this.guna2Panel1.Controls.Add(this.lblSoDienThoai);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(220, 213);
            this.guna2Panel1.TabIndex = 3;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.lblTrangThai.ForeColor = System.Drawing.Color.Red;
            this.lblTrangThai.Location = new System.Drawing.Point(3, 192);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(27, 18);
            this.lblTrangThai.TabIndex = 5;
            this.lblTrangThai.Text = " Xử lí";
            // 
            // btnXuLi
            // 
            this.btnXuLi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXuLi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXuLi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXuLi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXuLi.FillColor = System.Drawing.Color.Brown;
            this.btnXuLi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXuLi.ForeColor = System.Drawing.Color.White;
            this.btnXuLi.Location = new System.Drawing.Point(149, 164);
            this.btnXuLi.Name = "btnXuLi";
            this.btnXuLi.Size = new System.Drawing.Size(68, 46);
            this.btnXuLi.TabIndex = 4;
            this.btnXuLi.Text = "Xử lí";
            this.btnXuLi.Click += new System.EventHandler(this.btnXuLi_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(3, 30);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(214, 104);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 3;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(57, 6);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(108, 18);
            this.guna2HtmlLabel1.TabIndex = 6;
            this.guna2HtmlLabel1.Text = "guna2HtmlLabel1";
            // 
            // OXuLiDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "OXuLiDichVu";
            this.Size = new System.Drawing.Size(220, 213);
            this.Load += new System.EventHandler(this.OXuLiDichVu_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTenKhachHang;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSoDienThoai;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnXuLi;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTrangThai;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}
