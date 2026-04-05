namespace QuanLyCuaHangSachMini.GUI
{
    partial class frmHoaDon
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            grpDanhSachHoaDon = new Guna.UI2.WinForms.Guna2GroupBox();
            dataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            ID = new DataGridViewTextBoxColumn();
            MaHoaDon = new DataGridViewTextBoxColumn();
            HoVaTenNhanVien = new DataGridViewTextBoxColumn();
            HoVaTenKhachHang = new DataGridViewTextBoxColumn();
            NgayLap = new DataGridViewTextBoxColumn();
            TongTienHoaDon = new DataGridViewTextBoxColumn();
            XemChiTiet = new DataGridViewLinkColumn();
            btnLapHoaDon = new Guna.UI2.WinForms.Guna2Button();
            btnInHoaDon = new Guna.UI2.WinForms.Guna2Button();
            btnSua = new Guna.UI2.WinForms.Guna2Button();
            btnXoa = new Guna.UI2.WinForms.Guna2Button();
            btnThoat = new Guna.UI2.WinForms.Guna2Button();
            btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            btnXuat = new Guna.UI2.WinForms.Guna2Button();
            grpDanhSachHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // grpDanhSachHoaDon
            // 
            grpDanhSachHoaDon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpDanhSachHoaDon.BorderColor = Color.FromArgb(43, 43, 64);
            grpDanhSachHoaDon.BorderRadius = 8;
            grpDanhSachHoaDon.Controls.Add(dataGridView);
            grpDanhSachHoaDon.CustomBorderColor = Color.FromArgb(43, 43, 64);
            grpDanhSachHoaDon.CustomizableEdges = customizableEdges1;
            grpDanhSachHoaDon.FillColor = Color.FromArgb(30, 30, 45);
            grpDanhSachHoaDon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpDanhSachHoaDon.ForeColor = Color.White;
            grpDanhSachHoaDon.Location = new Point(11, 12);
            grpDanhSachHoaDon.Name = "grpDanhSachHoaDon";
            grpDanhSachHoaDon.Padding = new Padding(5, 45, 5, 5);
            grpDanhSachHoaDon.ShadowDecoration.CustomizableEdges = customizableEdges2;
            grpDanhSachHoaDon.Size = new Size(989, 430);
            grpDanhSachHoaDon.TabIndex = 0;
            grpDanhSachHoaDon.Text = "DANH SÁCH HÓA ĐƠN";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(26, 26, 39);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(63, 66, 84);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.BackgroundColor = Color.FromArgb(30, 30, 45);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(54, 153, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(54, 153, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.ColumnHeadersHeight = 40;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, MaHoaDon, HoVaTenNhanVien, HoVaTenKhachHang, NgayLap, TongTienHoaDon, XemChiTiet });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(30, 30, 45);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(63, 66, 84);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.GridColor = Color.FromArgb(43, 43, 64);
            dataGridView.Location = new Point(5, 85);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 40;
            dataGridView.Size = new Size(979, 340);
            dataGridView.TabIndex = 0;
            dataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            dataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dataGridView.ThemeStyle.BackColor = Color.FromArgb(30, 30, 45);
            dataGridView.ThemeStyle.GridColor = Color.FromArgb(43, 43, 64);
            dataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(54, 153, 255);
            dataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.ThemeStyle.HeaderStyle.Height = 40;
            dataGridView.ThemeStyle.ReadOnly = true;
            dataGridView.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(30, 30, 45);
            dataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dataGridView.ThemeStyle.RowsStyle.ForeColor = Color.White;
            dataGridView.ThemeStyle.RowsStyle.Height = 40;
            dataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(63, 66, 84);
            dataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.FillWeight = 55F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // MaHoaDon
            // 
            MaHoaDon.DataPropertyName = "MaHoaDon";
            MaHoaDon.HeaderText = "Mã hóa đơn";
            MaHoaDon.MinimumWidth = 6;
            MaHoaDon.Name = "MaHoaDon";
            MaHoaDon.ReadOnly = true;
            // 
            // HoVaTenNhanVien
            // 
            HoVaTenNhanVien.DataPropertyName = "HoVaTenNhanVien";
            HoVaTenNhanVien.HeaderText = "Nhân viên";
            HoVaTenNhanVien.MinimumWidth = 6;
            HoVaTenNhanVien.Name = "HoVaTenNhanVien";
            HoVaTenNhanVien.ReadOnly = true;
            // 
            // HoVaTenKhachHang
            // 
            HoVaTenKhachHang.DataPropertyName = "HoVaTenKhachHang";
            HoVaTenKhachHang.HeaderText = "Khách hàng";
            HoVaTenKhachHang.MinimumWidth = 6;
            HoVaTenKhachHang.Name = "HoVaTenKhachHang";
            HoVaTenKhachHang.ReadOnly = true;
            // 
            // NgayLap
            // 
            NgayLap.DataPropertyName = "NgayLap";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            NgayLap.DefaultCellStyle = dataGridViewCellStyle3;
            NgayLap.HeaderText = "Ngày lập";
            NgayLap.MinimumWidth = 6;
            NgayLap.Name = "NgayLap";
            NgayLap.ReadOnly = true;
            // 
            // TongTienHoaDon
            // 
            TongTienHoaDon.DataPropertyName = "TongTienHoaDon";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(54, 153, 255);
            dataGridViewCellStyle4.Format = "N0";
            TongTienHoaDon.DefaultCellStyle = dataGridViewCellStyle4;
            TongTienHoaDon.HeaderText = "Tổng tiền";
            TongTienHoaDon.MinimumWidth = 6;
            TongTienHoaDon.Name = "TongTienHoaDon";
            TongTienHoaDon.ReadOnly = true;
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
            // btnLapHoaDon
            // 
            btnLapHoaDon.Animated = true;
            btnLapHoaDon.BorderRadius = 5;
            btnLapHoaDon.CustomizableEdges = customizableEdges3;
            btnLapHoaDon.FillColor = Color.FromArgb(16, 185, 129);
            btnLapHoaDon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLapHoaDon.ForeColor = Color.White;
            btnLapHoaDon.Location = new Point(118, 458);
            btnLapHoaDon.Name = "btnLapHoaDon";
            btnLapHoaDon.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnLapHoaDon.Size = new Size(130, 35);
            btnLapHoaDon.TabIndex = 1;
            btnLapHoaDon.Text = "Lập hóa đơn";
            btnLapHoaDon.Click += btnLapHoaDon_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Animated = true;
            btnInHoaDon.BorderRadius = 5;
            btnInHoaDon.CustomizableEdges = customizableEdges5;
            btnInHoaDon.FillColor = Color.FromArgb(27, 197, 189);
            btnInHoaDon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnInHoaDon.ForeColor = Color.White;
            btnInHoaDon.Location = new Point(264, 458);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnInHoaDon.Size = new Size(120, 35);
            btnInHoaDon.TabIndex = 2;
            btnInHoaDon.Text = "In hóa đơn";
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // btnSua
            // 
            btnSua.Animated = true;
            btnSua.BorderRadius = 5;
            btnSua.CustomizableEdges = customizableEdges7;
            btnSua.FillColor = Color.FromArgb(54, 153, 255);
            btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(400, 458);
            btnSua.Name = "btnSua";
            btnSua.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnSua.Size = new Size(70, 35);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Animated = true;
            btnXoa.BorderRadius = 5;
            btnXoa.CustomizableEdges = customizableEdges9;
            btnXoa.FillColor = Color.FromArgb(246, 78, 96);
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(486, 458);
            btnXoa.Name = "btnXoa";
            btnXoa.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnXoa.Size = new Size(70, 35);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Animated = true;
            btnThoat.BorderRadius = 5;
            btnThoat.CustomizableEdges = customizableEdges11;
            btnThoat.FillColor = Color.FromArgb(63, 66, 84);
            btnThoat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(572, 458);
            btnThoat.Name = "btnThoat";
            btnThoat.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnThoat.Size = new Size(80, 35);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Đóng";
            btnThoat.Click += btnThoat_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Animated = true;
            btnTimKiem.BorderRadius = 5;
            btnTimKiem.CustomizableEdges = customizableEdges13;
            btnTimKiem.FillColor = Color.FromArgb(114, 57, 234);
            btnTimKiem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(668, 458);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnTimKiem.Size = new Size(110, 35);
            btnTimKiem.TabIndex = 6;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnXuat
            // 
            btnXuat.Animated = true;
            btnXuat.BorderRadius = 5;
            btnXuat.CustomizableEdges = customizableEdges13;
            btnXuat.FillColor = Color.FromArgb(27, 197, 189);
            btnXuat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXuat.ForeColor = Color.White;
            btnXuat.Location = new Point(784, 458);
            btnXuat.Name = "btnXuat";
            btnXuat.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnXuat.Size = new Size(86, 35);
            btnXuat.TabIndex = 7;
            btnXuat.Text = "Xuất";
            btnXuat.Click += btnXuat_Click;
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 39);
            ClientSize = new Size(1012, 512);
            Controls.Add(btnXuat);
            Controls.Add(btnTimKiem);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnInHoaDon);
            Controls.Add(btnLapHoaDon);
            Controls.Add(grpDanhSachHoaDon);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHoaDon";
            Text = "Hóa Đơn";
            Load += frmHoaDon_Load;
            grpDanhSachHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox grpDanhSachHoaDon;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView;
        private Guna.UI2.WinForms.Guna2Button btnLapHoaDon;
        private Guna.UI2.WinForms.Guna2Button btnInHoaDon;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnThoat;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private Guna.UI2.WinForms.Guna2Button btnXuat;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn MaHoaDon;
        private DataGridViewTextBoxColumn HoVaTenNhanVien;
        private DataGridViewTextBoxColumn HoVaTenKhachHang;
        private DataGridViewTextBoxColumn NgayLap;
        private DataGridViewTextBoxColumn TongTienHoaDon;
        private DataGridViewLinkColumn XemChiTiet;
    }
}
