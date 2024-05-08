namespace Home.FrmCon.FrmHienThi
{
    partial class DonHangDaMua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonHangDaMua));
            this.guna2Panel9 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel8 = new Guna.UI2.WinForms.Guna2Panel();
            this.cboDonMua = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelSP = new System.Windows.Forms.FlowLayoutPanel();
            this.panelNoiDung = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.donMuaTrong = new Home.FrmCon.FrmConUser.UCThanhPhan.OTrong.DonMuaTrong();
            this.guna2Panel8.SuspendLayout();
            this.panelSP.SuspendLayout();
            this.panelNoiDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel9
            // 
            this.guna2Panel9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2Panel9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel9.Location = new System.Drawing.Point(0, 60);
            this.guna2Panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel9.Name = "guna2Panel9";
            this.guna2Panel9.Size = new System.Drawing.Size(1173, 4);
            this.guna2Panel9.TabIndex = 21;
            // 
            // guna2Panel8
            // 
            this.guna2Panel8.BackColor = System.Drawing.Color.White;
            this.guna2Panel8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel8.Controls.Add(this.cboDonMua);
            this.guna2Panel8.Controls.Add(this.label4);
            this.guna2Panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel8.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel8.Name = "guna2Panel8";
            this.guna2Panel8.Size = new System.Drawing.Size(1173, 60);
            this.guna2Panel8.TabIndex = 20;
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
            this.cboDonMua.Location = new System.Drawing.Point(931, 9);
            this.cboDonMua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboDonMua.Name = "cboDonMua";
            this.cboDonMua.Size = new System.Drawing.Size(220, 36);
            this.cboDonMua.TabIndex = 17;
            this.cboDonMua.SelectedIndexChanged += new System.EventHandler(this.cboDonMua_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 32);
            this.label4.TabIndex = 16;
            this.label4.Text = "Đơn hàng của tôi";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 523);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1173, 4);
            this.guna2Panel1.TabIndex = 24;
            // 
            // panelSP
            // 
            this.panelSP.AutoScroll = true;
            this.panelSP.Controls.Add(this.guna2PictureBox1);
            this.panelSP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSP.Location = new System.Drawing.Point(0, 527);
            this.panelSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSP.Name = "panelSP";
            this.panelSP.Size = new System.Drawing.Size(1173, 288);
            this.panelSP.TabIndex = 23;
            // 
            // panelNoiDung
            // 
            this.panelNoiDung.AutoScroll = true;
            this.panelNoiDung.Controls.Add(this.donMuaTrong);
            this.panelNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNoiDung.Location = new System.Drawing.Point(0, 64);
            this.panelNoiDung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelNoiDung.Name = "panelNoiDung";
            this.panelNoiDung.Size = new System.Drawing.Size(1173, 459);
            this.panelNoiDung.TabIndex = 25;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.White;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(1167, 282);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // donMuaTrong
            // 
            this.donMuaTrong.BackColor = System.Drawing.Color.White;
            this.donMuaTrong.Location = new System.Drawing.Point(3, 3);
            this.donMuaTrong.Name = "donMuaTrong";
            this.donMuaTrong.Size = new System.Drawing.Size(1174, 438);
            this.donMuaTrong.TabIndex = 0;
            // 
            // DonHangDaMua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelNoiDung);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel9);
            this.Controls.Add(this.guna2Panel8);
            this.Controls.Add(this.panelSP);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DonHangDaMua";
            this.Size = new System.Drawing.Size(1173, 815);
            this.Load += new System.EventHandler(this.DonHangDaMua_Load);
            this.guna2Panel8.ResumeLayout(false);
            this.guna2Panel8.PerformLayout();
            this.panelSP.ResumeLayout(false);
            this.panelNoiDung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
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
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private FrmConUser.UCThanhPhan.OTrong.DonMuaTrong donMuaTrong;
    }
}
