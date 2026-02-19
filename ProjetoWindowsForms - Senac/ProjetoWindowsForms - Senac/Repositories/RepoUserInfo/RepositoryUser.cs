using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoWindowsForms___Senac.Classes;
using Dapper;

namespace ProjetoWindowsForms___Senac.Repositories.RepoUser
{
    public class RepositoryUser
    {
        private static readonly ConexaoBancoSQL conexaobanco = new ConexaoBancoSQL();
        public static async Task<IEnumerable<User>> ObterTodos()
        {

            var usuario = await conexaobanco.dbConnection()
            .QueryAsync<User>(
                @"
                SELECT
                    UsuarioID,
                    Nome,
                    Email,
                    Telefone,
                    DataNascimento
                    FROM
                        User1
                ");

            return usuario;



        }
    }
}
