namespace QuanLyCuaHangSachMini.GUI
{
    partial class frmPhieuNhap
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                context.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            grpDanhSachPhieuNhap = new Guna.UI2.WinForms.Guna2GroupBox();
            dgvPhieuNhap = new Guna.UI2.WinForms.Guna2DataGridView();
            ID = new DataGridViewTextBoxColumn();
            MaPhieuNhap = new DataGridViewTextBoxColumn();
            TenNhaCungCap = new DataGridViewTextBoxColumn();
            HoVaTenNhanVien = new DataGridViewTextBoxColumn();
            NgayNhap = new DataGridViewTextBoxColumn();
            TongTienPhieuNhap = new DataGridViewTextBoxColumn();
            XemChiTiet = new DataGridViewLinkColumn();
            btnLapPhieuNhap = new Guna.UI2.WinForms.Guna2Button();
            btnInPhieuNhap = new Guna.UI2.WinForms.Guna2Button();
            btnXoaPhieuNhap = new Guna.UI2.WinForms.Guna2Button();
            btnThoat = new Guna.UI2.WinForms.Guna2Button();
            grpDanhSachPhieuNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).BeginInit();
            SuspendLayout();
            // 
            // grpDanhSachPhieuNhap
            // 
            grpDanhSachPhieuNhap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpDanhSachPhieuNhap.BorderColor = Color.FromArgb(43, 43, 64);
            grpDanhSachPhieuNhap.BorderRadius = 8;
            grpDanhSachPhieuNhap.Controls.Add(dgvPhieuNhap);
            grpDanhSachPhieuNhap.CustomBorderColor = Color.FromArgb(43, 43, 64);
            grpDanhSachPhieuNhap.CustomizableEdges = customizableEdges1;
            grpDanhSachPhieuNhap.FillColor = Color.FromArgb(30, 30, 45);
            grpDanhSachPhieuNhap.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpDanhSachPhieuNhap.ForeColor = Color.White;
            grpDanhSachPhieuNhap.Location = new Point(12, 12);
            grpDanhSachPhieuNhap.Name = "grpDanhSachPhieuNhap";
            grpDanhSachPhieuNhap.Padding = new Padding(5, 45, 5, 5);
            grpDanhSachPhieuNhap.ShadowDecoration.CustomizableEdges = customizableEdges2;
            grpDanhSachPhieuNhap.Size = new Size(886, 430);
            grpDanhSachPhieuNhap.TabIndex = 0;
            grpDanhSachPhieuNhap.Text = "DANH SÁCH PHIẾU NHẬP";
            // 
            // dgvPhieuNhap
            // 
            dgvPhieuNhap.AllowUserToAddRows = false;
            dgvPhieuNhap.AllowUserToDeleteRows = false;
            dgvPhieuNhap.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(26, 26, 39);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(63, 66, 84);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvPhieuNhap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPhieuNhap.BackgroundColor = Color.FromArgb(30, 30, 45);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(54, 153, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(54, 153, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPhieuNhap.ColumnHeadersHeight = 40;
            dgvPhieuNhap.Columns.AddRange(new DataGridViewColumn[] { ID, MaPhieuNhap, TenNhaCungCap, HoVaTenNhanVien, NgayNhap, TongTienPhieuNhap, XemChiTiet });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(30, 30, 45);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(63, 66, 84);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvPhieuNhap.DefaultCellStyle = dataGridViewCellStyle5;
            dgvPhieuNhap.Dock = DockStyle.Fill;
            dgvPhieuNhap.GridColor = Color.FromArgb(43, 43, 64);
            dgvPhieuNhap.Location = new Point(5, 85);
            dgvPhieuNhap.MultiSelect = false;
            dgvPhieuNhap.Name = "dgvPhieuNhap";
            dgvPhieuNhap.ReadOnly = true;
            dgvPhieuNhap.RowHeadersVisible = false;
            dgvPhieuNhap.RowHeadersWidth = 51;
            dgvPhieuNhap.RowTemplate.Height = 40;
            dgvPhieuNhap.Size = new Size(876, 340);
            dgvPhieuNhap.TabIndex = 0;
            dgvPhieuNhap.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvPhieuNhap.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvPhieuNhap.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvPhieuNhap.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvPhieuNhap.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvPhieuNhap.ThemeStyle.BackColor = Color.FromArgb(30, 30, 45);
            dgvPhieuNhap.ThemeStyle.GridColor = Color.FromArgb(43, 43, 64);
            dgvPhieuNhap.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(54, 153, 255);
            dgvPhieuNhap.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPhieuNhap.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvPhieuNhap.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvPhieuNhap.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPhieuNhap.ThemeStyle.HeaderStyle.Height = 40;
            dgvPhieuNhap.ThemeStyle.ReadOnly = true;
            dgvPhieuNhap.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(30, 30, 45);
            dgvPhieuNhap.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPhieuNhap.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvPhieuNhap.ThemeStyle.RowsStyle.ForeColor = Color.White;
            dgvPhieuNhap.ThemeStyle.RowsStyle.Height = 40;
            dgvPhieuNhap.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(63, 66, 84);
            dgvPhieuNhap.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvPhieuNhap.CellClick += dgvPhieuNhap_CellClick;
            dgvPhieuNhap.CellContentClick += dgvPhieuNhap_CellContentClick;
            dgvPhieuNhap.DataError += dgvPhieuNhap_DataError;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.FillWeight = 50F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // MaPhieuNhap
            // 
            MaPhieuNhap.DataPropertyName = "MaPhieuNhap";
            MaPhieuNhap.HeaderText = "Mã phiếu nhập";
            MaPhieuNhap.MinimumWidth = 6;
            MaPhieuNhap.Name = "MaPhieuNhap";
            MaPhieuNhap.ReadOnly = true;
            // 
            // TenNhaCungCap
            // 
            TenNhaCungCap.DataPropertyName = "TenNhaCungCap";
            TenNhaCungCap.HeaderText = "Nhà cung cấp";
            TenNhaCungCap.MinimumWidth = 6;
            TenNhaCungCap.Name = "TenNhaCungCap";
            TenNhaCungCap.ReadOnly = true;
            // 
            // HoVaTenNhanVien
            // 
            HoVaTenNhanVien.DataPropertyName = "HoVaTenNhanVien";
            HoVaTenNhanVien.HeaderText = "Nhân viên";
            HoVaTenNhanVien.MinimumWidth = 6;
            HoVaTenNhanVien.Name = "HoVaTenNhanVien";
            HoVaTenNhanVien.ReadOnly = true;
            // 
            // NgayNhap
            // 
            NgayNhap.DataPropertyName = "NgayNhap";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            NgayNhap.DefaultCellStyle = dataGridViewCellStyle3;
            NgayNhap.HeaderText = "Ngày nhập";
            NgayNhap.MinimumWidth = 6;
            NgayNhap.Name = "NgayNhap";
            NgayNhap.ReadOnly = true;
            // 
            // TongTienPhieuNhap
            // 
            TongTienPhieuNhap.DataPropertyName = "TongTienPhieuNhap";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(54, 153, 255);
            dataGridViewCellStyle4.Format = "N0";
            TongTienPhieuNhap.DefaultCellStyle = dataGridViewCellStyle4;
            TongTienPhieuNhap.HeaderText = "Tổng tiền";
            TongTienPhieuNhap.MinimumWidth = 6;
            TongTienPhieuNhap.Name = "TongTienPhieuNhap";
            TongTienPhieuNhap.ReadOnly = true;
            // 
            // XemChiTiet
            // 
            XemChiTiet.DataPropertyName = "XemChiTiet";
            XemChiTiet.HeaderText = "Chi tiết";
            XemChiTiet.MinimumWidth = 6;
            XemChiTiet.Name = "XemChiTiet";
            XemChiTiet.ReadOnly = true;
            XemChiTiet.Resizable = DataGridViewTriState.True;
            XemChiTiet.SortMode = DataGridViewColumnSortMode.Automatic;
            XemChiTiet.TrackVisitedState = false;
            // 
            // btnLapPhieuNhap
            // 
            btnLapPhieuNhap.Animated = true;
            btnLapPhieuNhap.BorderRadius = 5;
            btnLapPhieuNhap.CustomizableEdges = customizableEdges3;
            btnLapPhieuNhap.FillColor = Color.FromArgb(16, 185, 129);
            btnLapPhieuNhap.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLapPhieuNhap.ForeColor = Color.White;
            btnLapPhieuNhap.Location = new Point(166, 460);
            btnLapPhieuNhap.Name = "btnLapPhieuNhap";
            btnLapPhieuNhap.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnLapPhieuNhap.Size = new Size(165, 40);
            btnLapPhieuNhap.TabIndex = 1;
            btnLapPhieuNhap.Text = "Lập phiếu nhập";
            btnLapPhieuNhap.Click += btnLapPhieuNhap_Click;
            // 
            // btnInPhieuNhap
            // 
            btnInPhieuNhap.Animated = true;
            btnInPhieuNhap.BorderRadius = 5;
            btnInPhieuNhap.CustomizableEdges = customizableEdges5;
            btnInPhieuNhap.FillColor = Color.FromArgb(27, 197, 189);
            btnInPhieuNhap.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnInPhieuNhap.ForeColor = Color.White;
            btnInPhieuNhap.Location = new Point(348, 460);
            btnInPhieuNhap.Name = "btnInPhieuNhap";
            btnInPhieuNhap.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnInPhieuNhap.Size = new Size(140, 40);
            btnInPhieuNhap.TabIndex = 2;
            btnInPhieuNhap.Text = "In phiếu nhập";
            btnInPhieuNhap.Click += btnInPhieuNhap_Click;
            // 
            // btnXoaPhieuNhap
            // 
            btnXoaPhieuNhap.Animated = true;
            btnXoaPhieuNhap.BorderRadius = 5;
            btnXoaPhieuNhap.CustomizableEdges = customizableEdges7;
            btnXoaPhieuNhap.FillColor = Color.FromArgb(246, 78, 96);
            btnXoaPhieuNhap.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXoaPhieuNhap.ForeColor = Color.White;
            btnXoaPhieuNhap.Location = new Point(506, 458);
            btnXoaPhieuNhap.Name = "btnXoaPhieuNhap";
            btnXoaPhieuNhap.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnXoaPhieuNhap.Size = new Size(90, 40);
            btnXoaPhieuNhap.TabIndex = 3;
            btnXoaPhieuNhap.Text = "Xóa";
            btnXoaPhieuNhap.Click += btnXoaPhieuNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Animated = true;
            btnThoat.BorderRadius = 5;
            btnThoat.CustomizableEdges = customizableEdges9;
            btnThoat.FillColor = Color.FromArgb(63, 66, 84);
            btnThoat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(612, 458);
            btnThoat.Name = "btnThoat";
            btnThoat.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnThoat.Size = new Size(90, 40);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Đóng";
            btnThoat.Click += btnThoat_Click;
            // 
            // frmPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 39);
            ClientSize = new Size(910, 512);
            Controls.Add(btnThoat);
            Controls.Add(btnXoaPhieuNhap);
            Controls.Add(btnInPhieuNhap);
            Controls.Add(btnLapPhieuNhap);
            Controls.Add(grpDanhSachPhieuNhap);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPhieuNhap";
            Text = "Phiếu Nhập";
            Load += frmPhieuNhap_Load;
            grpDanhSachPhieuNhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox grpDanhSachPhieuNhap;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPhieuNhap;
        private Guna.UI2.WinForms.Guna2Button btnLapPhieuNhap;
        private Guna.UI2.WinForms.Guna2Button btnInPhieuNhap;
        private Guna.UI2.WinForms.Guna2Button btnXoaPhieuNhap;
        private Guna.UI2.WinForms.Guna2Button btnThoat;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn MaPhieuNhap;
        private DataGridViewTextBoxColumn TenNhaCungCap;
        private DataGridViewTextBoxColumn HoVaTenNhanVien;
        private DataGridViewTextBoxColumn NgayNhap;
        private DataGridViewTextBoxColumn TongTienPhieuNhap;
        private DataGridViewLinkColumn XemChiTiet;
    }
}
