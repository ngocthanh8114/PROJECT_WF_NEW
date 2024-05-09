namespace Home.FrmCon.FrmConAdmin.UCThanhPhan
{
    partial class ODaMua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ODaMua));
            this.lblTenSP = new System.Windows.Forms.Label();
            this.picBoxSP = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dtpNgayMua = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.guna2Panel9 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaDH = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSP)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTenSP
            // 
            this.lblTenSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTenSP.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.ForeColor = System.Drawing.Color.Black;
            this.lblTenSP.Location = new System.Drawing.Point(0, 172);
            this.lblTenSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(301, 35);
            this.lblTenSP.TabIndex = 56;
            this.lblTenSP.Text = "SH 150i";
            this.lblTenSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBoxSP
            // 
            this.picBoxSP.BackColor = System.Drawing.Color.White;
            this.picBoxSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.picBoxSP.Image = ((System.Drawing.Image)(resources.GetObject("picBoxSP.Image")));
            this.picBoxSP.ImageRotate = 0F;
            this.picBoxSP.Location = new System.Drawing.Point(0, 29);
            this.picBoxSP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBoxSP.Name = "picBoxSP";
            this.picBoxSP.Size = new System.Drawing.Size(301, 143);
            this.picBoxSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxSP.TabIndex = 57;
            this.picBoxSP.TabStop = false;
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
            this.dtpNgayMua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpNgayMua.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayMua.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayMua.Name = "dtpNgayMua";
            this.dtpNgayMua.Size = new System.Drawing.Size(301, 29);
            this.dtpNgayMua.TabIndex = 62;
            this.dtpNgayMua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpNgayMua.Value = new System.DateTime(2024, 4, 24, 22, 54, 14, 282);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.lblTieuDe);
            this.guna2Panel1.Controls.Add(this.lblSoLuong);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 207);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(301, 36);
            this.guna2Panel1.TabIndex = 63;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
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
            this.lblTieuDe.Size = new System.Drawing.Size(84, 36);
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
            this.lblSoLuong.Location = new System.Drawing.Point(198, 0);
            this.lblSoLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(103, 36);
            this.lblSoLuong.TabIndex = 51;
            this.lblSoLuong.Text = "12 chiếc";
            this.lblSoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // guna2Panel9
            // 
            this.guna2Panel9.BackColor = System.Drawing.Color.Red;
            this.guna2Panel9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel9.Location = new System.Drawing.Point(0, 279);
            this.guna2Panel9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel9.Name = "guna2Panel9";
            this.guna2Panel9.Size = new System.Drawing.Size(301, 5);
            this.guna2Panel9.TabIndex = 64;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.lblMaDH);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 243);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(301, 36);
            this.guna2Panel2.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 36);
            this.label1.TabIndex = 47;
            this.label1.Text = "  Mã đơn:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMaDH
            // 
            this.lblMaDH.BackColor = System.Drawing.Color.Transparent;
            this.lblMaDH.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMaDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblMaDH.ForeColor = System.Drawing.Color.Black;
            this.lblMaDH.Location = new System.Drawing.Point(198, 0);
            this.lblMaDH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaDH.Name = "lblMaDH";
            this.lblMaDH.Size = new System.Drawing.Size(103, 36);
            this.lblMaDH.TabIndex = 51;
            this.lblMaDH.Text = "MaDH";
            this.lblMaDH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ODaMua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel9);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.picBoxSP);
            this.Controls.Add(this.dtpNgayMua);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ODaMua";
            this.Size = new System.Drawing.Size(301, 284);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSP)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTenSP;
        private Guna.UI2.WinForms.Guna2PictureBox picBoxSP;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayMua;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblSoLuong;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel9;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaDH;
    }
}
