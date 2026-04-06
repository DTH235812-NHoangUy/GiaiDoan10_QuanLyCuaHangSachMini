namespace QuanLyCuaHangSachMini.GUI
{
    partial class frmDangNhap
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2Panel pnLoginLeft;
        private Guna.UI2.WinForms.Guna2Panel pnLoginRight;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblSubLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label lblMatKhau;
        private Guna.UI2.WinForms.Guna2TextBox txtTenDangNhap;
        private Guna.UI2.WinForms.Guna2TextBox txtMatKhau;
        private Guna.UI2.WinForms.Guna2Button btnDangNhap;
        private Guna.UI2.WinForms.Guna2Button btnHuyBo;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private System.Windows.Forms.Label lblHint;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnLoginLeft = new Guna.UI2.WinForms.Guna2Panel();
            lblSubLogo = new Label();
            lblLogo = new Label();
            pnLoginRight = new Guna.UI2.WinForms.Guna2Panel();
            lblHint = new Label();
            btnHuyBo = new Guna.UI2.WinForms.Guna2Button();
            btnDangNhap = new Guna.UI2.WinForms.Guna2Button();
            txtMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            txtTenDangNhap = new Guna.UI2.WinForms.Guna2TextBox();
            lblMatKhau = new Label();
            lblTenDangNhap = new Label();
            lblTitle = new Label();
            btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            pnLoginLeft.SuspendLayout();
            pnLoginRight.SuspendLayout();
            SuspendLayout();
            // 
            // pnLoginLeft
            // 
            pnLoginLeft.Controls.Add(lblSubLogo);
            pnLoginLeft.Controls.Add(lblLogo);
            pnLoginLeft.CustomizableEdges = customizableEdges1;
            pnLoginLeft.Dock = DockStyle.Left;
            pnLoginLeft.Location = new Point(0, 0);
            pnLoginLeft.Name = "pnLoginLeft";
            pnLoginLeft.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pnLoginLeft.Size = new Size(280, 520);
            pnLoginLeft.TabIndex = 0;
            // 
            // lblSubLogo
            // 
            lblSubLogo.Anchor = AnchorStyles.None;
            lblSubLogo.Font = new Font("Segoe UI", 10F);
            lblSubLogo.ForeColor = Color.Red;
            lblSubLogo.Location = new Point(0, 205);
            lblSubLogo.Name = "lblSubLogo";
            lblSubLogo.Size = new Size(280, 30);
            lblSubLogo.TabIndex = 1;
            lblSubLogo.Text = "Quản lý cửa hàng sách mini";
            lblSubLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLogo
            // 
            lblLogo.Anchor = AnchorStyles.None;
            lblLogo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblLogo.ForeColor = Color.FromArgb(54, 153, 255);
            lblLogo.Location = new Point(0, 160);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(280, 45);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "BOOKSTORE";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnLoginRight
            // 
            pnLoginRight.BackColor = Color.Black;
            pnLoginRight.Controls.Add(lblHint);
            pnLoginRight.Controls.Add(btnHuyBo);
            pnLoginRight.Controls.Add(btnDangNhap);
            pnLoginRight.Controls.Add(txtMatKhau);
            pnLoginRight.Controls.Add(txtTenDangNhap);
            pnLoginRight.Controls.Add(lblMatKhau);
            pnLoginRight.Controls.Add(lblTenDangNhap);
            pnLoginRight.Controls.Add(lblTitle);
            pnLoginRight.Controls.Add(btnClose);
            pnLoginRight.CustomizableEdges = customizableEdges11;
            pnLoginRight.Dock = DockStyle.Fill;
            pnLoginRight.Location = new Point(280, 0);
            pnLoginRight.Name = "pnLoginRight";
            pnLoginRight.ShadowDecoration.CustomizableEdges = customizableEdges12;
            pnLoginRight.Size = new Size(500, 520);
            pnLoginRight.TabIndex = 1;
            // 
            // lblHint
            // 
            lblHint.Font = new Font("Segoe UI", 9F);
            lblHint.ForeColor = Color.FromArgb(148, 163, 184);
            lblHint.Location = new Point(60, 465);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(380, 25);
            lblHint.TabIndex = 9;
            lblHint.Text = "Nhấn Enter để đăng nhập nhanh.";
            lblHint.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BorderRadius = 8;
            btnHuyBo.CustomizableEdges = customizableEdges3;
            btnHuyBo.FillColor = Color.FromArgb(239, 68, 68);
            btnHuyBo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnHuyBo.ForeColor = Color.White;
            btnHuyBo.Location = new Point(60, 410);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnHuyBo.Size = new Size(380, 44);
            btnHuyBo.TabIndex = 3;
            btnHuyBo.Text = "HỦY BỎ";
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BorderRadius = 8;
            btnDangNhap.CustomizableEdges = customizableEdges3;
            btnDangNhap.FillColor = Color.FromArgb(37, 99, 235);
            btnDangNhap.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Location = new Point(60, 355);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnDangNhap.Size = new Size(380, 44);
            btnDangNhap.TabIndex = 2;
            btnDangNhap.Text = "ĐĂNG NHẬP";
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderRadius = 8;
            txtMatKhau.Cursor = Cursors.IBeam;
            txtMatKhau.CustomizableEdges = customizableEdges5;
            txtMatKhau.DefaultText = "";
            txtMatKhau.FillColor = Color.FromArgb(31, 41, 55);
            txtMatKhau.Font = new Font("Segoe UI", 11F);
            txtMatKhau.ForeColor = Color.White;
            txtMatKhau.Location = new Point(60, 280);
            txtMatKhau.Margin = new Padding(4, 5, 4, 5);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '●';
            txtMatKhau.PlaceholderText = "";
            txtMatKhau.SelectedText = "";
            txtMatKhau.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtMatKhau.Size = new Size(380, 42);
            txtMatKhau.TabIndex = 1;
            txtMatKhau.KeyDown += txtMatKhau_KeyDown;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.BorderRadius = 8;
            txtTenDangNhap.Cursor = Cursors.IBeam;
            txtTenDangNhap.CustomizableEdges = customizableEdges7;
            txtTenDangNhap.DefaultText = "";
            txtTenDangNhap.FillColor = Color.FromArgb(31, 41, 55);
            txtTenDangNhap.Font = new Font("Segoe UI", 11F);
            txtTenDangNhap.ForeColor = Color.White;
            txtTenDangNhap.Location = new Point(60, 185);
            txtTenDangNhap.Margin = new Padding(4, 5, 4, 5);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.PlaceholderText = "";
            txtTenDangNhap.SelectedText = "";
            txtTenDangNhap.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtTenDangNhap.Size = new Size(380, 42);
            txtTenDangNhap.TabIndex = 0;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 11F);
            lblMatKhau.ForeColor = Color.FromArgb(203, 213, 225);
            lblMatKhau.Location = new Point(60, 250);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(91, 25);
            lblMatKhau.TabIndex = 4;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Segoe UI", 11F);
            lblTenDangNhap.ForeColor = Color.FromArgb(203, 213, 225);
            lblTenDangNhap.Location = new Point(60, 155);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(137, 25);
            lblTenDangNhap.TabIndex = 2;
            lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(60, 70);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(380, 45);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "ĐĂNG NHẬP";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.CustomizableEdges = customizableEdges9;
            btnClose.FillColor = Color.Transparent;
            btnClose.IconColor = Color.White;
            btnClose.Location = new Point(450, 10);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnClose.Size = new Size(40, 35);
            btnClose.TabIndex = 0;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 520);
            Controls.Add(pnLoginRight);
            Controls.Add(pnLoginLeft);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += frmDangNhap_Load;
            pnLoginLeft.ResumeLayout(false);
            pnLoginRight.ResumeLayout(false);
            pnLoginRight.PerformLayout();
            ResumeLayout(false);
        }
    }
}
