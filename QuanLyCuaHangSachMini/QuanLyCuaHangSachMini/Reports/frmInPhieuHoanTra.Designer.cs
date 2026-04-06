namespace QuanLyCuaHangSachMini.Reports
{
    partial class frmInPhieuHoanTra
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2GroupBox grpNoiDung;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();

            grpNoiDung = new Guna.UI2.WinForms.Guna2GroupBox();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();

            grpNoiDung.SuspendLayout();
            SuspendLayout();
            // 
            // grpNoiDung
            // 
            grpNoiDung.BorderColor = Color.FromArgb(43, 43, 64);
            grpNoiDung.BorderRadius = 8;
            grpNoiDung.CustomBorderColor = Color.FromArgb(43, 43, 64);
            grpNoiDung.CustomizableEdges = customizableEdges1;
            grpNoiDung.FillColor = Color.FromArgb(30, 30, 45);
            grpNoiDung.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpNoiDung.ForeColor = Color.White;
            grpNoiDung.Location = new Point(12, 12);
            grpNoiDung.Name = "grpNoiDung";
            grpNoiDung.Padding = new Padding(5, 35, 5, 5);
            grpNoiDung.ShadowDecoration.CustomizableEdges = customizableEdges2;
            grpNoiDung.Size = new Size(976, 626);
            grpNoiDung.TabIndex = 0;
            grpNoiDung.Text = "IN PHIẾU HOÀN TRẢ";
            // 
            // reportViewer1
            // 
            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.Location = new Point(5, 45);
            reportViewer1.Name = "reportViewer1";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(966, 576);
            reportViewer1.TabIndex = 0;
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            // 
            // frmInPhieuHoanTra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 39);
            ClientSize = new Size(1000, 650);
            Controls.Add(grpNoiDung);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmInPhieuHoanTra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "In phiếu hoàn trả";
            Load += frmInPhieuHoanTra_Load;
            grpNoiDung.Controls.Add(reportViewer1);
            grpNoiDung.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
