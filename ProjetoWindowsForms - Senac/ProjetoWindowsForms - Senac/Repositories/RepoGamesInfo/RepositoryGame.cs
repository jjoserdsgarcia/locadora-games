using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoWindowsForms___Senac.Classes;
using Dapper;

namespace ProjetoWindowsForms___Senac.Repositories.RepoGamesInfo
{
    public class RepositoryGame
    {
        private static readonly ConexaoBancoSQL conexaoBancoSQL = new ConexaoBancoSQL();
        public static async Task<IEnumerable<Jogo>> ObterTodos()
        {

            var jogo = await conexaoBancoSQL.dbConnection()
            .QueryAsync<Jogo>(
                @"
                SELECT
                    Titulo,
                    Plataforma,
                    Genero,
                    Valor,
                    Ano
                        FROM
                            Games
                ");

            return jogo;



        }

        public static async void SalvarJogo(Jogo jogo)
        {
            await conexaoBancoSQL.dbConnection().QueryAsync(

                @"INSERT INTO Games (Titulo, Plataforma, Genero, Valor, Ano)
                    VALUES (@Titulo, @Plataforma, @Genero, @Valor, @Ano);
                        


                ", jogo);
        }
    }
}
