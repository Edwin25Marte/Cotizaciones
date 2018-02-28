namespace Cotizaciones_Edwin_Marte.Reportes
{
    partial class ReporteArt
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
            this.ArtCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ArtCrystalReportViewer
            // 
            this.ArtCrystalReportViewer.ActiveViewIndex = -1;
            this.ArtCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ArtCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ArtCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArtCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.ArtCrystalReportViewer.Name = "ArtCrystalReportViewer";
            this.ArtCrystalReportViewer.Size = new System.Drawing.Size(384, 372);
            this.ArtCrystalReportViewer.TabIndex = 0;
            this.ArtCrystalReportViewer.Load += new System.EventHandler(this.ArtCrystalReportViewer_Load);
            // 
            // ReporteArt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 372);
            this.Controls.Add(this.ArtCrystalReportViewer);
            this.Name = "ReporteArt";
            this.Text = "Reporte de Articulos";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ArtCrystalReportViewer;
    }
}