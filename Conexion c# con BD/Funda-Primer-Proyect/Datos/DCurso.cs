using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DCurso
    {
        public String Register(Curso curso)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Curso.Add(curso);
                    context.SaveChanges();
                }
                return "Registered Successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public String Modify(Curso curso)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Curso cursoTemporal = context.Curso.Find(curso.id_curso);
                    cursoTemporal.Nombrecurso = curso.Nombrecurso;
                    context.SaveChanges();
                }
                return "Modified Successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public String Eliminate(int id_curso)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Curso cursoTemporal = context.Curso.Find(id_curso);
                    context.Curso.Remove(cursoTemporal);
                    context.SaveChanges();
                }
                return "Removed Successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Curso> ListAll()
        {
            List<Curso> cursos = new List<Curso>();

            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = true;
                    cursos = context.Curso.ToList();
                }
                return cursos;
            }
            catch (Exception ex)
            {
                return cursos;
            }
        }
        public List<Curso> SearchByNameCourse(String nombreCurso)
        {
            List<Curso> cursos = new List<Curso>();

            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = true;
                    cursos = context.Curso.Where(c => c.Nombrecurso.Contains(nombreCurso)).ToList();
                }
                return cursos;
            }

            catch (Exception ex)
            {
                return cursos;
            }
        }
    }
}
