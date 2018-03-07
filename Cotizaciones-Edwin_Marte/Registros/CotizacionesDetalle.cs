using Cotizaciones_Edwin_Marte.BLL;
using Cotizaciones_Edwin_Marte.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cotizaciones_Edwin_Marte.Registros
{
    public partial class CotizacionesDetalle : Form
    {
        Articulos BArt = new Articulos();
        private Cotizaciones Co = new Cotizaciones();
        private List<CotizacionDetalle> cotd = new List<CotizacionDetalle>();
        private decimal Total = 0;
        public CotizacionesDetalle()
        {
            InitializeComponent();
        }

        private void CotizacionesDetalle_Load(object sender, EventArgs e)
        {

        }

        private Cotizaciones LlenarClase(List<CotizacionDetalle> Det)
        {
            return new Cotizaciones(
                0,
                FechaDetalleDateTimePicker.ToString(),
                ComentarioTextBox.Text,
                Total,
                Det
                );
        }

        private void BuscarArtButton_Click(object sender, EventArgs e)
        {
            int Id;

            int.TryParse(BArtNumericUpDown.Text, out Id);

            BArt = ArticulosBLL.Buscar(Id);

            if (BArt != null)
                PrecioNumericUpDown.Value = BArt.Precio;
            else
                MessageBox.Show("El articulo no  existe.");
        }

        private void CantidadNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (PrecioNumericUpDown.Value != 0)
                ImporteTextBox.Text = (CantidadNumericUpDown.Value * PrecioNumericUpDown.Value).ToString();
        }

        private void PrecioNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (CantidadNumericUpDown.Value != 0)
                ImporteTextBox.Text = (CantidadNumericUpDown.Value * PrecioNumericUpDown.Value).ToString();
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            cotd.Add(new CotizacionDetalle(
                 BArt.ArticulosId,
                 BArt.Descripcion,
                 (int)CantidadNumericUpDown.Value,
                 BArt.Precio,
                 decimal.Parse(ImporteTextBox.Text)
                 ));
            Total += decimal.Parse(ImporteTextBox.Text);
            DetalleDataGridView.DataSource = cotd.ToList();
        }

        private void BuscarCotizacionButton_Click(object sender, EventArgs e)
        {
            Co = CotizacionesBLL.Buscar((int)CotIdNumericUpDown.Value);

            if (Co == null)
                MessageBox.Show("La cotizacion no existe.");
            else
                MessageBox.Show("Se encontro la cotizacion.");
        }

        private void ConsultarCButton_Click(object sender, EventArgs e)
        {

        }
    }
}
