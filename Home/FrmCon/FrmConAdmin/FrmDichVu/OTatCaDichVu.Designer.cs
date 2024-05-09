namespace Home.FrmCon.FrmConAdmin.UCThanhPhan
{
    partial class OTatCaDichVu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OTatCaDichVu));
            this.panelNoiDung = new Guna.UI2.WinForms.Guna2Panel();
            this.dgDichVu = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tenkhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biensoxe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaidichvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnTimKiem = new Guna.UI.WinForms.GunaCircleButton();
            this.cboPhanLoai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panelNoiDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNoiDung
            // 
            this.panelNoiDung.BorderColor = System.Drawing.Color.Black;
            this.panelNoiDung.BorderThickness = 2;
            this.panelNoiDung.Controls.Add(this.cboPhanLoai);
            this.panelNoiDung.Controls.Add(this.btnTimKiem);
            this.panelNoiDung.Controls.Add(this.dtpEnd);
            this.panelNoiDung.Controls.Add(this.dtpStart);
            this.panelNoiDung.Controls.Add(this.dgDichVu);
            this.panelNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNoiDung.Location = new System.Drawing.Point(0, 0);
            this.panelNoiDung.Name = "panelNoiDung";
            this.panelNoiDung.Size = new System.Drawing.Size(1775, 797);
            this.panelNoiDung.TabIndex = 0;
            // 
            // dgDichVu
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgDichVu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgDichVu.ColumnHeadersHeight = 18;
            this.dgDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenkhachhang,
            this.biensoxe,
            this.thoigian,
            this.sodienthoai,
            this.loaidichvu,
            this.trangthai});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDichVu.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgDichVu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgDichVu.Location = new System.Drawing.Point(44, 89);
            this.dgDichVu.Name = "dgDichVu";
            this.dgDichVu.ReadOnly = true;
            this.dgDichVu.RowHeadersVisible = false;
            this.dgDichVu.RowHeadersWidth = 51;
            this.dgDichVu.RowTemplate.Height = 24;
            this.dgDichVu.Size = new System.Drawing.Size(1686, 628);
            this.dgDichVu.TabIndex = 1;
            this.dgDichVu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgDichVu.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgDichVu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgDichVu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgDichVu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgDichVu.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgDichVu.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgDichVu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgDichVu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgDichVu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgDichVu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgDichVu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgDichVu.ThemeStyle.HeaderStyle.Height = 18;
            this.dgDichVu.ThemeStyle.ReadOnly = true;
            this.dgDichVu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgDichVu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgDichVu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgDichVu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgDichVu.ThemeStyle.RowsStyle.Height = 24;
            this.dgDichVu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgDichVu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // tenkhachhang
            // 
            this.tenkhachhang.DataPropertyName = "TenKhachHang";
            this.tenkhachhang.HeaderText = "Tên khách hàng";
            this.tenkhachhang.MinimumWidth = 6;
            this.tenkhachhang.Name = "tenkhachhang";
            this.tenkhachhang.ReadOnly = true;
            // 
            // biensoxe
            // 
            this.biensoxe.DataPropertyName = "BienSoXe";
            this.biensoxe.HeaderText = "Biển số xe";
            this.biensoxe.MinimumWidth = 6;
            this.biensoxe.Name = "biensoxe";
            this.biensoxe.ReadOnly = true;
            // 
            // thoigian
            // 
            this.thoigian.DataPropertyName = "NgayThang";
            this.thoigian.HeaderText = "Thời gian";
            this.thoigian.MinimumWidth = 6;
            this.thoigian.Name = "thoigian";
            this.thoigian.ReadOnly = true;
            // 
            // sodienthoai
            // 
            this.sodienthoai.HeaderText = "Số điện thoại";
            this.sodienthoai.MinimumWidth = 6;
            this.sodienthoai.Name = "sodienthoai";
            this.sodienthoai.ReadOnly = true;
            // 
            // loaidichvu
            // 
            this.loaidichvu.DataPropertyName = "LoaiDichVu";
            this.loaidichvu.HeaderText = "Loại dịch vụ";
            this.loaidichvu.MinimumWidth = 6;
            this.loaidichvu.Name = "loaidichvu";
            this.loaidichvu.ReadOnly = true;
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "TrangThai";
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.MinimumWidth = 6;
            this.trangthai.Name = "trangthai";
            this.trangthai.ReadOnly = true;
            // 
            // dtpStart
            // 
            this.dtpStart.BorderRadius = 5;
            this.dtpStart.Checked = true;
            this.dtpStart.FillColor = System.Drawing.Color.SteelBlue;
            this.dtpStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpStart.Location = new System.Drawing.Point(407, 20);
            this.dtpStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(240, 43);
            this.dtpStart.TabIndex = 2;
            this.dtpStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpStart.Value = new System.DateTime(2024, 5, 9, 10, 17, 14, 304);
            // 
            // dtpEnd
            // 
            this.dtpEnd.BorderRadius = 5;
            this.dtpEnd.Checked = true;
            this.dtpEnd.FillColor = System.Drawing.Color.SteelBlue;
            this.dtpEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpEnd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpEnd.Location = new System.Drawing.Point(689, 20);
            this.dtpEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(246, 43);
            this.dtpEnd.TabIndex = 3;
            this.dtpEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpEnd.Value = new System.DateTime(2024, 5, 9, 10, 17, 14, 304);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Animated = true;
            this.btnTimKiem.AnimationHoverSpeed = 0.07F;
            this.btnTimKiem.AnimationSpeed = 0.03F;
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.BackgroundImage")));
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiem.BaseColor = System.Drawing.Color.SteelBlue;
            this.btnTimKiem.BorderColor = System.Drawing.Color.Black;
            this.btnTimKiem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTimKiem.FocusedColor = System.Drawing.Color.Empty;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTimKiem.Location = new System.Drawing.Point(1263, 21);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.OnHoverBaseColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTimKiem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTimKiem.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTimKiem.OnHoverImage = null;
            this.btnTimKiem.OnPressedColor = System.Drawing.Color.Black;
            this.btnTimKiem.Size = new System.Drawing.Size(55, 45);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cboPhanLoai
            // 
            this.cboPhanLoai.BackColor = System.Drawing.Color.White;
            this.cboPhanLoai.BorderRadius = 5;
            this.cboPhanLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboPhanLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhanLoai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(144)))), ((int)(((byte)(186)))));
            this.cboPhanLoai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboPhanLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboPhanLoai.FocusedState.FillColor = System.Drawing.Color.Transparent;
            this.cboPhanLoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboPhanLoai.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cboPhanLoai.ItemHeight = 30;
            this.cboPhanLoai.Items.AddRange(new object[] {
            "Tất cả",
            "Chưa xử lí",
            "Đã xử lí"});
            this.cboPhanLoai.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.cboPhanLoai.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(144)))), ((int)(((byte)(186)))));
            this.cboPhanLoai.Location = new System.Drawing.Point(977, 20);
            this.cboPhanLoai.Name = "cboPhanLoai";
            this.cboPhanLoai.Size = new System.Drawing.Size(246, 36);
            this.cboPhanLoai.StartIndex = 0;
            this.cboPhanLoai.TabIndex = 5;
            this.cboPhanLoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OTatCaDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelNoiDung);
            this.Name = "OTatCaDichVu";
            this.Size = new System.Drawing.Size(1775, 797);
            this.Load += new System.EventHandler(this.OTatCaDichVu_Load);
            this.panelNoiDung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDichVu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelNoiDung;
        private Guna.UI2.WinForms.Guna2DataGridView dgDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn biensoxe;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigian;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaidichvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEnd;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStart;
        private Guna.UI.WinForms.GunaCircleButton btnTimKiem;
        private Guna.UI2.WinForms.Guna2ComboBox cboPhanLoai;
    }
}
