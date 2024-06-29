using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NDocente
    {
        private DDocente dDocente = new DDocente();
        public String Register(Docente docente)
        {
            return dDocente.Register(docente);
        }
        public String Modify(Docente docente)
        {
            return dDocente.Modify(docente);
        }
        public String Eliminate(int id_docente)
        {
            return dDocente.Eliminate(id_docente);
        }
        public List<Docente> ListAll()
        {
            return dDocente.ListAll();
        }
        public List<Docente> SearchBySchool(String nombreDocente)
        {
            return dDocente.SearchBySchool(nombreDocente);
        }
    }
}
