using sistemaventas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasventas.BSS
{
    internal class IngresoBss
    {
        public class PersonaBss
        {
            PersonaDAL dal = new PersonaDAL();
            public DataTable ListarPersonaBss()
            {
                return dal.ListarPersonasDal();
            }


        }
    }
}
