namespace Home.FrmCon.FrmConAdmin.UCThanhPhan
{
    partial class ONhanVien
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
            this.pictureNhanVien = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureNhanVien
            // 
            this.pictureNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureNhanVien.ImageRotate = 0F;
            this.pictureNhanVien.Location = new System.Drawing.Point(0, 0);
            this.pictureNhanVien.Name = "pictureNhanVien";
            this.pictureNhanVien.Size = new System.Drawing.Size(245, 172);
            this.pictureNhanVien.TabIndex = 0;
            this.pictureNhanVien.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(58, 202);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(108, 18);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "guna2HtmlLabel1";
            // 
            // ONhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.pictureNhanVien);
            this.Name = "ONhanVien";
            this.Size = new System.Drawing.Size(245, 305);
            ((System.ComponentModel.ISupportInitialize)(this.pictureNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pictureNhanVien;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}
