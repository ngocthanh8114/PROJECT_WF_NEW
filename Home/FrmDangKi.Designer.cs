namespace Home
{
    partial class FrmDangKi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDangKi));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTenNguoiDung = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMatKhau = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtXacNhanMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTaiKhoan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTenTaiKhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSDT = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSoDienThoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEmail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_Thoat = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnDangKy = new Guna.UI2.WinForms.Guna2Button();
            this.txtTenNguoiDung = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Thoat)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_POSITIVE;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Silver;
            this.guna2Panel2.Controls.Add(this.lblTenNguoiDung);
            this.guna2Panel2.Controls.Add(this.lblMatKhau);
            this.guna2Panel2.Controls.Add(this.txtXacNhanMatKhau);
            this.guna2Panel2.Controls.Add(this.txtMatKhau);
            this.guna2Panel2.Controls.Add(this.lblTaiKhoan);
            this.guna2Panel2.Controls.Add(this.txtTenTaiKhoan);
            this.guna2Panel2.Controls.Add(this.lblSDT);
            this.guna2Panel2.Controls.Add(this.txtSoDienThoai);
            this.guna2Panel2.Controls.Add(this.lblEmail);
            this.guna2Panel2.Controls.Add(this.txtEmail);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel2.Controls.Add(this.btn_Thoat);
            this.guna2Panel2.Controls.Add(this.btnDangKy);
            this.guna2Panel2.Controls.Add(this.txtTenNguoiDung);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel2.Location = new System.Drawing.Point(615, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(518, 585);
            this.guna2Panel2.TabIndex = 28;
            // 
            // lblTenNguoiDung
            // 
            this.lblTenNguoiDung.AutoSize = false;
            this.lblTenNguoiDung.BackColor = System.Drawing.Color.Transparent;
            this.lblTenNguoiDung.ForeColor = System.Drawing.Color.Red;
            this.lblTenNguoiDung.Location = new System.Drawing.Point(90, 275);
            this.lblTenNguoiDung.Name = "lblTenNguoiDung";
            this.lblTenNguoiDung.Size = new System.Drawing.Size(545, 20);
            this.lblTenNguoiDung.TabIndex = 57;
            this.lblTenNguoiDung.Text = "Tên người dùng không bao gồm ký tự đặc biệt và số.";
            this.lblTenNguoiDung.Visible = false;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = false;
            this.lblMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.lblMatKhau.ForeColor = System.Drawing.Color.Red;
            this.lblMatKhau.Location = new System.Drawing.Point(97, 202);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(381, 18);
            this.lblMatKhau.TabIndex = 56;
            this.lblMatKhau.Text = "Mật khẩu không khớp.";
            this.lblMatKhau.Visible = false;
            // 
            // txtXacNhanMatKhau
            // 
            this.txtXacNhanMatKhau.AutoRoundedCorners = true;
            this.txtXacNhanMatKhau.BorderRadius = 21;
            this.txtXacNhanMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtXacNhanMatKhau.DefaultText = "";
            this.txtXacNhanMatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtXacNhanMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtXacNhanMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtXacNhanMatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtXacNhanMatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtXacNhanMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtXacNhanMatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtXacNhanMatKhau.Location = new System.Drawing.Point(84, 223);
            this.txtXacNhanMatKhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            this.txtXacNhanMatKhau.PasswordChar = '•';
            this.txtXacNhanMatKhau.PlaceholderText = "Xác nhận mật khẩu";
            this.txtXacNhanMatKhau.SelectedText = "";
            this.txtXacNhanMatKhau.Size = new System.Drawing.Size(361, 44);
            this.txtXacNhanMatKhau.TabIndex = 54;
            this.txtXacNhanMatKhau.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.AutoRoundedCorners = true;
            this.txtMatKhau.BorderRadius = 21;
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.DefaultText = "";
            this.txtMatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhau.Location = new System.Drawing.Point(84, 147);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '•';
            this.txtMatKhau.PlaceholderText = "Mật khẩu";
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.Size = new System.Drawing.Size(361, 44);
            this.txtMatKhau.TabIndex = 53;
            this.txtMatKhau.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = false;
            this.lblTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.lblTaiKhoan.ForeColor = System.Drawing.Color.Red;
            this.lblTaiKhoan.Location = new System.Drawing.Point(99, 52);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(416, 20);
            this.lblTaiKhoan.TabIndex = 52;
            this.lblTaiKhoan.Text = "Tên tài khoản không bao gồm ký tự đặc biệt.";
            this.lblTaiKhoan.Visible = false;
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.AutoRoundedCorners = true;
            this.txtTenTaiKhoan.BorderRadius = 21;
            this.txtTenTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenTaiKhoan.DefaultText = "";
            this.txtTenTaiKhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenTaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenTaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenTaiKhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenTaiKhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenTaiKhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(86, 75);
            this.txtTenTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.PasswordChar = '\0';
            this.txtTenTaiKhoan.PlaceholderText = "Tên tài khoản";
            this.txtTenTaiKhoan.SelectedText = "";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(361, 44);
            this.txtTenTaiKhoan.TabIndex = 51;
            this.txtTenTaiKhoan.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = false;
            this.lblSDT.BackColor = System.Drawing.Color.Transparent;
            this.lblSDT.ForeColor = System.Drawing.Color.Red;
            this.lblSDT.Location = new System.Drawing.Point(99, 430);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(852, 18);
            this.lblSDT.TabIndex = 50;
            this.lblSDT.Text = "SĐT không bao gồm chữ và ký tự đặc biệt.(10-11 ký tự)";
            this.lblSDT.Visible = false;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.AutoRoundedCorners = true;
            this.txtSoDienThoai.BorderRadius = 21;
            this.txtSoDienThoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoDienThoai.DefaultText = "";
            this.txtSoDienThoai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoDienThoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoDienThoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDienThoai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDienThoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoDienThoai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDienThoai.Location = new System.Drawing.Point(86, 451);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.PasswordChar = '\0';
            this.txtSoDienThoai.PlaceholderText = "Số điện thoại";
            this.txtSoDienThoai.SelectedText = "";
            this.txtSoDienThoai.Size = new System.Drawing.Size(361, 44);
            this.txtSoDienThoai.TabIndex = 49;
            this.txtSoDienThoai.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = false;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.ForeColor = System.Drawing.Color.Red;
            this.lblEmail.Location = new System.Drawing.Point(99, 351);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(434, 18);
            this.lblEmail.TabIndex = 46;
            this.lblEmail.Text = "Vui lòng nhập đúng định dạng email (@gmail.com).";
            this.lblEmail.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoRoundedCorners = true;
            this.txtEmail.BorderRadius = 21;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(86, 373);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(361, 44);
            this.txtEmail.TabIndex = 42;
            this.txtEmail.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(161, 17);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(317, 29);
            this.guna2HtmlLabel1.TabIndex = 41;
            this.guna2HtmlLabel1.Text = "Đăng kí tài khoản";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.Transparent;
            this.btn_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_Thoat.Image")));
            this.btn_Thoat.ImageRotate = 0F;
            this.btn_Thoat.Location = new System.Drawing.Point(484, 3);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_Thoat.Size = new System.Drawing.Size(31, 29);
            this.btn_Thoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Thoat.TabIndex = 40;
            this.btn_Thoat.TabStop = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.AutoRoundedCorners = true;
            this.btnDangKy.BorderColor = System.Drawing.Color.Transparent;
            this.btnDangKy.BorderRadius = 19;
            this.btnDangKy.BorderThickness = 1;
            this.btnDangKy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDangKy.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(48)))), ((int)(((byte)(100)))));
            this.btnDangKy.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnDangKy.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(48)))), ((int)(((byte)(100)))));
            this.btnDangKy.Location = new System.Drawing.Point(191, 528);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(177, 41);
            this.btnDangKy.TabIndex = 32;
            this.btnDangKy.Text = "Đăng kí";
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // txtTenNguoiDung
            // 
            this.txtTenNguoiDung.AutoRoundedCorners = true;
            this.txtTenNguoiDung.BorderRadius = 21;
            this.txtTenNguoiDung.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNguoiDung.DefaultText = "";
            this.txtTenNguoiDung.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNguoiDung.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNguoiDung.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenNguoiDung.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNguoiDung.Location = new System.Drawing.Point(86, 299);
            this.txtTenNguoiDung.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenNguoiDung.Name = "txtTenNguoiDung";
            this.txtTenNguoiDung.PasswordChar = '\0';
            this.txtTenNguoiDung.PlaceholderText = "Tên người dùng";
            this.txtTenNguoiDung.SelectedText = "";
            this.txtTenNguoiDung.Size = new System.Drawing.Size(361, 44);
            this.txtTenNguoiDung.TabIndex = 30;
            this.txtTenNguoiDung.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Panel1.BackgroundImage")));
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel1.BorderThickness = 3;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(619, 585);
            this.guna2Panel1.TabIndex = 26;
            // 
            // FrmDangKi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 585);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDangKi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDangKi";
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Thoat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btn_Thoat;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnDangKy;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNguoiDung;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEmail;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMatKhau;
        private Guna.UI2.WinForms.Guna2TextBox txtXacNhanMatKhau;
        private Guna.UI2.WinForms.Guna2TextBox txtMatKhau;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTaiKhoan;
        private Guna.UI2.WinForms.Guna2TextBox txtTenTaiKhoan;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSDT;
        private Guna.UI2.WinForms.Guna2TextBox txtSoDienThoai;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTenNguoiDung;
    }
}