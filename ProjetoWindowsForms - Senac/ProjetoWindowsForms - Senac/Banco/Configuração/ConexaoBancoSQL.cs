using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoWindowsForms___Senac
{
    public class ConexaoBancoSQL
    {
        public IDbConnection dbConnection()
        {
            return new SqlConnection("Server=(localdb)\\MSSQLLocalDB; Database=locadora_games; Trusted_Connection=True;");
        }

    }
}
