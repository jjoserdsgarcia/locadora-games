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
                    Ano,
                    Status
                        FROM
                            Jogo
                ");

            return jogo;
        }

        public static async Task SalvarJogo(Jogo jogo)
        {
            using (var conexao = conexaoBancoSQL.dbConnection())  //ATUALIZAR O BANCO, COLOCAR "STATUS" E DISPONIVEL DPS DE CADASTRAR JOGO
            {
                string sql = @"INSERT INTO Jogo
                       (Titulo, Plataforma, Genero, Valor, Ano, Status)
                       VALUES
                       (@Titulo, @Plataforma, @Genero, @Valor, @Ano, @Status)"; 

                await conexao.ExecuteAsync(sql, jogo);
            }
        }

        internal static async Task Deletar(int id)
        {
            using (var connection = conexaoBancoSQL.dbConnection())
            {
                string query = "DELETE FROM Jogo WHERE JogoID = @Id";

                await connection.ExecuteAsync(query, new { Id = id });
            }
        }
    }
}
