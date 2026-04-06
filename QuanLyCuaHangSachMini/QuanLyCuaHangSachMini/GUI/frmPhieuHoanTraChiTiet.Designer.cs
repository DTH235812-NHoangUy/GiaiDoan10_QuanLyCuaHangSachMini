
namespace QuanLyCuaHangSachMini.GUI
{
    partial class frmPhieuHoanTra_ChiTiet
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

        private Guna.UI2.WinForms.Guna2GroupBox grpThongTinPhieu;
        private Guna.UI2.WinForms.Guna2GroupBox grpThongTinChiTiet;
        private Guna.UI2.WinForms.Guna2GroupBox grpDanhSachChiTiet;
        private Guna.UI2.WinForms.Guna2DataGridView dgvChiTiet;
        private Guna.UI2.WinForms.Guna2Button btnThemSach;
        private Guna.UI2.WinForms.Guna2Button btnXoaSach;
        private Guna.UI2.WinForms.Guna2Button btnLuuPhieuHoanTra;
        private Guna.UI2.WinForms.Guna2Button btnHuyBo;
        private Guna.UI2.WinForms.Guna2Button btnThoat;
        private System.Windows.Forms.TextBox txtMaPhieuHoanTra;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.TextBox txtNgayHoanTra;
        private System.Windows.Forms.TextBox txtNhanVienXuLy;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.TextBox txtSoLuongBan;
        private System.Windows.Forms.ComboBox cboSach;
        private System.Windows.Forms.NumericUpDown numSoLuongTra;
        private System.Windows.Forms.NumericUpDown numDonGiaHoanTra;
        private System.Windows.Forms.Label lblMaPhieuHoanTra;
        private System.Windows.Forms.Label lblNgayHoanTra;
        private System.Windows.Forms.Label lblMaHoaDon;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.Label lblNhanVienXuLy;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblLyDo;
        private System.Windows.Forms.Label lblSach;
        private System.Windows.Forms.Label lblSoLuongBan;
        private System.Windows.Forms.Label lblSoLuongTra;
        private System.Windows.Forms.Label lblDonGiaHoanTra;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoaDonChiTietID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoaDonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SachID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaHoanTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            grpThongTinPhieu = new Guna.UI2.WinForms.Guna2GroupBox();
            lblMaPhieuHoanTra = new Label();
            txtMaPhieuHoanTra = new TextBox();
            lblNgayHoanTra = new Label();
            txtNgayHoanTra = new TextBox();
            lblMaHoaDon = new Label();
            txtMaHoaDon = new TextBox();
            lblKhachHang = new Label();
            txtKhachHang = new TextBox();
            lblNhanVienXuLy = new Label();
            txtNhanVienXuLy = new TextBox();
            lblTongTien = new Label();
            txtTongTien = new TextBox();
            lblLyDo = new Label();
            txtLyDo = new TextBox();
            grpThongTinChiTiet = new Guna.UI2.WinForms.Guna2GroupBox();
            lblSach = new Label();
            cboSach = new ComboBox();
            lblSoLuongBan = new Label();
            txtSoLuongBan = new TextBox();
            lblDonGiaHoanTra = new Label();
            numDonGiaHoanTra = new NumericUpDown();
            lblSoLuongTra = new Label();
            numSoLuongTra = new NumericUpDown();
            btnThemSach = new Guna.UI2.WinForms.Guna2Button();
            btnXoaSach = new Guna.UI2.WinForms.Guna2Button();
            grpDanhSachChiTiet = new Guna.UI2.WinForms.Guna2GroupBox();
            dgvChiTiet = new Guna.UI2.WinForms.Guna2DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoaDonChiTietID = new DataGridViewTextBoxColumn();
            HoaDonID = new DataGridViewTextBoxColumn();
            SachID = new DataGridViewTextBoxColumn();
            MaSach = new DataGridViewTextBoxColumn();
            TenSach = new DataGridViewTextBoxColumn();
            SoLuongBan = new DataGridViewTextBoxColumn();
            SoLuongTra = new DataGridViewTextBoxColumn();
            DonGiaHoanTra = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            btnLuuPhieuHoanTra = new Guna.UI2.WinForms.Guna2Button();
            btnHuyBo = new Guna.UI2.WinForms.Guna2Button();
            btnThoat = new Guna.UI2.WinForms.Guna2Button();
            dragControl = new Guna.UI2.WinForms.Guna2DragControl(components);
            grpThongTinPhieu.SuspendLayout();
            grpThongTinChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGiaHoanTra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongTra).BeginInit();
            grpDanhSachChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            SuspendLayout();
            // 
            // grpThongTinPhieu
            // 
            grpThongTinPhieu.BorderColor = Color.FromArgb(43, 43, 64);
            grpThongTinPhieu.BorderRadius = 8;
            grpThongTinPhieu.Controls.Add(lblMaPhieuHoanTra);
            grpThongTinPhieu.Controls.Add(txtMaPhieuHoanTra);
            grpThongTinPhieu.Controls.Add(lblNgayHoanTra);
            grpThongTinPhieu.Controls.Add(txtNgayHoanTra);
            grpThongTinPhieu.Controls.Add(lblMaHoaDon);
            grpThongTinPhieu.Controls.Add(txtMaHoaDon);
            grpThongTinPhieu.Controls.Add(lblKhachHang);
            grpThongTinPhieu.Controls.Add(txtKhachHang);
            grpThongTinPhieu.Controls.Add(lblNhanVienXuLy);
            grpThongTinPhieu.Controls.Add(txtNhanVienXuLy);
            grpThongTinPhieu.Controls.Add(lblTongTien);
            grpThongTinPhieu.Controls.Add(txtTongTien);
            grpThongTinPhieu.Controls.Add(lblLyDo);
            grpThongTinPhieu.Controls.Add(txtLyDo);
            grpThongTinPhieu.CustomBorderColor = Color.FromArgb(43, 43, 64);
            grpThongTinPhieu.CustomizableEdges = customizableEdges1;
            grpThongTinPhieu.FillColor = Color.FromArgb(30, 30, 45);
            grpThongTinPhieu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpThongTinPhieu.ForeColor = Color.White;
            grpThongTinPhieu.Location = new Point(11, 12);
            grpThongTinPhieu.Name = "grpThongTinPhieu";
            grpThongTinPhieu.Padding = new Padding(5, 45, 5, 5);
            grpThongTinPhieu.ShadowDecoration.CustomizableEdges = customizableEdges2;
            grpThongTinPhieu.Size = new Size(1008, 178);
            grpThongTinPhieu.TabIndex = 0;
            grpThongTinPhieu.Text = "THÔNG TIN PHIẾU HOÀN TRẢ";
            // 
            // lblMaPhieuHoanTra
            // 
            lblMaPhieuHoanTra.AutoSize = true;
            lblMaPhieuHoanTra.ForeColor = Color.FromArgb(161, 165, 183);
            lblMaPhieuHoanTra.Location = new Point(18, 47);
            lblMaPhieuHoanTra.Name = "lblMaPhieuHoanTra";
            lblMaPhieuHoanTra.Size = new Size(90, 23);
            lblMaPhieuHoanTra.TabIndex = 0;
            lblMaPhieuHoanTra.Text = "Mã phiếu:";
            // 
            // txtMaPhieuHoanTra
            // 
            txtMaPhieuHoanTra.BackColor = Color.FromArgb(26, 26, 39);
            txtMaPhieuHoanTra.BorderStyle = BorderStyle.FixedSingle;
            txtMaPhieuHoanTra.ForeColor = Color.White;
            txtMaPhieuHoanTra.Location = new Point(103, 44);
            txtMaPhieuHoanTra.Name = "txtMaPhieuHoanTra";
            txtMaPhieuHoanTra.ReadOnly = true;
            txtMaPhieuHoanTra.Size = new Size(220, 30);
            txtMaPhieuHoanTra.TabIndex = 1;
            // 
            // lblNgayHoanTra
            // 
            lblNgayHoanTra.AutoSize = true;
            lblNgayHoanTra.ForeColor = Color.FromArgb(161, 165, 183);
            lblNgayHoanTra.Location = new Point(18, 86);
            lblNgayHoanTra.Name = "lblNgayHoanTra";
            lblNgayHoanTra.Size = new Size(57, 23);
            lblNgayHoanTra.TabIndex = 2;
            lblNgayHoanTra.Text = "Ngày:";
            // 
            // txtNgayHoanTra
            // 
            txtNgayHoanTra.BackColor = Color.FromArgb(26, 26, 39);
            txtNgayHoanTra.BorderStyle = BorderStyle.FixedSingle;
            txtNgayHoanTra.ForeColor = Color.White;
            txtNgayHoanTra.Location = new Point(103, 83);
            txtNgayHoanTra.Name = "txtNgayHoanTra";
            txtNgayHoanTra.ReadOnly = true;
            txtNgayHoanTra.Size = new Size(220, 30);
            txtNgayHoanTra.TabIndex = 3;
            // 
            // lblMaHoaDon
            // 
            lblMaHoaDon.AutoSize = true;
            lblMaHoaDon.ForeColor = Color.FromArgb(161, 165, 183);
            lblMaHoaDon.Location = new Point(355, 47);
            lblMaHoaDon.Name = "lblMaHoaDon";
            lblMaHoaDon.Size = new Size(84, 23);
            lblMaHoaDon.TabIndex = 4;
            lblMaHoaDon.Text = "Hóa đơn:";
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.BackColor = Color.FromArgb(26, 26, 39);
            txtMaHoaDon.BorderStyle = BorderStyle.FixedSingle;
            txtMaHoaDon.ForeColor = Color.White;
            txtMaHoaDon.Location = new Point(455, 44);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.ReadOnly = true;
            txtMaHoaDon.Size = new Size(180, 30);
            txtMaHoaDon.TabIndex = 5;
            // 
            // lblKhachHang
            // 
            lblKhachHang.AutoSize = true;
            lblKhachHang.ForeColor = Color.FromArgb(161, 165, 183);
            lblKhachHang.Location = new Point(355, 86);
            lblKhachHang.Name = "lblKhachHang";
            lblKhachHang.Size = new Size(63, 23);
            lblKhachHang.TabIndex = 6;
            lblKhachHang.Text = "Khách:";
            // 
            // txtKhachHang
            // 
            txtKhachHang.BackColor = Color.FromArgb(26, 26, 39);
            txtKhachHang.BorderStyle = BorderStyle.FixedSingle;
            txtKhachHang.ForeColor = Color.White;
            txtKhachHang.Location = new Point(455, 83);
            txtKhachHang.Name = "txtKhachHang";
            txtKhachHang.ReadOnly = true;
            txtKhachHang.Size = new Size(180, 30);
            txtKhachHang.TabIndex = 7;
            // 
            // lblNhanVienXuLy
            // 
            lblNhanVienXuLy.AutoSize = true;
            lblNhanVienXuLy.ForeColor = Color.FromArgb(161, 165, 183);
            lblNhanVienXuLy.Location = new Point(655, 47);
            lblNhanVienXuLy.Name = "lblNhanVienXuLy";
            lblNhanVienXuLy.Size = new Size(139, 23);
            lblNhanVienXuLy.TabIndex = 8;
            lblNhanVienXuLy.Text = "Nhân viên xử lý:";
            // 
            // txtNhanVienXuLy
            // 
            txtNhanVienXuLy.BackColor = Color.FromArgb(26, 26, 39);
            txtNhanVienXuLy.BorderStyle = BorderStyle.FixedSingle;
            txtNhanVienXuLy.ForeColor = Color.White;
            txtNhanVienXuLy.Location = new Point(803, 44);
            txtNhanVienXuLy.Name = "txtNhanVienXuLy";
            txtNhanVienXuLy.ReadOnly = true;
            txtNhanVienXuLy.Size = new Size(180, 30);
            txtNhanVienXuLy.TabIndex = 9;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.ForeColor = Color.FromArgb(161, 165, 183);
            lblTongTien.Location = new Point(655, 86);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(92, 23);
            lblTongTien.TabIndex = 10;
            lblTongTien.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            txtTongTien.BackColor = Color.FromArgb(26, 26, 39);
            txtTongTien.BorderStyle = BorderStyle.FixedSingle;
            txtTongTien.ForeColor = Color.White;
            txtTongTien.Location = new Point(803, 83);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(180, 30);
            txtTongTien.TabIndex = 11;
            // 
            // lblLyDo
            // 
            lblLyDo.AutoSize = true;
            lblLyDo.ForeColor = Color.FromArgb(161, 165, 183);
            lblLyDo.Location = new Point(18, 124);
            lblLyDo.Name = "lblLyDo";
            lblLyDo.Size = new Size(59, 23);
            lblLyDo.TabIndex = 12;
            lblLyDo.Text = "Lý do:";
            // 
            // txtLyDo
            // 
            txtLyDo.BackColor = Color.FromArgb(26, 26, 39);
            txtLyDo.BorderStyle = BorderStyle.FixedSingle;
            txtLyDo.ForeColor = Color.White;
            txtLyDo.Location = new Point(103, 121);
            txtLyDo.Multiline = true;
            txtLyDo.Name = "txtLyDo";
            txtLyDo.Size = new Size(880, 30);
            txtLyDo.TabIndex = 13;
            // 
            // grpThongTinChiTiet
            // 
            grpThongTinChiTiet.BorderColor = Color.FromArgb(43, 43, 64);
            grpThongTinChiTiet.BorderRadius = 8;
            grpThongTinChiTiet.Controls.Add(lblSach);
            grpThongTinChiTiet.Controls.Add(cboSach);
            grpThongTinChiTiet.Controls.Add(lblSoLuongBan);
            grpThongTinChiTiet.Controls.Add(txtSoLuongBan);
            grpThongTinChiTiet.Controls.Add(lblDonGiaHoanTra);
            grpThongTinChiTiet.Controls.Add(numDonGiaHoanTra);
            grpThongTinChiTiet.Controls.Add(lblSoLuongTra);
            grpThongTinChiTiet.Controls.Add(numSoLuongTra);
            grpThongTinChiTiet.Controls.Add(btnThemSach);
            grpThongTinChiTiet.Controls.Add(btnXoaSach);
            grpThongTinChiTiet.CustomBorderColor = Color.FromArgb(43, 43, 64);
            grpThongTinChiTiet.CustomizableEdges = customizableEdges7;
            grpThongTinChiTiet.FillColor = Color.FromArgb(30, 30, 45);
            grpThongTinChiTiet.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpThongTinChiTiet.ForeColor = Color.White;
            grpThongTinChiTiet.Location = new Point(11, 196);
            grpThongTinChiTiet.Name = "grpThongTinChiTiet";
            grpThongTinChiTiet.Padding = new Padding(5, 45, 5, 5);
            grpThongTinChiTiet.ShadowDecoration.CustomizableEdges = customizableEdges8;
            grpThongTinChiTiet.Size = new Size(1008, 95);
            grpThongTinChiTiet.TabIndex = 1;
            grpThongTinChiTiet.Text = "THÔNG TIN CHI TIẾT HOÀN TRẢ";
            // 
            // lblSach
            // 
            lblSach.AutoSize = true;
            lblSach.ForeColor = Color.FromArgb(161, 165, 183);
            lblSach.Location = new Point(8, 51);
            lblSach.Name = "lblSach";
            lblSach.Size = new Size(52, 23);
            lblSach.TabIndex = 0;
            lblSach.Text = "Sách:";
            // 
            // cboSach
            // 
            cboSach.BackColor = Color.FromArgb(26, 26, 39);
            cboSach.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSach.FlatStyle = FlatStyle.Flat;
            cboSach.ForeColor = Color.White;
            cboSach.Location = new Point(66, 48);
            cboSach.Name = "cboSach";
            cboSach.Size = new Size(305, 31);
            cboSach.TabIndex = 1;
            cboSach.SelectionChangeCommitted += cboSach_SelectionChangeCommitted;
            // 
            // lblSoLuongBan
            // 
            lblSoLuongBan.AutoSize = true;
            lblSoLuongBan.ForeColor = Color.FromArgb(161, 165, 183);
            lblSoLuongBan.Location = new Point(377, 48);
            lblSoLuongBan.Name = "lblSoLuongBan";
            lblSoLuongBan.Size = new Size(69, 23);
            lblSoLuongBan.TabIndex = 2;
            lblSoLuongBan.Text = "SL bán:";
            // 
            // txtSoLuongBan
            // 
            txtSoLuongBan.BackColor = Color.FromArgb(26, 26, 39);
            txtSoLuongBan.BorderStyle = BorderStyle.FixedSingle;
            txtSoLuongBan.ForeColor = Color.White;
            txtSoLuongBan.Location = new Point(452, 45);
            txtSoLuongBan.Name = "txtSoLuongBan";
            txtSoLuongBan.ReadOnly = true;
            txtSoLuongBan.Size = new Size(74, 30);
            txtSoLuongBan.TabIndex = 3;
            // 
            // lblDonGiaHoanTra
            // 
            lblDonGiaHoanTra.AutoSize = true;
            lblDonGiaHoanTra.ForeColor = Color.FromArgb(161, 165, 183);
            lblDonGiaHoanTra.Location = new Point(532, 47);
            lblDonGiaHoanTra.Name = "lblDonGiaHoanTra";
            lblDonGiaHoanTra.Size = new Size(79, 23);
            lblDonGiaHoanTra.TabIndex = 4;
            lblDonGiaHoanTra.Text = "Đơn giá:";
            // 
            // numDonGiaHoanTra
            // 
            numDonGiaHoanTra.BackColor = Color.FromArgb(26, 26, 39);
            numDonGiaHoanTra.ForeColor = Color.White;
            numDonGiaHoanTra.Location = new Point(617, 44);
            numDonGiaHoanTra.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGiaHoanTra.Name = "numDonGiaHoanTra";
            numDonGiaHoanTra.Size = new Size(106, 30);
            numDonGiaHoanTra.TabIndex = 5;
            numDonGiaHoanTra.ThousandsSeparator = true;
            // 
            // lblSoLuongTra
            // 
            lblSoLuongTra.AutoSize = true;
            lblSoLuongTra.ForeColor = Color.FromArgb(161, 165, 183);
            lblSoLuongTra.Location = new Point(736, 47);
            lblSoLuongTra.Name = "lblSoLuongTra";
            lblSoLuongTra.Size = new Size(34, 23);
            lblSoLuongTra.TabIndex = 6;
            lblSoLuongTra.Text = "SL:";
            // 
            // numSoLuongTra
            // 
            numSoLuongTra.BackColor = Color.FromArgb(26, 26, 39);
            numSoLuongTra.ForeColor = Color.White;
            numSoLuongTra.Location = new Point(776, 44);
            numSoLuongTra.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numSoLuongTra.Name = "numSoLuongTra";
            numSoLuongTra.Size = new Size(74, 30);
            numSoLuongTra.TabIndex = 7;
            numSoLuongTra.ThousandsSeparator = true;
            // 
            // btnThemSach
            // 
            btnThemSach.Animated = true;
            btnThemSach.BorderRadius = 5;
            btnThemSach.CustomizableEdges = customizableEdges3;
            btnThemSach.FillColor = Color.FromArgb(16, 185, 129);
            btnThemSach.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThemSach.ForeColor = Color.White;
            btnThemSach.Location = new Point(848, 44);
            btnThemSach.Name = "btnThemSach";
            btnThemSach.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnThemSach.Size = new Size(89, 35);
            btnThemSach.TabIndex = 8;
            btnThemSach.Text = "Thêm";
            btnThemSach.Click += btnThemSach_Click;
            // 
            // btnXoaSach
            // 
            btnXoaSach.Animated = true;
            btnXoaSach.BorderRadius = 5;
            btnXoaSach.CustomizableEdges = customizableEdges5;
            btnXoaSach.FillColor = Color.FromArgb(246, 78, 96);
            btnXoaSach.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXoaSach.ForeColor = Color.White;
            btnXoaSach.Location = new Point(943, 44);
            btnXoaSach.Name = "btnXoaSach";
            btnXoaSach.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnXoaSach.Size = new Size(64, 35);
            btnXoaSach.TabIndex = 9;
            btnXoaSach.Text = "Xóa";
            btnXoaSach.Click += btnXoaSach_Click;
            // 
            // grpDanhSachChiTiet
            // 
            grpDanhSachChiTiet.BorderColor = Color.FromArgb(43, 43, 64);
            grpDanhSachChiTiet.BorderRadius = 8;
            grpDanhSachChiTiet.Controls.Add(dgvChiTiet);
            grpDanhSachChiTiet.CustomBorderColor = Color.FromArgb(43, 43, 64);
            grpDanhSachChiTiet.CustomizableEdges = customizableEdges9;
            grpDanhSachChiTiet.FillColor = Color.FromArgb(30, 30, 45);
            grpDanhSachChiTiet.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpDanhSachChiTiet.ForeColor = Color.White;
            grpDanhSachChiTiet.Location = new Point(11, 297);
            grpDanhSachChiTiet.Name = "grpDanhSachChiTiet";
            grpDanhSachChiTiet.Padding = new Padding(5, 45, 5, 5);
            grpDanhSachChiTiet.ShadowDecoration.CustomizableEdges = customizableEdges10;
            grpDanhSachChiTiet.Size = new Size(1008, 300);
            grpDanhSachChiTiet.TabIndex = 2;
            grpDanhSachChiTiet.Text = "DANH SÁCH CHI TIẾT HOÀN TRẢ";
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.AllowUserToAddRows = false;
            dgvChiTiet.AllowUserToDeleteRows = false;
            dgvChiTiet.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(26, 26, 39);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(63, 66, 84);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvChiTiet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvChiTiet.BackgroundColor = Color.FromArgb(30, 30, 45);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(54, 153, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(54, 153, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvChiTiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvChiTiet.ColumnHeadersHeight = 40;
            dgvChiTiet.Columns.AddRange(new DataGridViewColumn[] { ID, HoaDonChiTietID, HoaDonID, SachID, MaSach, TenSach, SoLuongBan, SoLuongTra, DonGiaHoanTra, ThanhTien });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(30, 30, 45);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(63, 66, 84);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvChiTiet.DefaultCellStyle = dataGridViewCellStyle7;
            dgvChiTiet.Dock = DockStyle.Fill;
            dgvChiTiet.GridColor = Color.FromArgb(43, 43, 64);
            dgvChiTiet.Location = new Point(5, 85);
            dgvChiTiet.MultiSelect = false;
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.ReadOnly = true;
            dgvChiTiet.RowHeadersVisible = false;
            dgvChiTiet.RowHeadersWidth = 51;
            dgvChiTiet.RowTemplate.Height = 40;
            dgvChiTiet.Size = new Size(998, 210);
            dgvChiTiet.TabIndex = 0;
            dgvChiTiet.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvChiTiet.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvChiTiet.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvChiTiet.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvChiTiet.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvChiTiet.ThemeStyle.BackColor = Color.FromArgb(30, 30, 45);
            dgvChiTiet.ThemeStyle.GridColor = Color.FromArgb(43, 43, 64);
            dgvChiTiet.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(54, 153, 255);
            dgvChiTiet.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvChiTiet.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvChiTiet.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvChiTiet.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvChiTiet.ThemeStyle.HeaderStyle.Height = 40;
            dgvChiTiet.ThemeStyle.ReadOnly = true;
            dgvChiTiet.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(30, 30, 45);
            dgvChiTiet.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvChiTiet.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvChiTiet.ThemeStyle.RowsStyle.ForeColor = Color.White;
            dgvChiTiet.ThemeStyle.RowsStyle.Height = 40;
            dgvChiTiet.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(63, 66, 84);
            dgvChiTiet.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            dgvChiTiet.CellClick += dgvChiTiet_CellClick;
            dgvChiTiet.DataError += dgvChiTiet_DataError;
            dgvChiTiet.SelectionChanged += dgvChiTiet_SelectionChanged;
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
            // HoaDonChiTietID
            // 
            HoaDonChiTietID.DataPropertyName = "HoaDonChiTietID";
            HoaDonChiTietID.HeaderText = "HoaDonChiTietID";
            HoaDonChiTietID.MinimumWidth = 6;
            HoaDonChiTietID.Name = "HoaDonChiTietID";
            HoaDonChiTietID.ReadOnly = true;
            HoaDonChiTietID.Visible = false;
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
            // SachID
            // 
            SachID.DataPropertyName = "SachID";
            SachID.HeaderText = "SachID";
            SachID.MinimumWidth = 6;
            SachID.Name = "SachID";
            SachID.ReadOnly = true;
            SachID.Visible = false;
            // 
            // MaSach
            // 
            MaSach.DataPropertyName = "MaSach";
            MaSach.HeaderText = "Mã sách";
            MaSach.MinimumWidth = 6;
            MaSach.Name = "MaSach";
            MaSach.ReadOnly = true;
            // 
            // TenSach
            // 
            TenSach.DataPropertyName = "TenSach";
            TenSach.HeaderText = "Tên sách";
            TenSach.MinimumWidth = 6;
            TenSach.Name = "TenSach";
            TenSach.ReadOnly = true;
            // 
            // SoLuongBan
            // 
            SoLuongBan.DataPropertyName = "SoLuongBan";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SoLuongBan.DefaultCellStyle = dataGridViewCellStyle3;
            SoLuongBan.HeaderText = "SL bán";
            SoLuongBan.MinimumWidth = 6;
            SoLuongBan.Name = "SoLuongBan";
            SoLuongBan.ReadOnly = true;
            // 
            // SoLuongTra
            // 
            SoLuongTra.DataPropertyName = "SoLuongTra";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SoLuongTra.DefaultCellStyle = dataGridViewCellStyle4;
            SoLuongTra.HeaderText = "SL hoàn";
            SoLuongTra.MinimumWidth = 6;
            SoLuongTra.Name = "SoLuongTra";
            SoLuongTra.ReadOnly = true;
            // 
            // DonGiaHoanTra
            // 
            DonGiaHoanTra.DataPropertyName = "DonGiaHoanTra";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            DonGiaHoanTra.DefaultCellStyle = dataGridViewCellStyle5;
            DonGiaHoanTra.HeaderText = "Đơn giá";
            DonGiaHoanTra.MinimumWidth = 6;
            DonGiaHoanTra.Name = "DonGiaHoanTra";
            DonGiaHoanTra.ReadOnly = true;
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle6.Format = "N0";
            ThanhTien.DefaultCellStyle = dataGridViewCellStyle6;
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 6;
            ThanhTien.Name = "ThanhTien";
            ThanhTien.ReadOnly = true;
            // 
            // btnLuuPhieuHoanTra
            // 
            btnLuuPhieuHoanTra.Animated = true;
            btnLuuPhieuHoanTra.BorderRadius = 5;
            btnLuuPhieuHoanTra.CustomizableEdges = customizableEdges11;
            btnLuuPhieuHoanTra.FillColor = Color.FromArgb(16, 185, 129);
            btnLuuPhieuHoanTra.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLuuPhieuHoanTra.ForeColor = Color.White;
            btnLuuPhieuHoanTra.Location = new Point(694, 611);
            btnLuuPhieuHoanTra.Name = "btnLuuPhieuHoanTra";
            btnLuuPhieuHoanTra.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnLuuPhieuHoanTra.Size = new Size(156, 38);
            btnLuuPhieuHoanTra.TabIndex = 2;
            btnLuuPhieuHoanTra.Text = "Lưu phiếu hoàn trả";
            btnLuuPhieuHoanTra.Click += btnLuuPhieuHoanTra_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Animated = true;
            btnHuyBo.BorderRadius = 5;
            btnHuyBo.CustomizableEdges = customizableEdges13;
            btnHuyBo.FillColor = Color.FromArgb(114, 57, 234);
            btnHuyBo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHuyBo.ForeColor = Color.White;
            btnHuyBo.Location = new Point(859, 611);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnHuyBo.Size = new Size(69, 38);
            btnHuyBo.TabIndex = 1;
            btnHuyBo.Text = "Hủy";
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnThoat
            // 
            btnThoat.Animated = true;
            btnThoat.BorderRadius = 5;
            btnThoat.CustomizableEdges = customizableEdges15;
            btnThoat.FillColor = Color.FromArgb(63, 66, 84);
            btnThoat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(936, 611);
            btnThoat.Name = "btnThoat";
            btnThoat.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnThoat.Size = new Size(83, 38);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "Đóng";
            btnThoat.Click += btnThoat_Click;
            // 
            // dragControl
            // 
            dragControl.DockIndicatorTransparencyValue = 0.6D;
            dragControl.TargetControl = grpThongTinPhieu;
            dragControl.UseTransparentDrag = true;
            // 
            // frmPhieuHoanTra_ChiTiet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 39);
            ClientSize = new Size(1030, 662);
            Controls.Add(btnThoat);
            Controls.Add(btnHuyBo);
            Controls.Add(btnLuuPhieuHoanTra);
            Controls.Add(grpDanhSachChiTiet);
            Controls.Add(grpThongTinChiTiet);
            Controls.Add(grpThongTinPhieu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPhieuHoanTra_ChiTiet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phiếu hoàn trả";
            Load += frmPhieuHoanTra_ChiTiet_Load;
            grpThongTinPhieu.ResumeLayout(false);
            grpThongTinPhieu.PerformLayout();
            grpThongTinChiTiet.ResumeLayout(false);
            grpThongTinChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGiaHoanTra).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongTra).EndInit();
            grpDanhSachChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            ResumeLayout(false);
        }
    }
}


