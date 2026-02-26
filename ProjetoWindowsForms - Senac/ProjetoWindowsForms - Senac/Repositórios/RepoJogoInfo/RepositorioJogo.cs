using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoWindowsForms___Senac.Classes;
using Dapper;

namespace ProjetoWindowsForms___Senac.Repositories.RepoGamesInfo
{
    public class RepositorioJogo
    {
        private static readonly ConexaoBancoSQL conexaoBancoSQL = new ConexaoBancoSQL();
        public static async Task<IEnumerable<Jogo>> ObterTodos()
        {

            var jogo = await conexaoBancoSQL.dbConnection()
            .QueryAsync<Jogo>(
                @"
                SELECT
                    JogoId AS Id,
                    Titulo,
                    Plataforma,
                    Genero,
                    Valor,
                    Ano
                        FROM
                            Jogo
                ");

            return jogo;



        }

        public static async Task SalvarJogo(Jogo jogo)
        {
            using (var conexao = conexaoBancoSQL.dbConnection())
            {
                string sql = @"INSERT INTO Jogo
                       (Titulo, Plataforma, Genero, Valor, Ano)
                       VALUES
                       (@Titulo, @Plataforma, @Genero, @Valor, @Ano)";

                await conexao.ExecuteAsync(sql, jogo);
            }
        }
    }
}
