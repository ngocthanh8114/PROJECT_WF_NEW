namespace Home.FrmCon
{
    partial class SanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPham));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.cbLocGia = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnTimKiem = new Guna.UI.WinForms.GunaCircleButton();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboLoaiSP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelNoiDung = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel1.Controls.Add(this.cbLocGia);
            this.guna2Panel1.Controls.Add(this.btnTimKiem);
            this.guna2Panel1.Controls.Add(this.txtTimKiem);
            this.guna2Panel1.Controls.Add(this.cboLoaiSP);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
<<<<<<< HEAD
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> 92cbfe04b132fc2bf2f528e2e2f09f400713666b
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(2051, 75);
            this.guna2Panel1.TabIndex = 3;
            // 
            // cbLocGia
<<<<<<< HEAD
            // 
            this.cbLocGia.AutoRoundedCorners = true;
            this.cbLocGia.BackColor = System.Drawing.Color.Transparent;
            this.cbLocGia.BorderColor = System.Drawing.Color.Gray;
            this.cbLocGia.BorderRadius = 17;
            this.cbLocGia.DisabledState.BorderColor = System.Drawing.Color.Tomato;
            this.cbLocGia.DisabledState.ForeColor = System.Drawing.Color.Tomato;
            this.cbLocGia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLocGia.DropDownHeight = 200;
            this.cbLocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocGia.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLocGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cbLocGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbLocGia.HoverState.BorderColor = System.Drawing.Color.Tomato;
            this.cbLocGia.HoverState.ForeColor = System.Drawing.Color.Tomato;
            this.cbLocGia.IntegralHeight = false;
            this.cbLocGia.ItemHeight = 30;
            this.cbLocGia.Items.AddRange(new object[] {
            "Dưới 20 triệu",
            "Từ 20 triệu đến 50 triệu",
            "Từ 50 triệu đến 150 triệu",
            "Trừ 150 triệu đến 300 triệu",
            "Trên 300 triệu"});
            this.cbLocGia.Location = new System.Drawing.Point(45, 21);
            this.cbLocGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLocGia.Name = "cbLocGia";
            this.cbLocGia.Size = new System.Drawing.Size(371, 36);
            this.cbLocGia.TabIndex = 6;
            this.cbLocGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbLocGia.TextOffset = new System.Drawing.Point(10, 3);
            this.cbLocGia.SelectedIndexChanged += new System.EventHandler(this.cbLocGia_SelectedIndexChanged);
=======
            // 
            this.cbLocGia.AutoRoundedCorners = true;
            this.cbLocGia.BackColor = System.Drawing.Color.Transparent;
            this.cbLocGia.BorderColor = System.Drawing.Color.Gray;
            this.cbLocGia.BorderRadius = 17;
            this.cbLocGia.DisabledState.BorderColor = System.Drawing.Color.Tomato;
            this.cbLocGia.DisabledState.ForeColor = System.Drawing.Color.Tomato;
            this.cbLocGia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLocGia.DropDownHeight = 200;
            this.cbLocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocGia.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLocGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cbLocGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbLocGia.HoverState.BorderColor = System.Drawing.Color.Tomato;
            this.cbLocGia.HoverState.ForeColor = System.Drawing.Color.Tomato;
            this.cbLocGia.IntegralHeight = false;
            this.cbLocGia.ItemHeight = 30;
            this.cbLocGia.Items.AddRange(new object[] {
            "Dưới 20 triệu",
            "Từ 20 triệu đến 50 triệu",
            "Từ 50 triệu đến 150 triệu",
            "Từ 150 triệu đến 300 triệu",
            "Trên 300 triệu"});
            this.cbLocGia.Location = new System.Drawing.Point(17, 17);
            this.cbLocGia.Margin = new System.Windows.Forms.Padding(2);
            this.cbLocGia.Name = "cbLocGia";
            this.cbLocGia.Size = new System.Drawing.Size(279, 36);
            this.cbLocGia.TabIndex = 6;
            this.cbLocGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbLocGia.TextOffset = new System.Drawing.Point(10, 3);
            this.cbLocGia.SelectedIndexChanged += new System.EventHandler(this.cbLocGia_SelectedIndexChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Animated = true;
            this.btnTimKiem.AnimationHoverSpeed = 0.07F;
            this.btnTimKiem.AnimationSpeed = 0.03F;
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.BackgroundImage")));
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiem.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTimKiem.BorderColor = System.Drawing.Color.Black;
            this.btnTimKiem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTimKiem.FocusedColor = System.Drawing.Color.Empty;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTimKiem.Location = new System.Drawing.Point(1220, 8);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.OnHoverBaseColor = System.Drawing.Color.Coral;
            this.btnTimKiem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTimKiem.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTimKiem.OnHoverImage = null;
            this.btnTimKiem.OnPressedColor = System.Drawing.Color.Black;
            this.btnTimKiem.Size = new System.Drawing.Size(49, 45);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Animated = true;
            this.txtTimKiem.AutoRoundedCorners = true;
            this.txtTimKiem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTimKiem.BorderRadius = 21;
            this.txtTimKiem.BorderThickness = 2;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.Tomato;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Location = new System.Drawing.Point(1027, 10);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "Tìm kiếm";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(188, 45);
            this.txtTimKiem.TabIndex = 4;
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
            this.cboLoaiSP.Location = new System.Drawing.Point(524, 17);
            this.cboLoaiSP.Margin = new System.Windows.Forms.Padding(2);
            this.cboLoaiSP.Name = "cboLoaiSP";
            this.cboLoaiSP.Size = new System.Drawing.Size(498, 36);
            this.cboLoaiSP.TabIndex = 3;
            this.cboLoaiSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cboLoaiSP.TextOffset = new System.Drawing.Point(10, 3);
            this.cboLoaiSP.SelectedIndexChanged += new System.EventHandler(this.cboLoaiSP_SelectedIndexChanged);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 61);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1538, 3);
            this.guna2Panel2.TabIndex = 1;
            // 
            // panelNoiDung
            // 
            this.panelNoiDung.AutoScroll = true;
            this.panelNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNoiDung.Location = new System.Drawing.Point(0, 64);
            this.panelNoiDung.Margin = new System.Windows.Forms.Padding(2);
            this.panelNoiDung.Name = "panelNoiDung";
            this.panelNoiDung.Size = new System.Drawing.Size(1538, 658);
            this.panelNoiDung.TabIndex = 2;
            this.panelNoiDung.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNoiDung_Paint);
>>>>>>> 92cbfe04b132fc2bf2f528e2e2f09f400713666b
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Animated = true;
            this.btnTimKiem.AnimationHoverSpeed = 0.07F;
            this.btnTimKiem.AnimationSpeed = 0.03F;
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.BackgroundImage")));
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiem.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTimKiem.BorderColor = System.Drawing.Color.Black;
            this.btnTimKiem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTimKiem.FocusedColor = System.Drawing.Color.Empty;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTimKiem.Location = new System.Drawing.Point(1627, 21);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.OnHoverBaseColor = System.Drawing.Color.Coral;
            this.btnTimKiem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTimKiem.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTimKiem.OnHoverImage = null;
            this.btnTimKiem.OnPressedColor = System.Drawing.Color.Black;
            this.btnTimKiem.Size = new System.Drawing.Size(47, 36);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Animated = true;
            this.txtTimKiem.AutoRoundedCorners = true;
            this.txtTimKiem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTimKiem.BorderRadius = 17;
            this.txtTimKiem.BorderThickness = 2;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.Tomato;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Location = new System.Drawing.Point(1369, 21);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "Tìm kiếm";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(251, 36);
            this.txtTimKiem.TabIndex = 4;
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
            this.cboLoaiSP.Location = new System.Drawing.Point(699, 21);
            this.cboLoaiSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboLoaiSP.Name = "cboLoaiSP";
            this.cboLoaiSP.Size = new System.Drawing.Size(663, 36);
            this.cboLoaiSP.TabIndex = 3;
            this.cboLoaiSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cboLoaiSP.TextOffset = new System.Drawing.Point(10, 3);
            this.cboLoaiSP.SelectedIndexChanged += new System.EventHandler(this.cboLoaiSP_SelectedIndexChanged);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 75);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(2051, 4);
            this.guna2Panel2.TabIndex = 1;
            // 
            // panelNoiDung
            // 
            this.panelNoiDung.AutoScroll = true;
            this.panelNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNoiDung.Location = new System.Drawing.Point(0, 79);
            this.panelNoiDung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelNoiDung.Name = "panelNoiDung";
            this.panelNoiDung.Size = new System.Drawing.Size(2051, 810);
            this.panelNoiDung.TabIndex = 2;
            this.panelNoiDung.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNoiDung_Paint);
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelNoiDung);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
<<<<<<< HEAD
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> 92cbfe04b132fc2bf2f528e2e2f09f400713666b
            this.Name = "SanPham";
            this.Size = new System.Drawing.Size(2051, 889);
            this.Load += new System.EventHandler(this.SanPham_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ComboBox cboLoaiSP;
        private System.Windows.Forms.FlowLayoutPanel panelNoiDung;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI.WinForms.GunaCircleButton btnTimKiem;
        private Guna.UI2.WinForms.Guna2ComboBox cbLocGia;
    }
}
