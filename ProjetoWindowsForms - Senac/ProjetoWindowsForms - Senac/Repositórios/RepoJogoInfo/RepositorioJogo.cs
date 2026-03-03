using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoWindowsForms___Senac.Classes;
using Dapper;
using System.Data.SqlClient;
using System.Data;

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
                    Id,
                    Titulo,
                    Plataforma,
                    Genero,
                    Ano,
                    Status
                        FROM Jogo
                        ORDER BY Titulo ASC
                ");

            return jogo;
        }

        public static async Task SalvarJogo(Jogo jogo)
        {
            using (var conexao = conexaoBancoSQL.dbConnection())  //ATUALIZAR O BANCO, COLOCAR "STATUS" E DISPONIVEL DPS DE CADASTRAR JOGO
            {
                string sql = @"INSERT INTO Jogo
                       (Titulo, Plataforma, Genero, Ano, Status)
                       VALUES
                       (@Titulo, @Plataforma, @Genero, @Ano, @Status)"; 

                await conexao.ExecuteAsync(sql, jogo);
            }
        }

        public static async Task Atualizar(Jogo jogo)
        {
            using (var connection = conexaoBancoSQL.dbConnection())
            {
                await connection.ExecuteAsync(
                    @"
                    UPDATE Jogo
                        SET
                    Titulo = @Titulo,
                    Plataforma = @Plataforma,
                    Genero = @Genero,
                    Ano = @Ano
                        WHERE Id = @Id
            ",
                    jogo
                );
            }
        }

        private readonly ConexaoBancoSQL _conexao = new ConexaoBancoSQL();

        internal static async Task Deletar(int id)
        {
            using (var connection = conexaoBancoSQL.dbConnection())
            {
                string query = "DELETE FROM Jogo WHERE Id = @Id";

                await connection.ExecuteAsync(query, new { Id = id });
            }
        }
    }
}
