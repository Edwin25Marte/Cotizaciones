using Cotizaciones_Edwin_Marte.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Cotizaciones_Edwin_Marte.DAL
{
    public class ContextoArt : DbContext
    {
        public ContextoArt() : base("ConStr")
        { }
        public DbSet<Articulos> Art { get; set; }
    }
}
