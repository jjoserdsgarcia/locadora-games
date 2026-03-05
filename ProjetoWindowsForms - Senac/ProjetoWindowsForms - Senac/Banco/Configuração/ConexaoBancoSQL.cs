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
        
        public static string StringConexao { get; internal set; } = "Server=(localdb)\\MSSQLLocalDB; Database=locadora_games; Trusted_Connection=True;";

        public IDbConnection dbConnection()
        {
           
            return new SqlConnection(StringConexao);
        }
    }
}
