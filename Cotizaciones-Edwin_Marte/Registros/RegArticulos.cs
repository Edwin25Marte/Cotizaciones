using Cotizaciones_Edwin_Marte.BLL;
using Cotizaciones_Edwin_Marte.Consultas;
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
    public partial class RegArticulos : Form
    {
        ErrorProvider er = new ErrorProvider();

        public RegArticulos()
        {
            InitializeComponent();
        }

        private void RegArticulos_Load(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            ArticulosIdNumericUpDown.Value = 0;
            DescripcionTextBox.Clear();
            PrecioNumericUpDown.Value = 0;
        }

        private Articulos ObtInstancia()
        {
            return new Articulos(
                1,
                DescripcionTextBox.Text,
                (decimal)PrecioNumericUpDown.Value
                );
        }

        private bool CampoVacio()
        {
            bool paso = false;

            if (string.IsNullOrWhiteSpace(DescripcionTextBox.Text))
            {
                er.SetError(DescripcionTextBox, "Por favor, llene el campo descripcion.");
                paso = true;
            }
            if (PrecioNumericUpDown.Value == 0)
            {
                er.SetError(PrecioNumericUpDown, "Por favor, llene el campo precio.");
                paso = true;
            }
            return paso;
        }

        private void NuevoAButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarAButton_Click(object sender, EventArgs e)
        {
            Articulos Art = ArticulosBLL.Buscar((int)ArticulosIdNumericUpDown.Value);

            if (!CampoVacio())
            {
                if (Art == null)
                {
                    er.Clear();
                    if (ArticulosBLL.Guardar(ObtInstancia()))
                        MessageBox.Show("Se ha guardado el articulo.");
                    else
                        MessageBox.Show("No se pudo guardar el articulo.");
                }
                else
                {
                    Art.ArticulosId = (int)ArticulosIdNumericUpDown.Value;
                    Art.Descripcion = DescripcionTextBox.Text;
                    Art.Precio = PrecioNumericUpDown.Value;

                    if (ArticulosBLL.Modificar(Art))
                        MessageBox.Show("Se ha modificado el articulo.");
                    else
                        MessageBox.Show("No se pudo modificar el articulo.");
                }
            }
        }

        private void EliminarAButton_Click(object sender, EventArgs e)
        {
            if (ArticulosBLL.Eliminar(int.Parse(ArticulosIdNumericUpDown.Text)))
                MessageBox.Show("Se elimino el articulo.");

            Limpiar();
        }

        private void BuscarAButton_Click(object sender, EventArgs e)
        {
            Articulos Art = ArticulosBLL.Buscar((int)ArticulosIdNumericUpDown.Value);

            if (Art != null)
            {
                ArticulosIdNumericUpDown.Value = Art.ArticulosId;
                DescripcionTextBox.Text = Art.Descripcion;
                PrecioNumericUpDown.Value = Art.Precio;
            }
            else
                MessageBox.Show("El articulo no existe.");
        }

        private void ConsultarAButton_Click(object sender, EventArgs e)
        {
            cArticulos ca = new cArticulos();
            ca.Show();
        }

        private void RegistroCotButton_Click(object sender, EventArgs e)
        {
            CotizacionesDetalle Rc = new CotizacionesDetalle();
            Rc.Show();
        }
    }
}
