﻿
namespace LibraryInformationSystem.ReportForm
{
    partial class frmRprReaderCard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptPhieuThongTinDocGia5 = new LibraryInformationSystem.rptPhieuThongTinDocGia();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = "C:\\Users\\Admin\\source\\repos\\LibraryInformationSystem1\\LibraryInformationSystem\\rp" +
    "tPhieuThongTinDocGia.rpt";
            this.crystalReportViewer1.Size = new System.Drawing.Size(996, 682);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // frmRprReaderCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 682);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "frmRprReaderCard";
            this.Text = "frmRprReaderCard";
            this.ResumeLayout(false);

        }

        #endregion

        private rptPhieuThongTinDocGia rptPhieuThongTinDocGia1;
        private rptPhieuThongTinDocGia rptPhieuThongTinDocGia2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private rptPhieuThongTinDocGia rptPhieuThongTinDocGia3;
        private rptPhieuThongTinDocGia rptPhieuThongTinDocGia4;
        private rptPhieuThongTinDocGia rptPhieuThongTinDocGia5;
    }
}