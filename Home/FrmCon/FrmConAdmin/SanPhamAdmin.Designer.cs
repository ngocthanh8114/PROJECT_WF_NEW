namespace Home.FrmCon
{
    partial class SanPhamAdmin
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
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.cboLoaiSP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelNoiDung = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelTop.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelTop.Controls.Add(this.cboLoaiSP);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(2050, 75);
            this.panelTop.TabIndex = 3;
            // 
            // cboLoaiSP
            // 
            this.cboLoaiSP.AutoRoundedCorners = true;
            this.cboLoaiSP.BackColor = System.Drawing.Color.Transparent;
            this.cboLoaiSP.BorderColor = System.Drawing.Color.Gray;
            this.cboLoaiSP.BorderRadius = 17;
            this.cboLoaiSP.DisabledState.BorderColor = System.Drawing.Color.Tomato;
            this.cboLoaiSP.DisabledState.ForeColor = System.Drawing.Color.Tomato;
            this.cboLoaiSP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLoaiSP.DropDownHeight = 200;
            this.cboLoaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiSP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLoaiSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cboLoaiSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLoaiSP.HoverState.BorderColor = System.Drawing.Color.Tomato;
            this.cboLoaiSP.HoverState.ForeColor = System.Drawing.Color.Tomato;
            this.cboLoaiSP.IntegralHeight = false;
            this.cboLoaiSP.ItemHeight = 30;
            this.cboLoaiSP.Location = new System.Drawing.Point(698, 21);
            this.cboLoaiSP.Name = "cboLoaiSP";
            this.cboLoaiSP.Size = new System.Drawing.Size(663, 36);
            this.cboLoaiSP.TabIndex = 3;
            this.cboLoaiSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cboLoaiSP.TextOffset = new System.Drawing.Point(10, 3);
            this.cboLoaiSP.SelectedIndexChanged += new System.EventHandler(this.cboLoaiSP_SelectedIndexChanged);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Gray;
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 75);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(2050, 4);
            this.guna2Panel2.TabIndex = 0;
            // 
            // panelNoiDung
            // 
            this.panelNoiDung.AutoScroll = true;
            this.panelNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNoiDung.Location = new System.Drawing.Point(0, 79);
            this.panelNoiDung.Name = "panelNoiDung";
            this.panelNoiDung.Size = new System.Drawing.Size(2050, 809);
            this.panelNoiDung.TabIndex = 4;
            // 
            // SanPhamAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelNoiDung);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.panelTop);
            this.Name = "SanPhamAdmin";
            this.Size = new System.Drawing.Size(2050, 888);
            this.Load += new System.EventHandler(this.SanPhamAdmin_Load);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox cboLoaiSP;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private System.Windows.Forms.FlowLayoutPanel panelNoiDung;
    }
}
