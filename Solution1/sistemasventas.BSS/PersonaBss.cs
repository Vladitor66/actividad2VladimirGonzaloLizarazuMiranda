using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistemaventas.DAL;
using sistemasventas.MODELOS;

namespace sistemasventas.BSS
{
    public class PersonaBss
    {
        PersonaDAL dal = new PersonaDAL();
        public DataTable ListarPersonaBss()
        {
            return dal.ListarPersonasDal();
        }
        public void InsertarPersonaBss(persona persona)
        {
            dal.InsetarPersonaDal(persona);
        }
        public persona ObtenerIdBss(int id)
        {
            return dal.ObtenerPersonaId(id);
        }
        public void EditarPersonaBss(persona p)
        {
            dal.EditarPersonaDal(p);
        }
        public void EliminarpersonaBss(int id)
        {
            dal.EliminarPersonaDal(id);
        }

    }
}
