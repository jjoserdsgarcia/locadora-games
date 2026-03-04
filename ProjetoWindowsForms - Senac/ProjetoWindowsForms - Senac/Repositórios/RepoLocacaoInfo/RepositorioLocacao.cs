using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using ProjetoWindowsForms___Senac.Classes;

namespace ProjetoWindowsForms___Senac.Repositórios.RepoLocacaoInfo
{
    public static async Task<RegistroLocacao>ObterLocacaoAtivaPorJogo(int jogoId)
    {
        var conexao = new ConexaoBancoSQL();

        using (var connection = conexao.dbConnection())
        {
            string sql = @"
            SELECT 
                j.Titulo AS NomeJogo,
                u.Nome AS Cliente,
                l.DataLocacao,
                l.DataEntrega,
                l.Status
            FROM Locacao l
            INNER JOIN Jogo j ON l.JogoID = j.Id
            INNER JOIN Usuario u ON l.UsuarioID = u.UsuarioID
            WHERE l.JogoID = @Id AND l.Status = 'Ativo'";

            return await connection.QueryFirstOrDefaultAsync<RegistroLocacao>(sql, new { Id = jogoId });
        }
    }
}
