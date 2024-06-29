using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DDocente
    {
        public String Register(Docente docente)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Docente.Add(docente);
                    context.SaveChanges();
                }
                return "Registered Successfully";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
         public String Modify(Docente docente)
         {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Docente docenteTemporal = context.Docente.Find(docente.id_docente);
                    docenteTemporal.Nombre = docente.Nombre;
                    docenteTemporal.Apellido = docente.Apellido;
                    docenteTemporal.Escuela = docente.Escuela;
                    context.SaveChanges();
                }
                return "Modified Successfully";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
         }
        public String Eliminate(int id_docente)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Docente docenteTemporal=context.Docente.Find(id_docente);
                    context.Docente.Remove(docenteTemporal);
                    context.SaveChanges();
                }
                return "Removed Successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Docente>ListAll()
        {
            List<Docente> docentes= new List<Docente>();

            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = true;
                    docentes =context.Docente.ToList();
                }
                return docentes;
            }
            catch (Exception ex)
            {
                return docentes;
            }
        }
        public List<Docente> SearchBySchool(String escuela)
        {
            List<Docente> docentes = new List<Docente>();

            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = true;
                    docentes =context.Docente.Where(d=>escuela.Contains(escuela)).ToList();
                }
                return docentes;
            }

            catch (Exception ex)
            {
                return docentes;
            }
        }
    }
}
