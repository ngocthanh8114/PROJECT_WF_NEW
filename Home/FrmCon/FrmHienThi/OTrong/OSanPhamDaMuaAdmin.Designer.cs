namespace Home.FrmCon.FrmHienThi.OTrong
{
    partial class OSanPhamDaMuaAdmin
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
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblMaDH = new System.Windows.Forms.Label();
            this.dtpNgayMua = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.picBoxSP = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenSP
            // 
            this.lblTenSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTenSP.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.ForeColor = System.Drawing.Color.Black;
            this.lblTenSP.Location = new System.Drawing.Point(0, 172);
            this.lblTenSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(210, 46);
            this.lblTenSP.TabIndex = 38;
            this.lblTenSP.Text = "SH 150i";
            this.lblTenSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTieuDe.ForeColor = System.Drawing.Color.Black;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(93, 36);
            this.lblTieuDe.TabIndex = 47;
            this.lblTieuDe.Text = "  Số lượng:";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.lblSoLuong.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblSoLuong.ForeColor = System.Drawing.Color.Black;
            this.lblSoLuong.Location = new System.Drawing.Point(95, 0);
            this.lblSoLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(115, 36);
            this.lblSoLuong.TabIndex = 51;
            this.lblSoLuong.Text = "12 chiếc";
            this.lblSoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.lblTieuDe);
            this.guna2Panel1.Controls.Add(this.lblSoLuong);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 218);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(210, 36);
            this.guna2Panel1.TabIndex = 52;
            // 
            // lblMaDH
            // 
            this.lblMaDH.AutoSize = true;
            this.lblMaDH.Location = new System.Drawing.Point(173, 159);
            this.lblMaDH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaDH.Name = "lblMaDH";
            this.lblMaDH.Size = new System.Drawing.Size(38, 13);
            this.lblMaDH.TabIndex = 54;
            this.lblMaDH.Text = "MaDH";
            // 
            // dtpNgayMua
            // 
            this.dtpNgayMua.Checked = true;
            this.dtpNgayMua.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpNgayMua.Enabled = false;
            this.dtpNgayMua.FillColor = System.Drawing.Color.Tomato;
            this.dtpNgayMua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayMua.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayMua.Location = new System.Drawing.Point(0, 0);
            this.dtpNgayMua.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayMua.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayMua.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayMua.Name = "dtpNgayMua";
            this.dtpNgayMua.Size = new System.Drawing.Size(210, 29);
            this.dtpNgayMua.TabIndex = 55;
            this.dtpNgayMua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpNgayMua.Value = new System.DateTime(2024, 4, 24, 22, 54, 14, 282);
            // 
            // picBoxSP
            // 
            this.picBoxSP.BackColor = System.Drawing.Color.White;
            this.picBoxSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.picBoxSP.Image = global::Home.Properties.Resources.maxresdefault;
            this.picBoxSP.ImageRotate = 0F;
            this.picBoxSP.Location = new System.Drawing.Point(0, 29);
            this.picBoxSP.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxSP.Name = "picBoxSP";
            this.picBoxSP.Size = new System.Drawing.Size(210, 143);
            this.picBoxSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxSP.TabIndex = 45;
            this.picBoxSP.TabStop = false;
            // 
            // OSanPhamDaMuaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblMaDH);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.picBoxSP);
            this.Controls.Add(this.dtpNgayMua);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OSanPhamDaMuaAdmin";
            this.Size = new System.Drawing.Size(210, 270);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblTieuDe;
        private Guna.UI2.WinForms.Guna2PictureBox picBoxSP;
        private System.Windows.Forms.Label lblSoLuong;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblMaDH;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayMua;
    }
}
