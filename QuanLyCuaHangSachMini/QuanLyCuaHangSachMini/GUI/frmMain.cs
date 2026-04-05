using QuanLyCuaHangSachMini.Helpers;
using System.Diagnostics;
using System.Windows.Forms;
using System;

namespace QuanLyCuaHangSachMini.GUI
{
    public partial class frmMain : Form
    {
        private Form? currentChildForm = null;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Vì đã đăng nhập từ form trước mới vào được đây, nên ta chỉ cần phân quyền hiển thị
            lblTrangThai.Text = $"Xin chào: {SessionHelper.HoVaTen} - Quyền: {SessionHelper.QuyenHan}";

            if (SessionHelper.LaQuanTri)
                QuyenAdmin();
            else
                QuyenNhanVien();
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnContainer.Controls.Add(childForm);
            pnContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void QuyenAdmin()
        {
            // Admin thấy hết menu
            mnuLoaiSach.Visible = true;
            mnuNhaXuatBan.Visible = true;
            mnuNhaCungCap.Visible = true;
            mnuSach.Visible = true;
            mnuKhachHang.Visible = true;
            mnuNhanVien.Visible = true;
            mnuPhieuNhap.Visible = true;
            mnuHoaDon.Visible = true;
            mnuThongKeSach.Visible = true;
            mnuThongKeDoanhThu.Visible = true;
            mnuNhatKyHeThong.Visible = true;
        }

        public void QuyenNhanVien()
        {
            // Nhân viên bị ẩn bớt menu
            mnuLoaiSach.Visible = false;
            mnuNhaXuatBan.Visible = false;
            mnuNhaCungCap.Visible = false;
            mnuSach.Visible = false;
            mnuNhanVien.Visible = false;
            mnuPhieuNhap.Visible = false;
            mnuThongKeSach.Visible = false;
            mnuThongKeDoanhThu.Visible = false;
            mnuNhatKyHeThong.Visible = false;

            mnuKhachHang.Visible = true;
            mnuHoaDon.Visible = true;
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NhatKyHelper.GhiLog("Đăng xuất", "Hệ thống", SessionHelper.NhanVienID.ToString(), "Đăng xuất");
                SessionHelper.DangXuat();
                Application.Restart(); // Khởi động lại app -> Tự động bật form Đăng Nhập
            }
        }

        private void mnuLoaiSach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTheLoai());
        }
        private void mnuNhaXuatBan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhaXuatBan());
        }
        private void mnuNhaCungCap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhaCungCap());
        }
        private void mnuSach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSach());
        }
        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKhachHang(SessionHelper.QuyenHan));
        }
        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhanVien());
        }
        private void mnuPhieuNhap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmPhieuNhap(SessionHelper.NhanVienID, SessionHelper.QuyenHan));
        }
        private void mnuHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHoaDon(SessionHelper.NhanVienID, SessionHelper.QuyenHan, SessionHelper.HoVaTen));
        }
        private void mnuThongKeSach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKeSach());
        }
        private void mnuThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKeDoanhThu());
        }
        private void mnuNhatKyHeThong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhatKyHeThong());
        }
        private void lblLienKet_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = "https://fit.agu.edu.vn", UseShellExecute = true });
        }
        }
    }