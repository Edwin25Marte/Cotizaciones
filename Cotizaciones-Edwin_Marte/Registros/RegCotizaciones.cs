using Cotizaciones_Edwin_Marte.BLL;
using Cotizaciones_Edwin_Marte.Consultas;
using Cotizaciones_Edwin_Marte.Entidades;
using Cotizaciones_Edwin_Marte.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cotizaciones_Edwin_Marte
{
    public partial class RegCotizaciones : Form
    {
        ErrorProvider er = new ErrorProvider();

        public RegCotizaciones()
        {
            InitializeComponent();
        }

        private void RegCotizaciones_Load(object sender, EventArgs e)
        {

        }

       /* private void Limpiar()
        {
            CotizacionesIdNumericUpDown.Value = 0;
            FechaDateTimePicker1.Value = DateTime.Now;
            ComentarioTextBox.Clear();
            MontoCNumericUpDown.Value = 0;
        }

        private Cotizaciones ObtInstancia()
        {
            return new Cotizaciones(
                0,
                FechaDateTimePicker1.Value.ToString(),
                ComentarioTextBox.Text,
                (decimal)MontoCNumericUpDown.Value
                );
        }


        private bool CampoVacio()
        {
            bool paso = false;

            if (string.IsNullOrWhiteSpace(ComentarioTextBox.Text))
            {
                er.SetError(ComentarioTextBox, "Por favor, llene el campo comentario.");
                paso = true;
            }
            if (MontoCNumericUpDown.Value == 0)
            {
                er.SetError(MontoCNumericUpDown, "Por favor, llene el campo monto.");
                paso = true;
            }
            return paso;
        }

        private void NuevoCButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarCButton_Click(object sender, EventArgs e)
        {
            Cotizaciones Cot = CotizacionesBLL.Buscar((int)CotizacionesIdNumericUpDown.Value);

            if (!CampoVacio())
            {
                if (Cot == null)
                {
                    er.Clear();
                    if (CotizacionesBLL.Guardar(ObtInstancia()))
                        MessageBox.Show("Se ha guardado la cotizacion.");
                    else
                        MessageBox.Show("No se pudo guardar la cotizacion.");
                }
                else
                {
                    Cot.CotizacionesId = (int)CotizacionesIdNumericUpDown.Value;
                    Cot.Fecha = FechaDateTimePicker1.Value.ToString();
                    Cot.Comentario = ComentarioTextBox.Text;
                    Cot.Monto = MontoCNumericUpDown.Value;

                    if (CotizacionesBLL.Modificar(Cot))
                        MessageBox.Show("Se ha modificado la cotizacion.");
                    else
                        MessageBox.Show("No se pudo modificar la cotizacion.");
                }
            }
        }

        private void EliminarCButton_Click(object sender, EventArgs e)
        {
            if (CotizacionesBLL.Eliminar(int.Parse(CotizacionesIdNumericUpDown.Text)))
                MessageBox.Show("Se elimino la cotizacion.");

            Limpiar();
        }

        private void BuscarCButton_Click(object sender, EventArgs e)
        {
            Cotizaciones Cot = CotizacionesBLL.Buscar((int)CotizacionesIdNumericUpDown.Value);

            if (Cot != null)
            {
                CotizacionesIdNumericUpDown.Value = Cot.CotizacionesId;
                FechaDateTimePicker1.Value = DateTime.Parse(Cot.Fecha);
                ComentarioTextBox.Text = Cot.Comentario;
                MontoCNumericUpDown.Value = Cot.Monto;
            }
            else
                MessageBox.Show("La cotizacion no existe.");
        }

        private void ConsultarCButton_Click(object sender, EventArgs e)
        {
            cCotizaciones cc = new cCotizaciones();
            cc.Show();
        }

        private void CotizacionesDetalleButton_Click(object sender, EventArgs e)
        {
            CotizacionesDetalle CD = new CotizacionesDetalle();
            CD.Show();
        }*/
    }
}
