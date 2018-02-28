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

        public int Id { get; set; }
        public int ArtId { get; set; }
        public string Fecha { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Importe { get; set; }
        public decimal Total { get; set; }

        public CotizacionDetalle()
        {
            Id = 0;
            ArtId = 0;
            Fecha = " ";
            Cantidad = 0;
            Precio = 0;
            Importe = 0;
            Total = 0;
        }
        public CotizacionDetalle(int Id, int ArtId, string Fecha, decimal Cantidad, decimal Precio, decimal Importe)
        {
            this.Id = Id;
            this.ArtId = ArtId;
            this.Fecha = Fecha;
            this.Cantidad = Cantidad;
            this.Precio = Precio;
            this.Importe = Importe;
            Total = 0;
        }
    }
}
