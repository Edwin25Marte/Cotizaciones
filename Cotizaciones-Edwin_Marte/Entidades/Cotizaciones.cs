using Cotizaciones_Edwin_Marte.Registros;
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
        public decimal Total { get; set; }
        public virtual List<CotizacionDetalle> CotDetalle { get; set; }

        public Cotizaciones()
        {
            CotizacionesId = 0;
            Fecha = " ";
            Comentario = " ";
            Total = 0;
            CotDetalle = new List<CotizacionDetalle>();
        }
        public Cotizaciones(int CotizacionesId, string Fecha, string Comentario, decimal Total, List<CotizacionDetalle> CotDetalle)
        {
            this.CotizacionesId = CotizacionesId;
            this.Fecha = Fecha;
            this.Comentario = Comentario;
            this.Total = Total;
            this.CotDetalle = CotDetalle;
        }
    }
}
