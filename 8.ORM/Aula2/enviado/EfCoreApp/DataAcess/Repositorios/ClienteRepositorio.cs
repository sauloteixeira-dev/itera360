using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;

using DataAcess;
using Dominio;
using Microsoft.EntityFrameworkCore;

public class ClienteRepositorio : IClienteRepositorio
{
    private readonly Contexto _contexto;
    public ClienteRepositorio(Contexto contexto)
    {
        _contexto = contexto;
    }
    // public void AdicionarCliente(Cliente cliente)
    // {
    //     _contexto.Clientes.Add(cliente);
    //     _contexto.SaveChanges();
    // }

    // public void AtualizarCliente(Cliente cliente)
    // {
    //     _contexto.Update(cliente);
    //     _contexto.SaveChanges();
    // }
    // public void RemoverCliente(Cliente cliente)
    // {
    //     _contexto.Clientes.Remove(cliente);
    //     _contexto.SaveChanges();
    // }
    // public Cliente ObterClientePorNome(string nome)
    // {
    //     var cliente = _contexto.Clientes.FirstOrDefault(cliente => cliente.Nome == nome);

    //     return cliente;
    // }
    public int Salvar(Cliente cliente)
    {
        const string sql = @"
       INSERT INTO Clientes
       (Nome, Email)
       OUTPUT INSERTED.ClienteId
       VALUES
       (@Nome, @Email)";

        var connection = _contexto.Database.GetDbConnection();

        return connection.QuerySingle<int>(sql, cliente);
    }
    public void Atualizar(Cliente cliente)
    {
        const string sql = @"
        UPDATE Clientes
        SET
            Nome = @Nome,
            Email = @Email
        WHERE
            ClienteID = @Id";

        var connection = _contexto.Database.GetDbConnection();

        var linhasAfetadas = connection.Execute(sql, cliente);

        Console.WriteLine($"Linhas afetadas: {linhasAfetadas}");
    }
    public Cliente Obter(string nome)
{
    const string sql = @"
        SELECT
            ClienteID,
            Nome,
            Email
        FROM Clientes
        WHERE Nome = @Nome";

    var connection = _contexto.Database.GetDbConnection();

    return connection.QueryFirstOrDefault<Cliente>(
        sql,
        new { Nome = nome }
    );
}
    public Cliente ObterPorEmail(string email)
    {
        const string sql = @"
        SELECT *
        FROM Clientes
        WHERE Email = @Email";

        var connection = _contexto.Database.GetDbConnection();
        return connection.QuerySingleOrDefault<Cliente>(sql, new { Email = email.Trim() });
    }




}