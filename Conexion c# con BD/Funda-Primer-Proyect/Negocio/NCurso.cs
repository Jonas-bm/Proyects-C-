using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NCurso
    {
        private DCurso dCurso= new DCurso();
        public String Register(Curso curso)
        {
            return  dCurso.Register(curso);
        }
        public String Modify(Curso curso)
        {
            return dCurso.Modify(curso);
        }
        public String Eliminate(int id_curso)
        {
            return dCurso.Eliminate(id_curso);
        }
        public List<Curso> ListAll()
        {
           return dCurso.ListAll();
        }
        public List<Curso> SearchByNameCourse(String nombreCurso)
        {
            return dCurso.SearchByNameCourse(nombreCurso);
        }
    }
}
