namespace Home.FrmCon.FrmBaoCao
{
    partial class FrmIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIn));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.crystalnhaphang = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.pb_MoTo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnThuNho = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MoTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThuNho)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Panel1.Controls.Add(this.btnThuNho);
            this.guna2Panel1.Controls.Add(this.pb_MoTo);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1296, 56);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Button1.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(1246, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(50, 56);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "X";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // crystalnhaphang
            // 
            this.crystalnhaphang.ActiveViewIndex = -1;
            this.crystalnhaphang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalnhaphang.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalnhaphang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalnhaphang.Location = new System.Drawing.Point(0, 56);
            this.crystalnhaphang.Name = "crystalnhaphang";
            this.crystalnhaphang.Size = new System.Drawing.Size(1296, 626);
            this.crystalnhaphang.TabIndex = 1;
            // 
            // pb_MoTo
            // 
            this.pb_MoTo.Image = ((System.Drawing.Image)(resources.GetObject("pb_MoTo.Image")));
            this.pb_MoTo.ImageRotate = 0F;
            this.pb_MoTo.Location = new System.Drawing.Point(1216, 14);
            this.pb_MoTo.Name = "pb_MoTo";
            this.pb_MoTo.Size = new System.Drawing.Size(26, 26);
            this.pb_MoTo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_MoTo.TabIndex = 2;
            this.pb_MoTo.TabStop = false;
            this.pb_MoTo.Click += new System.EventHandler(this.pb_MoTo_Click);
            // 
            // btnThuNho
            // 
            this.btnThuNho.Image = ((System.Drawing.Image)(resources.GetObject("btnThuNho.Image")));
            this.btnThuNho.ImageRotate = 0F;
            this.btnThuNho.Location = new System.Drawing.Point(1206, 10);
            this.btnThuNho.Name = "btnThuNho";
            this.btnThuNho.Size = new System.Drawing.Size(37, 38);
            this.btnThuNho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnThuNho.TabIndex = 3;
            this.btnThuNho.TabStop = false;
            this.btnThuNho.Visible = false;
            this.btnThuNho.Click += new System.EventHandler(this.btnThuNho_Click);
            // 
            // FrmIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 682);
            this.Controls.Add(this.crystalnhaphang);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmIn";
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_MoTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThuNho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalnhaphang;
        private Guna.UI2.WinForms.Guna2PictureBox pb_MoTo;
        private Guna.UI2.WinForms.Guna2PictureBox btnThuNho;
    }
}