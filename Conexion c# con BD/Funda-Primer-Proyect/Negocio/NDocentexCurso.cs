using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NDocentexCurso
    {
        private DDocentexCurso dDocentexCurso=new DDocentexCurso();
        public String Assign(DocentexCurso docenteXcurso)
        {
            return dDocentexCurso.Assign(docenteXcurso);
        }
        public String Unassign(int id_docente, int id_curso)
        {
            return dDocentexCurso.Unassign(id_docente, id_curso);
        }
        public List<DocentexCurso> ListAll()
        {
            return dDocentexCurso.ListAll();
        }
        public List<DocentexCurso> SearchByIdTeacher(int id_Docente)
        {
           return dDocentexCurso.SearchByIdTeacher(id_Docente);
        }
        public List<DocentexCurso> SearchByIdCourse(int id_Curso)
        {
            return dDocentexCurso.SearchByIdCourse(id_Curso);
        }
    }
}
