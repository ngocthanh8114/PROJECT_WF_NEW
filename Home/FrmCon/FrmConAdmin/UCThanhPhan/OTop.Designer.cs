namespace Home.FrmCon.FrmConAdmin.UCThanhPhan
{
    partial class OTop
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
            this.TopKhach = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelColor = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTop = new System.Windows.Forms.Label();
            this.panelColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopKhach
            // 
            this.TopKhach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TopKhach.DefaultText = "Quách Nguyễn Duy Thiện/10,000,000,000 VNĐ";
            this.TopKhach.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TopKhach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TopKhach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TopKhach.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TopKhach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopKhach.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TopKhach.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.TopKhach.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TopKhach.Location = new System.Drawing.Point(54, 0);
            this.TopKhach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TopKhach.Multiline = true;
            this.TopKhach.Name = "TopKhach";
            this.TopKhach.PasswordChar = '\0';
            this.TopKhach.PlaceholderText = "";
            this.TopKhach.ReadOnly = true;
            this.TopKhach.SelectedText = "";
            this.TopKhach.Size = new System.Drawing.Size(266, 54);
            this.TopKhach.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TopKhach.TabIndex = 58;
            this.TopKhach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelColor.Controls.Add(this.lblTop);
            this.panelColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelColor.Location = new System.Drawing.Point(0, 0);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(54, 54);
            this.panelColor.TabIndex = 59;
            // 
            // lblTop
            // 
            this.lblTop.BackColor = System.Drawing.Color.Gray;
            this.lblTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTop.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.ForeColor = System.Drawing.Color.White;
            this.lblTop.Location = new System.Drawing.Point(0, 0);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(54, 54);
            this.lblTop.TabIndex = 0;
            this.lblTop.Text = "1";
            this.lblTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OTop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TopKhach);
            this.Controls.Add(this.panelColor);
            this.Name = "OTop";
            this.Size = new System.Drawing.Size(320, 54);
            this.panelColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox TopKhach;
        private Guna.UI2.WinForms.Guna2Panel panelColor;
        private System.Windows.Forms.Label lblTop;
    }
}
