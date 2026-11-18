using DataAcess;
using Dominio;

public class ClienteRepositorio : IClienteRepositorio
{
    private readonly Contexto _contexto;

    public ClienteRepositorio(Contexto contexto)
    {
        _contexto = contexto;
    }
    public void AdicionarCliente(Cliente cliente)
    {
        _contexto.Clientes.Add(cliente);
        _contexto.SaveChanges();
    }

    public void AtualizarCliente(Cliente cliente)
    {
        _contexto.Update(cliente);
        _contexto.SaveChanges();
    }

    public Cliente ObterClientePorNome(string nome)
    {
        var cliente = _contexto.Clientes.FirstOrDefault(cliente => cliente.Nome == nome);

        return cliente;
    }

    public void RemoverCliente(Cliente cliente)
    {
        _contexto.Clientes.Remove(cliente);
        _contexto.SaveChanges();
    }

}