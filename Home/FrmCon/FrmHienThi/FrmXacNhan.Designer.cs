namespace Home.FrmCon.FrmHienThi
{
    partial class FrmXacNhan
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNoiDung = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnKhong = new Guna.UI2.WinForms.Guna2Button();
            this.btnCo = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.lbl);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(415, 46);
            this.guna2Panel1.TabIndex = 0;
            // 
            // lbl
            // 
            this.lbl.AutoSize = false;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(0, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(415, 46);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Xác nhận";
            this.lbl.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.lblNoiDung);
            this.guna2Panel2.Controls.Add(this.btnKhong);
            this.guna2Panel2.Controls.Add(this.btnCo);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 46);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(415, 210);
            this.guna2Panel2.TabIndex = 1;
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.AutoSize = false;
            this.lblNoiDung.BackColor = System.Drawing.Color.Transparent;
            this.lblNoiDung.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoiDung.Location = new System.Drawing.Point(0, 0);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(415, 137);
            this.lblNoiDung.TabIndex = 2;
            this.lblNoiDung.Text = "Bạn có chắc chắn muốn xóa không?";
            this.lblNoiDung.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKhong
            // 
            this.btnKhong.BorderThickness = 1;
            this.btnKhong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKhong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKhong.FillColor = System.Drawing.Color.White;
            this.btnKhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhong.ForeColor = System.Drawing.Color.Black;
            this.btnKhong.Location = new System.Drawing.Point(229, 143);
            this.btnKhong.Name = "btnKhong";
            this.btnKhong.Size = new System.Drawing.Size(149, 45);
            this.btnKhong.TabIndex = 1;
            this.btnKhong.Text = "Không";
            this.btnKhong.Click += new System.EventHandler(this.btnKhong_Click);
            // 
            // btnCo
            // 
            this.btnCo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCo.FillColor = System.Drawing.Color.Brown;
            this.btnCo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCo.ForeColor = System.Drawing.Color.White;
            this.btnCo.Location = new System.Drawing.Point(38, 143);
            this.btnCo.Name = "btnCo";
            this.btnCo.Size = new System.Drawing.Size(149, 45);
            this.btnCo.TabIndex = 0;
            this.btnCo.Text = "Có";
            this.btnCo.Click += new System.EventHandler(this.btnCo_Click);
            // 
            // FrmXacNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 256);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmXacNhan";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmXacNhan";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNoiDung;
        private Guna.UI2.WinForms.Guna2Button btnKhong;
        private Guna.UI2.WinForms.Guna2Button btnCo;
    }
}