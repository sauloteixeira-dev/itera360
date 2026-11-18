using Dominio;

public interface IClienteRepositorio
{
    void AdicionarCliente(Cliente cliente);
    Cliente ObterClientePorNome(string nome);
    void AtualizarCliente(Cliente cliente);
    void RemoverCliente(Cliente cliente);
}