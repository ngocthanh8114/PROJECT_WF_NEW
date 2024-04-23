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
            this.guna2Panel9 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel8 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel9
            // 
            this.guna2Panel9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2Panel9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel9.Location = new System.Drawing.Point(0, 75);
            this.guna2Panel9.Name = "guna2Panel9";
            this.guna2Panel9.Size = new System.Drawing.Size(1174, 4);
            this.guna2Panel9.TabIndex = 21;
            // 
            // guna2Panel8
            // 
            this.guna2Panel8.BackColor = System.Drawing.Color.White;
            this.guna2Panel8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel8.Controls.Add(this.label4);
            this.guna2Panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel8.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel8.Name = "guna2Panel8";
            this.guna2Panel8.Size = new System.Drawing.Size(1174, 75);
            this.guna2Panel8.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 32);
            this.label4.TabIndex = 16;
            this.label4.Text = "Đơn hàng của tôi";
            // 
            // DonHangDaMua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel9);
            this.Controls.Add(this.guna2Panel8);
            this.Name = "DonHangDaMua";
            this.Size = new System.Drawing.Size(1174, 703);
            this.guna2Panel8.ResumeLayout(false);
            this.guna2Panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel9;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel8;
        private System.Windows.Forms.Label label4;
    }
}
