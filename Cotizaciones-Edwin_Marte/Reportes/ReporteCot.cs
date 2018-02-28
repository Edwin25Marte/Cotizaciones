using Cotizaciones_Edwin_Marte.Entidades;
using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cotizaciones_Edwin_Marte.Reportes
{
    public partial class ReporteCot : Form
    {
        List<Cotizaciones> lista = new List<Cotizaciones>();
        public ReporteCot(List<Cotizaciones> list)
        {
            lista = list;
            InitializeComponent();
        }

        private void CotCrystalReportViewer_Load(object sender, EventArgs e)
        {
            ReportDocument rep = new ReportDocument();
            rep.Load("C:/Users/Edwin_Marte/Desktop/Cotizaciones-Edwin_Marte/Cotizaciones-Edwin_Marte/Reportes/cotReport.rpt");
            rep.SetDataSource(lista);

            CotCrystalReportViewer.ReportSource = rep;
            CotCrystalReportViewer.Refresh();
        }
    }
}
