namespace Home.FrmCon.FrmHienThi
{
    partial class OSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OSanPham));
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblNCC = new System.Windows.Forms.Label();
            this.numSL = new Guna.UI.WinForms.GunaNumeric();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.lblSL = new System.Windows.Forms.Label();
            this.btnDatHang = new Guna.UI.WinForms.GunaAdvenceButton();
            this.picBoxSP = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenSP
            // 
            this.lblTenSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTenSP.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.ForeColor = System.Drawing.Color.Black;
            this.lblTenSP.Location = new System.Drawing.Point(0, 200);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(247, 25);
            this.lblTenSP.TabIndex = 1;
            this.lblTenSP.Text = "SH 150i";
            this.lblTenSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGia
            // 
            this.lblGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblGia.ForeColor = System.Drawing.Color.Black;
            this.lblGia.Location = new System.Drawing.Point(-1, 225);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(265, 23);
            this.lblGia.TabIndex = 2;
            this.lblGia.Text = "Giá: 81.775.637 VNĐ";
            this.lblGia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNCC
            // 
            this.lblNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNCC.ForeColor = System.Drawing.Color.Black;
            this.lblNCC.Location = new System.Drawing.Point(1, 250);
            this.lblNCC.Name = "lblNCC";
            this.lblNCC.Size = new System.Drawing.Size(146, 50);
            this.lblNCC.TabIndex = 4;
            this.lblNCC.Text = "Hệ thống cửa hàng xe máy Phát Thịnh";
            this.lblNCC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numSL
            // 
            this.numSL.BaseColor = System.Drawing.Color.White;
            this.numSL.BorderColor = System.Drawing.Color.Silver;
            this.numSL.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numSL.ButtonForeColor = System.Drawing.Color.White;
            this.numSL.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numSL.ForeColor = System.Drawing.Color.Black;
            this.numSL.Location = new System.Drawing.Point(162, 313);
            this.numSL.Maximum = ((long)(9999999));
            this.numSL.Minimum = ((long)(0));
            this.numSL.Name = "numSL";
            this.numSL.Size = new System.Drawing.Size(84, 30);
            this.numSL.TabIndex = 6;
            this.numSL.Text = "gunaNumeric1";
            this.numSL.Value = ((long)(1));
            // 
            // lblMaSP
            // 
            this.lblMaSP.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblMaSP.ForeColor = System.Drawing.Color.Black;
            this.lblMaSP.Location = new System.Drawing.Point(162, 277);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(85, 23);
            this.lblMaSP.TabIndex = 7;
            this.lblMaSP.Text = "SP1";
            this.lblMaSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMaSP.Visible = false;
            // 
            // lblSL
            // 
            this.lblSL.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblSL.ForeColor = System.Drawing.Color.Black;
            this.lblSL.Location = new System.Drawing.Point(156, 248);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(91, 29);
            this.lblSL.TabIndex = 8;
            this.lblSL.Text = "50 cái";
            this.lblSL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDatHang
            // 
            this.btnDatHang.AnimationHoverSpeed = 0.07F;
            this.btnDatHang.AnimationSpeed = 0.03F;
            this.btnDatHang.BackColor = System.Drawing.Color.Transparent;
            this.btnDatHang.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDatHang.BorderColor = System.Drawing.Color.Black;
            this.btnDatHang.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnDatHang.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnDatHang.CheckedForeColor = System.Drawing.Color.White;
            this.btnDatHang.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnDatHang.CheckedImage")));
            this.btnDatHang.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnDatHang.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDatHang.FocusedColor = System.Drawing.Color.Empty;
            this.btnDatHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDatHang.ForeColor = System.Drawing.Color.White;
            this.btnDatHang.Image = ((System.Drawing.Image)(resources.GetObject("btnDatHang.Image")));
            this.btnDatHang.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDatHang.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDatHang.Location = new System.Drawing.Point(5, 306);
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDatHang.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDatHang.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDatHang.OnHoverImage = null;
            this.btnDatHang.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDatHang.OnPressedColor = System.Drawing.Color.Black;
            this.btnDatHang.Radius = 5;
            this.btnDatHang.Size = new System.Drawing.Size(121, 42);
            this.btnDatHang.TabIndex = 5;
            this.btnDatHang.Text = "Đặt hàng";
            this.btnDatHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDatHang.Click += new System.EventHandler(this.btnDatHang_Click);
            // 
            // picBoxSP
            // 
            this.picBoxSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.picBoxSP.Image = ((System.Drawing.Image)(resources.GetObject("picBoxSP.Image")));
            this.picBoxSP.ImageRotate = 0F;
            this.picBoxSP.Location = new System.Drawing.Point(0, 0);
            this.picBoxSP.Name = "picBoxSP";
            this.picBoxSP.Size = new System.Drawing.Size(247, 200);
            this.picBoxSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxSP.TabIndex = 0;
            this.picBoxSP.TabStop = false;
            // 
            // OSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblSL);
            this.Controls.Add(this.lblMaSP);
            this.Controls.Add(this.numSL);
            this.Controls.Add(this.btnDatHang);
            this.Controls.Add(this.lblNCC);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.picBoxSP);
            this.Name = "OSanPham";
            this.Size = new System.Drawing.Size(247, 351);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picBoxSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblNCC;
        private Guna.UI.WinForms.GunaAdvenceButton btnDatHang;
        private Guna.UI.WinForms.GunaNumeric numSL;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Label lblSL;
    }
}
