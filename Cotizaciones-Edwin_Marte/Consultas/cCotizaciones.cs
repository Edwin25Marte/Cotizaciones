using Cotizaciones_Edwin_Marte.BLL;
using Cotizaciones_Edwin_Marte.Entidades;
using Cotizaciones_Edwin_Marte.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cotizaciones_Edwin_Marte.Consultas
{
    public partial class cCotizaciones : Form
    {
        List<Cotizaciones> lista = new List<Cotizaciones>();

        public cCotizaciones()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if (FiltrarComboBox.SelectedIndex == 0)
            {
                int id = 0;
                int.TryParse(CriterioTextBox.Text, out id);

                lista = CotizacionesBLL.GetList(Cot => Cot.CotizacionesId == id);
            }
            else if (FiltrarComboBox.SelectedIndex == 1)
            {
                string comentario = CriterioTextBox.Text;
                lista = CotizacionesBLL.GetList(Cot => Cot.Comentario.Contains(comentario));
            }
            else if (FiltrarComboBox.SelectedIndex == 2)
            {
                decimal monto = 0;
                decimal.TryParse(CriterioTextBox.Text, out monto);

                lista = CotizacionesBLL.GetList(Cot => Cot.Monto == monto);
            }
            CotizacionesDataGridView.DataSource = lista;
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            ReporteCot cr = new ReporteCot(lista);
            cr.Show();
        }
    }
}
