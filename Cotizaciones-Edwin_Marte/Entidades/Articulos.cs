using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Cotizaciones_Edwin_Marte.Entidades
{
    public class Articulos
    {
        [Key]

        public int ArticulosId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

        public Articulos()
        {
            ArticulosId = 0;
            Nombre = " ";
            Descripcion = " ";
            Precio = 0;
        }
        public Articulos(int ArticulosId, string Nombre, string Descripcion, decimal Precio)
        {
            this.ArticulosId = ArticulosId;
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
            this.Precio = Precio;
        }        
    }
}
