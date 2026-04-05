namespace QuanLyCuaHangSachMini.GUI
{
    partial class frmThongKeDoanhThu
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2GroupBox grpBocLoc;
        private Label lblTuNgay;
        private Label lblDenNgay;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTuNgay;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDenNgay;
        private Guna.UI2.WinForms.Guna2Button btnLocKetQua;
        private Guna.UI2.WinForms.Guna2Button btnHienTatCa;
        private Guna.UI2.WinForms.Guna2GroupBox grpBaoCao;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            grpBocLoc = new Guna.UI2.WinForms.Guna2GroupBox();
            lblTuNgay = new Label();
            dtpTuNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            lblDenNgay = new Label();
            dtpDenNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            btnLocKetQua = new Guna.UI2.WinForms.Guna2Button();
            btnHienTatCa = new Guna.UI2.WinForms.Guna2Button();
            grpBaoCao = new Guna.UI2.WinForms.Guna2GroupBox();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            grpBocLoc.SuspendLayout();
            grpBaoCao.SuspendLayout();
            SuspendLayout();
            // 
            // grpBocLoc
            // 
            grpBocLoc.BorderColor = Color.FromArgb(43, 43, 64);
            grpBocLoc.BorderRadius = 8;
            grpBocLoc.Controls.Add(lblTuNgay);
            grpBocLoc.Controls.Add(dtpTuNgay);
            grpBocLoc.Controls.Add(lblDenNgay);
            grpBocLoc.Controls.Add(dtpDenNgay);
            grpBocLoc.Controls.Add(btnLocKetQua);
            grpBocLoc.Controls.Add(btnHienTatCa);
            grpBocLoc.CustomBorderColor = Color.FromArgb(43, 43, 64);
            grpBocLoc.CustomizableEdges = customizableEdges9;
            grpBocLoc.FillColor = Color.FromArgb(30, 30, 45);
            grpBocLoc.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpBocLoc.ForeColor = Color.White;
            grpBocLoc.Location = new Point(12, 12);
            grpBocLoc.Name = "grpBocLoc";
            grpBocLoc.ShadowDecoration.CustomizableEdges = customizableEdges10;
            grpBocLoc.Size = new Size(1260, 92);
            grpBocLoc.TabIndex = 0;
            grpBocLoc.Text = "BỘ LỌC DOANH THU";
            // 
            // lblTuNgay
            // 
            lblTuNgay.AutoSize = true;
            lblTuNgay.BackColor = Color.Transparent;
            lblTuNgay.ForeColor = Color.FromArgb(161, 165, 183);
            lblTuNgay.Location = new Point(19, 55);
            lblTuNgay.Name = "lblTuNgay";
            lblTuNgay.Size = new Size(75, 23);
            lblTuNgay.TabIndex = 0;
            lblTuNgay.Text = "Từ ngày";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.BorderColor = Color.FromArgb(43, 43, 64);
            dtpTuNgay.BorderRadius = 5;
            dtpTuNgay.Checked = true;
            dtpTuNgay.CustomizableEdges = customizableEdges1;
            dtpTuNgay.FillColor = Color.FromArgb(26, 26, 39);
            dtpTuNgay.Font = new Font("Segoe UI", 9F);
            dtpTuNgay.ForeColor = Color.White;
            dtpTuNgay.Format = DateTimePickerFormat.Short;
            dtpTuNgay.Location = new Point(100, 55);
            dtpTuNgay.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpTuNgay.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.ShadowDecoration.CustomizableEdges = customizableEdges2;
            dtpTuNgay.Size = new Size(130, 30);
            dtpTuNgay.TabIndex = 1;
            dtpTuNgay.Value = new DateTime(2026, 4, 5, 17, 2, 15, 874);
            // 
            // lblDenNgay
            // 
            lblDenNgay.AutoSize = true;
            lblDenNgay.BackColor = Color.Transparent;
            lblDenNgay.ForeColor = Color.FromArgb(161, 165, 183);
            lblDenNgay.Location = new Point(236, 55);
            lblDenNgay.Name = "lblDenNgay";
            lblDenNgay.Size = new Size(86, 23);
            lblDenNgay.TabIndex = 2;
            lblDenNgay.Text = "Đến ngày";
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.BorderColor = Color.FromArgb(43, 43, 64);
            dtpDenNgay.BorderRadius = 5;
            dtpDenNgay.Checked = true;
            dtpDenNgay.CustomizableEdges = customizableEdges3;
            dtpDenNgay.FillColor = Color.FromArgb(26, 26, 39);
            dtpDenNgay.Font = new Font("Segoe UI", 9F);
            dtpDenNgay.ForeColor = Color.White;
            dtpDenNgay.Format = DateTimePickerFormat.Short;
            dtpDenNgay.Location = new Point(344, 55);
            dtpDenNgay.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpDenNgay.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dtpDenNgay.Size = new Size(130, 30);
            dtpDenNgay.TabIndex = 3;
            dtpDenNgay.Value = new DateTime(2026, 4, 5, 17, 2, 15, 944);
            // 
            // btnLocKetQua
            // 
            btnLocKetQua.Animated = true;
            btnLocKetQua.BorderRadius = 5;
            btnLocKetQua.CustomizableEdges = customizableEdges5;
            btnLocKetQua.FillColor = Color.FromArgb(114, 57, 234);
            btnLocKetQua.Font = new Font("Segoe UI", 9F);
            btnLocKetQua.ForeColor = Color.White;
            btnLocKetQua.Location = new Point(809, 43);
            btnLocKetQua.Name = "btnLocKetQua";
            btnLocKetQua.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnLocKetQua.Size = new Size(110, 35);
            btnLocKetQua.TabIndex = 4;
            btnLocKetQua.Text = "Lọc kết quả";
            btnLocKetQua.Click += btnLocKetQua_Click;
            // 
            // btnHienTatCa
            // 
            btnHienTatCa.Animated = true;
            btnHienTatCa.BorderRadius = 5;
            btnHienTatCa.CustomizableEdges = customizableEdges7;
            btnHienTatCa.FillColor = Color.FromArgb(27, 197, 189);
            btnHienTatCa.Font = new Font("Segoe UI", 9F);
            btnHienTatCa.ForeColor = Color.White;
            btnHienTatCa.Location = new Point(943, 43);
            btnHienTatCa.Name = "btnHienTatCa";
            btnHienTatCa.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnHienTatCa.Size = new Size(110, 35);
            btnHienTatCa.TabIndex = 5;
            btnHienTatCa.Text = "Hiện tất cả";
            btnHienTatCa.Click += btnHienTatCa_Click;
            // 
            // grpBaoCao
            // 
            grpBaoCao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpBaoCao.BorderColor = Color.FromArgb(43, 43, 64);
            grpBaoCao.BorderRadius = 8;
            grpBaoCao.Controls.Add(reportViewer1);
            grpBaoCao.CustomBorderColor = Color.FromArgb(43, 43, 64);
            grpBaoCao.CustomizableEdges = customizableEdges9;
            grpBaoCao.FillColor = Color.FromArgb(30, 30, 45);
            grpBaoCao.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpBaoCao.ForeColor = Color.White;
            grpBaoCao.Location = new Point(12, 110);
            grpBaoCao.Name = "grpBaoCao";
            grpBaoCao.Padding = new Padding(5, 35, 5, 5);
            grpBaoCao.ShadowDecoration.CustomizableEdges = customizableEdges10;
            grpBaoCao.Size = new Size(1260, 565);
            grpBaoCao.TabIndex = 1;
            grpBaoCao.Text = "BÁO CÁO DOANH THU";
            // 
            // reportViewer1
            // 
            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.Location = new Point(5, 75);
            reportViewer1.Name = "reportViewer1";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(1250, 485);
            reportViewer1.TabIndex = 0;
            // 
            // frmThongKeDoanhThu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 39);
            ClientSize = new Size(1284, 707);
            Controls.Add(grpBaoCao);
            Controls.Add(grpBocLoc);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmThongKeDoanhThu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê doanh thu";
            WindowState = FormWindowState.Maximized;
            Load += frmThongKeDoanhThu_Load;
            grpBocLoc.ResumeLayout(false);
            grpBocLoc.PerformLayout();
            grpBaoCao.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
