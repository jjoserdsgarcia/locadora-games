using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoWindowsForms___Senac.Classes;
using Dapper;

namespace ProjetoWindowsForms___Senac.Repositories.RepoUser
{
    public class RepositorioUsuario
    {
        private static readonly ConexaoBancoSQL conexaobanco = new ConexaoBancoSQL();
        public static async Task<IEnumerable<Usuario>> ObterTodos()
        {

            var usuario = await conexaobanco.dbConnection()
            .QueryAsync<Usuario>(
                @"
                SELECT
                    UsuarioID,
                    Nome,
                    CPF,
                    Email,
                    Telefone,
                    DataNascimento
                    FROM
                        Usuario
                ");

            return usuario;



        }

        public static async void SalvarUsuario(Usuario usuario)
        {
            await conexaobanco.dbConnection().QueryAsync(

                @"INSERT INTO Usuario (Nome, CPF, Email, Telefone, DataNascimento)
                    VALUES (@Nome, @CPF, @Email, @Telefone, @DataNascimento);
                        


                ", usuario);
        }

        public static async Task<Usuario> ObterPorCPF(int CPFUSUARIO)
        {
            var usuario = await conexaobanco.dbConnection()
            .QueryFirstOrDefaultAsync<Usuario>(
                @"
                SELECT
                    UsuarioID,
                    Nome,
                    CPF,
                    Email,
                    Telefone,
                    DataNascimento
                    FROM
                        Usuario
                    WHERE
                        CPF = @CPF
                ", new { CPF = CPFUSUARIO });

            return usuario;
        }

        public static async Task Deletar(int UsuarioID)
        {
            await conexaobanco.dbConnection().QueryAsync(
                @"
                         DELETE FROM Usuario
                          WHERE UsuarioID = @UsuarioID
                ", new { Usuario = UsuarioID });
        }
    }
}
