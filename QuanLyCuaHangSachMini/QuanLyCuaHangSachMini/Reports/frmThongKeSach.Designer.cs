namespace QuanLyCuaHangSachMini.GUI
{
    partial class frmThongKeSach
    {
        private System.ComponentModel.IContainer components = null;
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();

            grpBaoCao = new Guna.UI2.WinForms.Guna2GroupBox();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();

            grpBaoCao.SuspendLayout();
            SuspendLayout();
            // 
            // grpBaoCao
            // 
            grpBaoCao.BorderColor = Color.FromArgb(43, 43, 64);
            grpBaoCao.BorderRadius = 8;
            grpBaoCao.Controls.Add(reportViewer1);
            grpBaoCao.CustomBorderColor = Color.FromArgb(43, 43, 64);
            grpBaoCao.CustomizableEdges = customizableEdges1;
            grpBaoCao.FillColor = Color.FromArgb(30, 30, 45);
            grpBaoCao.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpBaoCao.ForeColor = Color.White;
            grpBaoCao.Location = new Point(12, 12);
            grpBaoCao.Name = "grpBaoCao";
            grpBaoCao.Padding = new Padding(5, 35, 5, 5);
            grpBaoCao.ShadowDecoration.CustomizableEdges = customizableEdges2;
            grpBaoCao.Size = new Size(1176, 676);
            grpBaoCao.TabIndex = 0;
            grpBaoCao.Text = "BÁO CÁO THỐNG KÊ SÁCH";
            // 
            // reportViewer1
            // 
            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.Location = new Point(5, 45);
            reportViewer1.Name = "reportViewer1";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(1166, 626);
            reportViewer1.TabIndex = 0;
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            // 
            // frmThongKeSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 39);
            ClientSize = new Size(1200, 700);
            Controls.Add(grpBaoCao);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmThongKeSach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê sách";
            WindowState = FormWindowState.Maximized;
            Load += frmThongKeSach_Load;
            grpBaoCao.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
