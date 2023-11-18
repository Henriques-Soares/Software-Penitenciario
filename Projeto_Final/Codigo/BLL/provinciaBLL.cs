using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Projeto_Final.Codigo.DAL;
using Projeto_Final.Codigo.DTO;
using MySql.Data.MySqlClient;

namespace Projeto_Final.Codigo.BLL
{
    public class provinciaBLL : Acesso_BancoDados
    {
        //metodo para retornar a lista de provincias
        public DataTable listaProvincia()
        {
            return retornarDados("select * from provincia");
        }
    }
}
