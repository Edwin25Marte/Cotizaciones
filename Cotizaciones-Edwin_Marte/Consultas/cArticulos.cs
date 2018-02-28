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
    public partial class cArticulos : Form
    {
        List<Articulos> lista = new List<Articulos>();

        public cArticulos()
        {
            InitializeComponent();
        }

        private void cArticulos_Load(object sender, EventArgs e)
        {

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if (FiltrarComboBox.SelectedIndex == 0)
            {
                int id = 0;
                int.TryParse(CriterioTextBox.Text, out id);

                lista = ArticulosBLL.GetList(Art => Art.ArticulosId == id);
            }
            else if (FiltrarComboBox.SelectedIndex == 1)
            {
                string descripcion = CriterioTextBox.Text;
                lista = ArticulosBLL.GetList(Art => Art.Descripcion.Contains(descripcion));
            }
            else if (FiltrarComboBox.SelectedIndex == 2)
            {
                decimal precio = 0;
                decimal.TryParse(CriterioTextBox.Text, out precio);

                lista = ArticulosBLL.GetList(Art => Art.ArticulosId == precio);
            }
            ArticulosDataGridView.DataSource = lista;
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            ReporteArt ra = new ReporteArt(lista);
            ra.Show();
        }
    }
}
