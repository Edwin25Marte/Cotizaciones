using Cotizaciones_Edwin_Marte.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Cotizaciones_Edwin_Marte.DAL
{
    public class ContextoCot : DbContext
    {
        public ContextoCot() : base("ConStr")
        { }
        public DbSet<Cotizaciones> Co { get; set; }
    }
}
