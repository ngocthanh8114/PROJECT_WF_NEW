namespace Home.FrmCon.FrmHienThi
{
    partial class OThem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OThem));
            this.PBThem = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBThem)).BeginInit();
            this.SuspendLayout();
            // 
            // PBThem
            // 
            this.PBThem.Image = ((System.Drawing.Image)(resources.GetObject("PBThem.Image")));
            this.PBThem.ImageRotate = 0F;
            this.PBThem.Location = new System.Drawing.Point(36, 114);
            this.PBThem.Name = "PBThem";
            this.PBThem.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PBThem.Size = new System.Drawing.Size(176, 179);
            this.PBThem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBThem.TabIndex = 0;
            this.PBThem.TabStop = false;
            this.PBThem.Click += new System.EventHandler(this.PBThem_Click);
            // 
            // OThem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.PBThem);
            this.Name = "OThem";
            this.Size = new System.Drawing.Size(247, 398);
            ((System.ComponentModel.ISupportInitialize)(this.PBThem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox PBThem;
    }
}
