using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Cotizaciones_Edwin_Marte.Entidades
{
    public class CotizacionDetalle
    {
        [Key]

        public int ArtId { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Importe { get; set; }
        public decimal Total { get; set; }

        public CotizacionDetalle()
        {
            ArtId = 0;
            Cantidad = 0;
            Precio = 0;
            Importe = 0;
            Total = 0;
            Descripcion = " ";
        }
        public CotizacionDetalle(int ArtId, string Descripcion, decimal Cantidad, decimal Precio, decimal Importe)
        {
            this.ArtId = ArtId;
            this.Descripcion = Descripcion;
            this.Cantidad = Cantidad;
            this.Precio = Precio;
            this.Importe = Importe;
            Total = 0;
        }
    }
}
