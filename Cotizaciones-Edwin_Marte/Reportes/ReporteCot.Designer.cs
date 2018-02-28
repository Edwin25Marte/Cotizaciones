namespace Cotizaciones_Edwin_Marte.Reportes
{
    partial class ReporteCot
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
            this.CotCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CotCrystalReportViewer
            // 
            this.CotCrystalReportViewer.ActiveViewIndex = -1;
            this.CotCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CotCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.CotCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CotCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.CotCrystalReportViewer.Name = "CotCrystalReportViewer";
            this.CotCrystalReportViewer.Size = new System.Drawing.Size(384, 383);
            this.CotCrystalReportViewer.TabIndex = 0;
            this.CotCrystalReportViewer.Load += new System.EventHandler(this.CotCrystalReportViewer_Load);
            // 
            // ReporteCot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 383);
            this.Controls.Add(this.CotCrystalReportViewer);
            this.Name = "ReporteCot";
            this.Text = "Reporte Cotizaciones";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CotCrystalReportViewer;
    }
}