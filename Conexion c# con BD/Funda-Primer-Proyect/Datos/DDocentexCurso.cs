using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public  class DDocentexCurso
    {
        public String Assign(DocentexCurso docenteXcurso)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.DocentexCurso.Add(docenteXcurso);
                    context.SaveChanges();
                }
                return "Registered Successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public String Unassign(int id_docente,int id_curso)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                   DocentexCurso docentexCursoTempotal= context.DocentexCurso.Find(id_docente,id_curso);
                   context.DocentexCurso.Remove(docentexCursoTempotal);
                   context.SaveChanges();
                }
                return "Registered Successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<DocentexCurso> ListAll()
        {
            List<DocentexCurso> docentesXcursos = new List<DocentexCurso>();

            try
            {
                using (var context = new BDEFEntities())
                {
                    docentesXcursos = context.DocentexCurso.ToList();
                }
                return docentesXcursos;
            }
            catch (Exception ex)
            {
                return docentesXcursos;
            }
        }
        public List<DocentexCurso> SearchByIdTeacher(int id_Docente)
        {
            List<DocentexCurso> docentesXcursos = new List<DocentexCurso>();

            try
            {
                using (var context = new BDEFEntities())
                {
                    docentesXcursos = context.DocentexCurso.Where(dc=>dc.id_docente.Equals(id_Docente)).ToList();
                }
                return docentesXcursos;
            }
            catch (Exception ex)
            {
                return docentesXcursos;
            }
        }
        public List<DocentexCurso> SearchByIdCourse(int id_Curso)
        {
            List<DocentexCurso> docentesXcursos = new List<DocentexCurso>();

            try
            {
                using (var context = new BDEFEntities())
                {
                    docentesXcursos = context.DocentexCurso.Where(dc => dc.id_curso.Equals(id_Curso)).ToList();
                }
                return docentesXcursos;
            }
            catch (Exception ex)
            {
                return docentesXcursos;
            }
        }

    }
}
