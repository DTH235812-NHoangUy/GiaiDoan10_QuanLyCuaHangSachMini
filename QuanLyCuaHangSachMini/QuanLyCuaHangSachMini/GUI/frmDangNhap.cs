using QuanLyCuaHangSachMini.Data;
using QuanLyCuaHangSachMini.Data.Entity;
using QuanLyCuaHangSachMini.Helpers;
using System.Windows.Forms;
using System;
using System.Linq;

namespace QuanLyCuaHangSachMini.GUI
{
    public partial class frmDangNhap : Form
    {
        private readonly AppDbContext context = new AppDbContext();

        public frmDangNhap()
        {
            InitializeComponent();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            context.Dispose();
            base.OnFormClosed(e);
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Focus();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDangNhap.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
                return;
            }

            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text;

            var nv = context.NhanVien.FirstOrDefault(r => r.TenDangNhap == tenDangNhap && r.MatKhau == matKhau);

            if (nv == null)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.SelectAll();
                txtMatKhau.Focus();
                return;
            }

            if (!nv.KichHoat)
            {
                MessageBox.Show("Tài khoản này đã bị khóa hoặc ngừng hoạt động.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lưu phiên đăng nhập
            SessionHelper.GanDuLieu(nv);
            NhatKyHelper.GhiLog("Đăng nhập", "Hệ thống", nv.ID.ToString(), "Đăng nhập vào hệ thống");

            // CHUYỂN QUA FORM MAIN
            frmMain frm = new frmMain();
            this.Hide(); // Ẩn form đăng nhập
            frm.ShowDialog(); // Hiện form Main
            this.Close(); // Khi form Main đóng thì tắt app luôn
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Bấm hủy bỏ là thoát luôn app
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }
    }
}