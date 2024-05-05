namespace Home.FrmCon.FrmConAdmin.UCThanhPhan
{
    partial class OBaoDuongXeMay
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
            this.panelNoiDung = new Guna.UI2.WinForms.Guna2Panel();
            this.PannelNoiDung2 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelNoiDung.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNoiDung
            // 
            this.panelNoiDung.BorderColor = System.Drawing.Color.Black;
            this.panelNoiDung.BorderThickness = 2;
            this.panelNoiDung.Controls.Add(this.PannelNoiDung2);
            this.panelNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNoiDung.Location = new System.Drawing.Point(0, 0);
            this.panelNoiDung.Name = "panelNoiDung";
            this.panelNoiDung.Size = new System.Drawing.Size(1775, 797);
            this.panelNoiDung.TabIndex = 2;
            // 
            // PannelNoiDung2
            // 
            this.PannelNoiDung2.BorderColor = System.Drawing.Color.Black;
            this.PannelNoiDung2.Location = new System.Drawing.Point(52, 44);
            this.PannelNoiDung2.Name = "PannelNoiDung2";
            this.PannelNoiDung2.Size = new System.Drawing.Size(1672, 715);
            this.PannelNoiDung2.TabIndex = 0;
            // 
            // OBaoDuongXeMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelNoiDung);
            this.Name = "OBaoDuongXeMay";
            this.Size = new System.Drawing.Size(1775, 797);
            this.Load += new System.EventHandler(this.OBaoDuongXeMay_Load);
            this.panelNoiDung.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelNoiDung;
        private Guna.UI2.WinForms.Guna2Panel PannelNoiDung2;
    }
}
