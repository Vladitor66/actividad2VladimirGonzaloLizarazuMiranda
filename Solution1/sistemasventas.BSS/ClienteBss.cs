using sistemaventas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistemasventas.BSS;
using sistemasventas.MODELOS;

namespace sistemasventas.BSS
{
    public class ClienteBss

    {
        ClienteDal dal = new ClienteDal();
        public DataTable ListarClienteBss()
        {
            return dal.ListarClienteDal();
        }
        


    }
}
    

