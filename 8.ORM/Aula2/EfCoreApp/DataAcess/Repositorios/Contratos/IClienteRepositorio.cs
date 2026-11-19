using Dominio;

public interface IClienteRepositorio
{
    //Adicionar utilizando o ORM
    // void AdicionarCliente(Cliente cliente);

    //Obter utilizando o ORM
    // Cliente ObterClientePorNome(string nome);

    //Atualizar utilizando ORM
    // void AtualizarCliente(Cliente cliente);
    //Remover utilizando ORM
    //void RemoverCliente(Cliente cliente);

    //--------utilizando Dapper

    int Salvar(Cliente cliente);
    void Atualizar(Cliente cliente);
    Cliente Obter(string nome);
    Cliente ObterPorEmail(string email);







}