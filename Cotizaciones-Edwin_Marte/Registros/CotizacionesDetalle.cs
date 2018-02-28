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
        Articulos Articulo = new Articulos();
        private int i = 0;

        public CotizacionesDetalle()
        {
            InitializeComponent();
        }

        private void CotizacionesDetalle_Load(object sender, EventArgs e)
        {

        }

        private CotizacionDetalle ObtInstancia()
        {
            Articulo = ArticulosBLL.Buscar((int)BArtNumericUpDown.Value);
            int ArtId = 0;

            if (Articulo != null)
                ArtId = Articulo.ArticulosId;

            decimal Imp = (decimal)CantidadNumericUpDown.Value * (decimal)PrecioNumericUpDown.Value;

            return new CotizacionDetalle(
                0,
                ArtId,
                FechaDetalleDateTimePicker.Value.ToString(),
                (decimal)CantidadNumericUpDown.Value,
                (decimal)PrecioNumericUpDown.Value,
                Imp
                );
        }

        private void BuscarArtButton_Click(object sender, EventArgs e)
        {
            int Id;
            Articulos BArt = new Articulos();

            int.TryParse(BArtNumericUpDown.Text, out Id);

            BArt = ArticulosBLL.Buscar(Id);

            if (BArt != null)
                ArtNTextBox.Text = BArt.Nombre;
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
            int id = 0;
            int.TryParse(BArtNumericUpDown.Text, out id);
            Articulos Art = new Articulos();

            DetalleDataGridView.Rows[i].Cells[0].Value = Art.ArticulosId;
            DetalleDataGridView.Rows[i].Cells[1].Value = Art.Descripcion;
            DetalleDataGridView.Rows[i].Cells[2].Value = CantidadNumericUpDown.Value;
            DetalleDataGridView.Rows[i].Cells[3].Value = PrecioNumericUpDown.Value;
            DetalleDataGridView.Rows[i].Cells[4].Value = CantidadNumericUpDown.Value * PrecioNumericUpDown.Value;
            DetalleDataGridView.Rows.Add();
       
            i++;
        }

    }
}
