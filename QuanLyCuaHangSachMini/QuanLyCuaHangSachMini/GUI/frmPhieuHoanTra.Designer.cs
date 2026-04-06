namespace QuanLyCuaHangSachMini.GUI
{
    partial class frmPhieuHoanTra
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
            grpDanhSachPhieuHoanTra = new Guna.UI2.WinForms.Guna2GroupBox();
            dgvPhieuHoanTra = new Guna.UI2.WinForms.Guna2DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoaDonID = new DataGridViewTextBoxColumn();
            NhanVienID = new DataGridViewTextBoxColumn();
            KhachHangID = new DataGridViewTextBoxColumn();
            MaPhieuHoanTra = new DataGridViewTextBoxColumn();
            MaHoaDon = new DataGridViewTextBoxColumn();
            TenNhanVien = new DataGridViewTextBoxColumn();
            TenKhachHang = new DataGridViewTextBoxColumn();
            NgayHoanTra = new DataGridViewTextBoxColumn();
            TongTienHoan = new DataGridViewTextBoxColumn();
            XemChiTiet = new DataGridViewLinkColumn();
            btnInPhieu = new Guna.UI2.WinForms.Guna2Button();
            btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            btnThoat = new Guna.UI2.WinForms.Guna2Button();
            grpDanhSachPhieuHoanTra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuHoanTra).BeginInit();
            SuspendLayout();
            // 
            // grpDanhSachPhieuHoanTra
            // 
            grpDanhSachPhieuHoanTra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpDanhSachPhieuHoanTra.BorderColor = Color.FromArgb(43, 43, 64);
            grpDanhSachPhieuHoanTra.BorderRadius = 8;
            grpDanhSachPhieuHoanTra.Controls.Add(dgvPhieuHoanTra);
            grpDanhSachPhieuHoanTra.CustomBorderColor = Color.FromArgb(43, 43, 64);
            grpDanhSachPhieuHoanTra.CustomizableEdges = customizableEdges1;
            grpDanhSachPhieuHoanTra.FillColor = Color.FromArgb(30, 30, 45);
            grpDanhSachPhieuHoanTra.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpDanhSachPhieuHoanTra.ForeColor = Color.White;
            grpDanhSachPhieuHoanTra.Location = new Point(12, 12);
            grpDanhSachPhieuHoanTra.Name = "grpDanhSachPhieuHoanTra";
            grpDanhSachPhieuHoanTra.Padding = new Padding(5, 45, 5, 5);
            grpDanhSachPhieuHoanTra.ShadowDecoration.CustomizableEdges = customizableEdges2;
            grpDanhSachPhieuHoanTra.Size = new Size(1010, 430);
            grpDanhSachPhieuHoanTra.TabIndex = 0;
            grpDanhSachPhieuHoanTra.Text = "DANH SÁCH PHIẾU HOÀN TRẢ";
            // 
            // dgvPhieuHoanTra
            // 
            dgvPhieuHoanTra.AllowUserToAddRows = false;
            dgvPhieuHoanTra.AllowUserToDeleteRows = false;
            dgvPhieuHoanTra.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(26, 26, 39);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(63, 66, 84);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvPhieuHoanTra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPhieuHoanTra.BackgroundColor = Color.FromArgb(30, 30, 45);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(54, 153, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(54, 153, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPhieuHoanTra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPhieuHoanTra.ColumnHeadersHeight = 40;
            dgvPhieuHoanTra.Columns.AddRange(new DataGridViewColumn[] { ID, HoaDonID, NhanVienID, KhachHangID, MaPhieuHoanTra, MaHoaDon, TenNhanVien, TenKhachHang, NgayHoanTra, TongTienHoan, XemChiTiet });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(30, 30, 45);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(63, 66, 84);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvPhieuHoanTra.DefaultCellStyle = dataGridViewCellStyle5;
            dgvPhieuHoanTra.Dock = DockStyle.Fill;
            dgvPhieuHoanTra.GridColor = Color.FromArgb(43, 43, 64);
            dgvPhieuHoanTra.Location = new Point(5, 85);
            dgvPhieuHoanTra.MultiSelect = false;
            dgvPhieuHoanTra.Name = "dgvPhieuHoanTra";
            dgvPhieuHoanTra.ReadOnly = true;
            dgvPhieuHoanTra.RowHeadersVisible = false;
            dgvPhieuHoanTra.RowHeadersWidth = 51;
            dgvPhieuHoanTra.RowTemplate.Height = 40;
            dgvPhieuHoanTra.Size = new Size(1000, 340);
            dgvPhieuHoanTra.TabIndex = 0;
            dgvPhieuHoanTra.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvPhieuHoanTra.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvPhieuHoanTra.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvPhieuHoanTra.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvPhieuHoanTra.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvPhieuHoanTra.ThemeStyle.BackColor = Color.FromArgb(30, 30, 45);
            dgvPhieuHoanTra.ThemeStyle.GridColor = Color.FromArgb(43, 43, 64);
            dgvPhieuHoanTra.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(54, 153, 255);
            dgvPhieuHoanTra.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPhieuHoanTra.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvPhieuHoanTra.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvPhieuHoanTra.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPhieuHoanTra.ThemeStyle.HeaderStyle.Height = 40;
            dgvPhieuHoanTra.ThemeStyle.ReadOnly = true;
            dgvPhieuHoanTra.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(30, 30, 45);
            dgvPhieuHoanTra.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPhieuHoanTra.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvPhieuHoanTra.ThemeStyle.RowsStyle.ForeColor = Color.White;
            dgvPhieuHoanTra.ThemeStyle.RowsStyle.Height = 40;
            dgvPhieuHoanTra.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(63, 66, 84);
            dgvPhieuHoanTra.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvPhieuHoanTra.CellClick += dgvPhieuHoanTra_CellClick;
            dgvPhieuHoanTra.CellContentClick += dgvPhieuHoanTra_CellContentClick;
            dgvPhieuHoanTra.DataError += dgvPhieuHoanTra_DataError;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // HoaDonID
            // 
            HoaDonID.DataPropertyName = "HoaDonID";
            HoaDonID.HeaderText = "HoaDonID";
            HoaDonID.MinimumWidth = 6;
            HoaDonID.Name = "HoaDonID";
            HoaDonID.ReadOnly = true;
            HoaDonID.Visible = false;
            // 
            // NhanVienID
            // 
            NhanVienID.DataPropertyName = "NhanVienID";
            NhanVienID.HeaderText = "NhanVienID";
            NhanVienID.MinimumWidth = 6;
            NhanVienID.Name = "NhanVienID";
            NhanVienID.ReadOnly = true;
            NhanVienID.Visible = false;
            // 
            // KhachHangID
            // 
            KhachHangID.DataPropertyName = "KhachHangID";
            KhachHangID.HeaderText = "KhachHangID";
            KhachHangID.MinimumWidth = 6;
            KhachHangID.Name = "KhachHangID";
            KhachHangID.ReadOnly = true;
            KhachHangID.Visible = false;
            // 
            // MaPhieuHoanTra
            // 
            MaPhieuHoanTra.DataPropertyName = "MaPhieuHoanTra";
            MaPhieuHoanTra.HeaderText = "Mã phiếu hoàn trả";
            MaPhieuHoanTra.MinimumWidth = 6;
            MaPhieuHoanTra.Name = "MaPhieuHoanTra";
            MaPhieuHoanTra.ReadOnly = true;
            // 
            // MaHoaDon
            // 
            MaHoaDon.DataPropertyName = "MaHoaDon";
            MaHoaDon.HeaderText = "Mã hóa đơn";
            MaHoaDon.MinimumWidth = 6;
            MaHoaDon.Name = "MaHoaDon";
            MaHoaDon.ReadOnly = true;
            // 
            // TenNhanVien
            // 
            TenNhanVien.DataPropertyName = "TenNhanVien";
            TenNhanVien.HeaderText = "Nhân viên";
            TenNhanVien.MinimumWidth = 6;
            TenNhanVien.Name = "TenNhanVien";
            TenNhanVien.ReadOnly = true;
            // 
            // TenKhachHang
            // 
            TenKhachHang.DataPropertyName = "TenKhachHang";
            TenKhachHang.HeaderText = "Khách hàng";
            TenKhachHang.MinimumWidth = 6;
            TenKhachHang.Name = "TenKhachHang";
            TenKhachHang.ReadOnly = true;
            // 
            // NgayHoanTra
            // 
            NgayHoanTra.DataPropertyName = "NgayHoanTra";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            NgayHoanTra.DefaultCellStyle = dataGridViewCellStyle3;
            NgayHoanTra.HeaderText = "Ngày hoàn trả";
            NgayHoanTra.MinimumWidth = 6;
            NgayHoanTra.Name = "NgayHoanTra";
            NgayHoanTra.ReadOnly = true;
            // 
            // TongTienHoan
            // 
            TongTienHoan.DataPropertyName = "TongTienHoan";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(54, 153, 255);
            dataGridViewCellStyle4.Format = "N0";
            TongTienHoan.DefaultCellStyle = dataGridViewCellStyle4;
            TongTienHoan.HeaderText = "Tổng tiền hoàn";
            TongTienHoan.MinimumWidth = 6;
            TongTienHoan.Name = "TongTienHoan";
            TongTienHoan.ReadOnly = true;
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
            // btnInPhieu
            // 
            btnInPhieu.Animated = true;
            btnInPhieu.BorderRadius = 5;
            btnInPhieu.CustomizableEdges = customizableEdges3;
            btnInPhieu.FillColor = Color.FromArgb(255, 184, 34);
            btnInPhieu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnInPhieu.ForeColor = Color.White;
            btnInPhieu.Location = new Point(353, 458);
            btnInPhieu.Name = "btnInPhieu";
            btnInPhieu.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnInPhieu.Size = new Size(110, 35);
            btnInPhieu.TabIndex = 1;
            btnInPhieu.Text = "In phiếu";
            btnInPhieu.Click += btnInPhieu_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Animated = true;
            btnLamMoi.BorderRadius = 5;
            btnLamMoi.CustomizableEdges = customizableEdges4;
            btnLamMoi.FillColor = Color.FromArgb(27, 197, 189);
            btnLamMoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(481, 458);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.ShadowDecoration.CustomizableEdges = customizableEdges5;
            btnLamMoi.Size = new Size(110, 35);
            btnLamMoi.TabIndex = 2;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnThoat
            // 
            btnThoat.Animated = true;
            btnThoat.BorderRadius = 5;
            btnThoat.CustomizableEdges = customizableEdges5;
            btnThoat.FillColor = Color.FromArgb(63, 66, 84);
            btnThoat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(609, 458);
            btnThoat.Name = "btnThoat";
            btnThoat.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnThoat.Size = new Size(90, 35);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Đóng";
            btnThoat.Click += btnThoat_Click;
            // 
            // frmPhieuHoanTra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 39);
            ClientSize = new Size(1034, 512);
            Controls.Add(btnThoat);
            Controls.Add(btnLamMoi);
            Controls.Add(btnInPhieu);
            Controls.Add(grpDanhSachPhieuHoanTra);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPhieuHoanTra";
            Text = "Phiếu hoàn trả";
            Load += frmPhieuHoanTra_Load;
            grpDanhSachPhieuHoanTra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPhieuHoanTra).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox grpDanhSachPhieuHoanTra;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPhieuHoanTra;
        private Guna.UI2.WinForms.Guna2Button btnInPhieu;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Button btnThoat;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoaDonID;
        private DataGridViewTextBoxColumn NhanVienID;
        private DataGridViewTextBoxColumn KhachHangID;
        private DataGridViewTextBoxColumn MaPhieuHoanTra;
        private DataGridViewTextBoxColumn MaHoaDon;
        private DataGridViewTextBoxColumn TenNhanVien;
        private DataGridViewTextBoxColumn TenKhachHang;
        private DataGridViewTextBoxColumn NgayHoanTra;
        private DataGridViewTextBoxColumn TongTienHoan;
        private DataGridViewLinkColumn XemChiTiet;
    }
}
