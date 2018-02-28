using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Cotizaciones_Edwin_Marte.Entidades
{
    public class Cotizaciones
    {
        [Key]

        public int CotizacionesId { get; set; }
        public string Fecha { get; set; }
        public string Comentario { get; set; }
        public decimal Monto { get; set; }

        public Cotizaciones()
        {
            CotizacionesId = 0;
            Fecha = " ";
            Comentario = " ";
            Monto = 0;
        }
        public Cotizaciones(int CotizacionesId, string Fecha, string Comentario, decimal Monto)
        {
            this.CotizacionesId = CotizacionesId;
            this.Fecha = Fecha;
            this.Comentario = Comentario;
            this.Monto = Monto;
        }
    }
}
