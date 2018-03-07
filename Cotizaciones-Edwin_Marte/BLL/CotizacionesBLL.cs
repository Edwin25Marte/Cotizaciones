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
    public class CotizacionesBLL
    {
        public static bool Guardar(Cotizaciones Co)
        {
            bool paso = false;

            try
            {
                ContextoCot dbase = new ContextoCot();

                dbase.Co.Add(Co);
                dbase.SaveChanges();
                paso = true;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static Cotizaciones Buscar(int Id)
        {
            Cotizaciones cotizacion = new Cotizaciones();
            try
            {
                ContextoCot dbase = new ContextoCot();
                cotizacion = dbase.Co.Find(Id);
            }
            catch(Exception)
            {
                throw;
            }

            return cotizacion;
        }

        public static bool Modificar(Cotizaciones Co)
        {
            bool paso = false;

            try
            {
                ContextoCot dbase = new ContextoCot();

                dbase.Entry(Co).State = EntityState.Modified;
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
                ContextoCot dbase = new ContextoCot();
                Cotizaciones Cot = dbase.Co.Find(Id);

                dbase.Co.Remove(Cot);
                dbase.SaveChanges();
                paso = true;

            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static List<Cotizaciones> GetList(Expression<Func<Cotizaciones, bool>> filter)
        {
            List<Cotizaciones> Lista = null;
            try
            {
                ContextoCot dbase = new ContextoCot();
                Lista = dbase.Co.Where(filter).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return Lista;
        }
    }
}
