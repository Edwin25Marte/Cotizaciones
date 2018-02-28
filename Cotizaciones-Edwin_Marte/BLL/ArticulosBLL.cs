using Cotizaciones_Edwin_Marte.DAL;
using Cotizaciones_Edwin_Marte.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Cotizaciones_Edwin_Marte.BLL
{
    public class ArticulosBLL
    {
        public static Articulos Arti = new Articulos();
        public static bool Guardar(Articulos Ar)
        {
            bool paso = false;

            try
            {
                ContextoArt dbase = new ContextoArt();

                dbase.Art.Add(Ar);
                dbase.SaveChanges();
                Arti = Ar;
                paso = true;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static Articulos Buscar(int Id)
        {
            Articulos Articulo = new Articulos();
            try
            {
                ContextoArt dbase = new ContextoArt();
                Articulo = dbase.Art.Find(Id);
            }
            catch (Exception)
            {
                throw;
            }

            return Articulo;
        }

        public static bool Modificar(Articulos Art)
        {
            bool paso = false;

            try
            {
                ContextoArt dbase = new ContextoArt();

                dbase.Entry(Art).State = EntityState.Modified;
                dbase.SaveChanges();
                paso = true;

            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static bool Eliminar(int Id)
        {
            bool paso = false;

            try
            {
                ContextoArt dbase = new ContextoArt();
                Articulos Art = dbase.Art.Find(Id);

                dbase.Art.Remove(Art);
                dbase.SaveChanges();
                paso = true;

            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static List<Articulos> GetList(Expression<Func<Articulos, bool>> filter)
        {
            List<Articulos> Lista = null;
            try
            {
                ContextoArt dbase = new ContextoArt();
                Lista = dbase.Art.Where(filter).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return Lista;
        }
    }
}
