namespace QuanLyCuaHangSachMini.GUI
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnSidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.mnuNhatKyHeThong = new Guna.UI2.WinForms.Guna2Button();
            this.mnuThongKeDoanhThu = new Guna.UI2.WinForms.Guna2Button();
            this.mnuThongKeSach = new Guna.UI2.WinForms.Guna2Button();
            this.mnuHoaDon = new Guna.UI2.WinForms.Guna2Button();
            this.mnuPhieuNhap = new Guna.UI2.WinForms.Guna2Button();
            this.mnuNhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.mnuKhachHang = new Guna.UI2.WinForms.Guna2Button();
            this.mnuSach = new Guna.UI2.WinForms.Guna2Button();
            this.mnuNhaCungCap = new Guna.UI2.WinForms.Guna2Button();
            this.mnuNhaXuatBan = new Guna.UI2.WinForms.Guna2Button();
            this.mnuLoaiSach = new Guna.UI2.WinForms.Guna2Button();
            this.mnuDangXuat = new Guna.UI2.WinForms.Guna2Button();
            this.pnLogo = new Guna.UI2.WinForms.Guna2Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblLienKet = new System.Windows.Forms.LinkLabel();
            this.pnHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMaximize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnContainer = new System.Windows.Forms.Panel();
            this.dragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnSidebar.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.pnLogo.SuspendLayout();
            this.pnHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSidebar
            // 
            this.pnSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnSidebar.Controls.Add(this.pnMenu);
            this.pnSidebar.Controls.Add(this.pnLogo);
            this.pnSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnSidebar.Name = "pnSidebar";
            this.pnSidebar.Size = new System.Drawing.Size(260, 750);
            this.pnSidebar.TabIndex = 0;
            // 
            // pnMenu
            // 
            this.pnMenu.AutoScroll = true;
            this.pnMenu.Controls.Add(this.mnuNhatKyHeThong);
            this.pnMenu.Controls.Add(this.mnuThongKeDoanhThu);
            this.pnMenu.Controls.Add(this.mnuThongKeSach);
            this.pnMenu.Controls.Add(this.mnuHoaDon);
            this.pnMenu.Controls.Add(this.mnuPhieuNhap);
            this.pnMenu.Controls.Add(this.mnuNhanVien);
            this.pnMenu.Controls.Add(this.mnuKhachHang);
            this.pnMenu.Controls.Add(this.mnuSach);
            this.pnMenu.Controls.Add(this.mnuNhaCungCap);
            this.pnMenu.Controls.Add(this.mnuNhaXuatBan);
            this.pnMenu.Controls.Add(this.mnuLoaiSach);
            this.pnMenu.Controls.Add(this.mnuDangXuat);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMenu.Location = new System.Drawing.Point(0, 100);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(260, 650);
            this.pnMenu.TabIndex = 1;
            // 
            // mnuNhatKyHeThong
            // 
            this.mnuNhatKyHeThong.Animated = true;
            this.mnuNhatKyHeThong.Dock = System.Windows.Forms.DockStyle.Top;
            this.mnuNhatKyHeThong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.mnuNhatKyHeThong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnuNhatKyHeThong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(165)))), ((int)(((byte)(183)))));
            this.mnuNhatKyHeThong.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.mnuNhatKyHeThong.HoverState.ForeColor = System.Drawing.Color.White;
            this.mnuNhatKyHeThong.Height = 45;
            this.mnuNhatKyHeThong.Name = "mnuNhatKyHeThong";
            this.mnuNhatKyHeThong.Text = "  Nhật ký hệ thống";
            this.mnuNhatKyHeThong.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mnuNhatKyHeThong.TextOffset = new System.Drawing.Point(30, 0);
            this.mnuNhatKyHeThong.Click += new System.EventHandler(this.mnuNhatKyHeThong_Click);
            // 
            // mnuThongKeDoanhThu
            // 
            this.mnuThongKeDoanhThu.Animated = true;
            this.mnuThongKeDoanhThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.mnuThongKeDoanhThu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.mnuThongKeDoanhThu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnuThongKeDoanhThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(165)))), ((int)(((byte)(183)))));
            this.mnuThongKeDoanhThu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.mnuThongKeDoanhThu.HoverState.ForeColor = System.Drawing.Color.White;
            this.mnuThongKeDoanhThu.Height = 45;
            this.mnuThongKeDoanhThu.Name = "mnuThongKeDoanhThu";
            this.mnuThongKeDoanhThu.Text = "  Thống kê doanh thu";
            this.mnuThongKeDoanhThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mnuThongKeDoanhThu.TextOffset = new System.Drawing.Point(30, 0);
            this.mnuThongKeDoanhThu.Click += new System.EventHandler(this.mnuThongKeDoanhThu_Click);
            // 
            // mnuThongKeSach
            // 
            this.mnuThongKeSach.Animated = true;
            this.mnuThongKeSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.mnuThongKeSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.mnuThongKeSach.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnuThongKeSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(165)))), ((int)(((byte)(183)))));
            this.mnuThongKeSach.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.mnuThongKeSach.HoverState.ForeColor = System.Drawing.Color.White;
            this.mnuThongKeSach.Height = 45;
            this.mnuThongKeSach.Name = "mnuThongKeSach";
            this.mnuThongKeSach.Text = "  Thống kê sách";
            this.mnuThongKeSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mnuThongKeSach.TextOffset = new System.Drawing.Point(30, 0);
            this.mnuThongKeSach.Click += new System.EventHandler(this.mnuThongKeSach_Click);
            // 
            // mnuHoaDon
            // 
            this.mnuHoaDon.Animated = true;
            this.mnuHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.mnuHoaDon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.mnuHoaDon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnuHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(165)))), ((int)(((byte)(183)))));
            this.mnuHoaDon.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.mnuHoaDon.HoverState.ForeColor = System.Drawing.Color.White;
            this.mnuHoaDon.Height = 45;
            this.mnuHoaDon.Name = "mnuHoaDon";
            this.mnuHoaDon.Text = "  • Hóa đơn bán";
            this.mnuHoaDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mnuHoaDon.TextOffset = new System.Drawing.Point(30, 0);
            this.mnuHoaDon.Click += new System.EventHandler(this.mnuHoaDon_Click);
            // 
            // mnuPhieuNhap
            // 
            this.mnuPhieuNhap.Animated = true;
            this.mnuPhieuNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.mnuPhieuNhap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.mnuPhieuNhap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnuPhieuNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(165)))), ((int)(((byte)(183)))));
            this.mnuPhieuNhap.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.mnuPhieuNhap.HoverState.ForeColor = System.Drawing.Color.White;
            this.mnuPhieuNhap.Height = 45;
            this.mnuPhieuNhap.Name = "mnuPhieuNhap";
            this.mnuPhieuNhap.Text = "  • Phiếu nhập";
            this.mnuPhieuNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mnuPhieuNhap.TextOffset = new System.Drawing.Point(30, 0);
            this.mnuPhieuNhap.Click += new System.EventHandler(this.mnuPhieuNhap_Click);
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.Animated = true;
            this.mnuNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.mnuNhanVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.mnuNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnuNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(165)))), ((int)(((byte)(183)))));
            this.mnuNhanVien.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.mnuNhanVien.HoverState.ForeColor = System.Drawing.Color.White;
            this.mnuNhanVien.Height = 45;
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Text = "  • Nhân viên";
            this.mnuNhanVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mnuNhanVien.TextOffset = new System.Drawing.Point(30, 0);
            this.mnuNhanVien.Click += new System.EventHandler(this.mnuNhanVien_Click);
            // 
            // mnuKhachHang
            // 
            this.mnuKhachHang.Animated = true;
            this.mnuKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.mnuKhachHang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.mnuKhachHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnuKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(165)))), ((int)(((byte)(183)))));
            this.mnuKhachHang.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.mnuKhachHang.HoverState.ForeColor = System.Drawing.Color.White;
            this.mnuKhachHang.Height = 45;
            this.mnuKhachHang.Name = "mnuKhachHang";
            this.mnuKhachHang.Text = "  • Khách hàng";
            this.mnuKhachHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mnuKhachHang.TextOffset = new System.Drawing.Point(30, 0);
            this.mnuKhachHang.Click += new System.EventHandler(this.mnuKhachHang_Click);
            // 
            // mnuSach
            // 
            this.mnuSach.Animated = true;
            this.mnuSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.mnuSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.mnuSach.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnuSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(165)))), ((int)(((byte)(183)))));
            this.mnuSach.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.mnuSach.HoverState.ForeColor = System.Drawing.Color.White;
            this.mnuSach.Height = 45;
            this.mnuSach.Name = "mnuSach";
            this.mnuSach.Text = "  • Quản lý Sách";
            this.mnuSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mnuSach.TextOffset = new System.Drawing.Point(30, 0);
            this.mnuSach.Click += new System.EventHandler(this.mnuSach_Click);
            // 
            // mnuNhaCungCap
            // 
            this.mnuNhaCungCap.Animated = true;
            this.mnuNhaCungCap.Dock = System.Windows.Forms.DockStyle.Top;
            this.mnuNhaCungCap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.mnuNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnuNhaCungCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(165)))), ((int)(((byte)(183)))));
            this.mnuNhaCungCap.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.mnuNhaCungCap.HoverState.ForeColor = System.Drawing.Color.White;
            this.mnuNhaCungCap.Height = 45;
            this.mnuNhaCungCap.Name = "mnuNhaCungCap";
            this.mnuNhaCungCap.Text = "  • Nhà cung cấp";
            this.mnuNhaCungCap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mnuNhaCungCap.TextOffset = new System.Drawing.Point(30, 0);
            this.mnuNhaCungCap.Click += new System.EventHandler(this.mnuNhaCungCap_Click);
            // 
            // mnuNhaXuatBan
            // 
            this.mnuNhaXuatBan.Animated = true;
            this.mnuNhaXuatBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.mnuNhaXuatBan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.mnuNhaXuatBan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnuNhaXuatBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(165)))), ((int)(((byte)(183)))));
            this.mnuNhaXuatBan.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.mnuNhaXuatBan.HoverState.ForeColor = System.Drawing.Color.White;
            this.mnuNhaXuatBan.Height = 45;
            this.mnuNhaXuatBan.Name = "mnuNhaXuatBan";
            this.mnuNhaXuatBan.Text = "  • Nhà xuất bản";
            this.mnuNhaXuatBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mnuNhaXuatBan.TextOffset = new System.Drawing.Point(30, 0);
            this.mnuNhaXuatBan.Click += new System.EventHandler(this.mnuNhaXuatBan_Click);
            // 
            // mnuLoaiSach
            // 
            this.mnuLoaiSach.Animated = true;
            this.mnuLoaiSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.mnuLoaiSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.mnuLoaiSach.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnuLoaiSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(165)))), ((int)(((byte)(183)))));
            this.mnuLoaiSach.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.mnuLoaiSach.HoverState.ForeColor = System.Drawing.Color.White;
            this.mnuLoaiSach.Height = 45;
            this.mnuLoaiSach.Name = "mnuLoaiSach";
            this.mnuLoaiSach.Text = "  • Thể loại sách";
            this.mnuLoaiSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mnuLoaiSach.TextOffset = new System.Drawing.Point(30, 0);
            this.mnuLoaiSach.Click += new System.EventHandler(this.mnuLoaiSach_Click);
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Animated = true;
            this.mnuDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mnuDangXuat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.mnuDangXuat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.mnuDangXuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(34)))));
            this.mnuDangXuat.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(34)))));
            this.mnuDangXuat.HoverState.ForeColor = System.Drawing.Color.White;
            this.mnuDangXuat.Height = 45;
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Text = "Đăng xuất tài khoản";
            this.mnuDangXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mnuDangXuat.TextOffset = new System.Drawing.Point(30, 0);
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // 
            // pnLogo
            // 
            this.pnLogo.Controls.Add(this.lblLogo);
            this.pnLogo.Controls.Add(this.lblLienKet);
            this.pnLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLogo.Location = new System.Drawing.Point(0, 0);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(260, 100);
            this.pnLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblLogo.Location = new System.Drawing.Point(0, 20);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(260, 40);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "BOOKSTORE";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLienKet
            // 
            this.lblLienKet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLienKet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(165)))), ((int)(((byte)(183)))));
            this.lblLienKet.Location = new System.Drawing.Point(0, 60);
            this.lblLienKet.Name = "lblLienKet";
            this.lblLienKet.Size = new System.Drawing.Size(260, 20);
            this.lblLienKet.TabIndex = 1;
            this.lblLienKet.Text = "FIT AGU";
            this.lblLienKet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLienKet.Click += new System.EventHandler(this.lblLienKet_Click);
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.pnHeader.Controls.Add(this.lblTrangThai);
            this.pnHeader.Controls.Add(this.btnMinimize);
            this.pnHeader.Controls.Add(this.btnMaximize);
            this.pnHeader.Controls.Add(this.btnClose);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(260, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1020, 50);
            this.pnHeader.TabIndex = 1;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblTrangThai.Location = new System.Drawing.Point(20, 10);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(500, 30);
            this.lblTrangThai.TabIndex = 0;
            this.lblTrangThai.Text = "Đang tải dữ liệu...";
            // 
            // btnMinimize
            // 
            this.btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(885, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(45, 50);
            this.btnMinimize.TabIndex = 1;
            // 
            // btnMaximize
            // 
            this.btnMaximize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FillColor = System.Drawing.Color.Transparent;
            this.btnMaximize.IconColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(930, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(45, 50);
            this.btnMaximize.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(975, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 50);
            this.btnClose.TabIndex = 3;
            // 
            // pnContainer
            // 
            this.pnContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(260, 50);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Padding = new System.Windows.Forms.Padding(10);
            this.pnContainer.Size = new System.Drawing.Size(1020, 700);
            this.pnContainer.TabIndex = 2;
            // 
            // dragControl
            // 
            this.dragControl.TargetControl = this.pnHeader;
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(1280, 750);
            this.Controls.Add(this.pnContainer);
            this.Controls.Add(this.pnHeader);
            this.Controls.Add(this.pnSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý cửa hàng sách mini";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnSidebar.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            this.pnLogo.ResumeLayout(false);
            this.pnHeader.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnSidebar;
        private Guna.UI2.WinForms.Guna2Panel pnLogo;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.LinkLabel lblLienKet;
        private Guna.UI2.WinForms.Guna2Button mnuDangXuat;
        private Guna.UI2.WinForms.Guna2Button mnuLoaiSach;
        private Guna.UI2.WinForms.Guna2Button mnuNhaXuatBan;
        private Guna.UI2.WinForms.Guna2Button mnuNhaCungCap;
        private Guna.UI2.WinForms.Guna2Button mnuSach;
        private Guna.UI2.WinForms.Guna2Button mnuKhachHang;
        private Guna.UI2.WinForms.Guna2Button mnuNhanVien;
        private Guna.UI2.WinForms.Guna2Button mnuPhieuNhap;
        private Guna.UI2.WinForms.Guna2Button mnuHoaDon;
        private Guna.UI2.WinForms.Guna2Button mnuThongKeSach;
        private Guna.UI2.WinForms.Guna2Button mnuThongKeDoanhThu;
        private Guna.UI2.WinForms.Guna2Button mnuNhatKyHeThong;
        private Guna.UI2.WinForms.Guna2Panel pnHeader;
        private System.Windows.Forms.Label lblTrangThai;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2ControlBox btnMaximize;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimize;
        private System.Windows.Forms.Panel pnContainer;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;
    }
}