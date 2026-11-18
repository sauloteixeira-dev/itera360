
using DataAcess;
using Dominio;

public partial class Program
{
    public static void Main(string[] args)
    {
        using (var contexto = new Contexto())
        {
            var clienteRepositorio = new ClienteRepositorio(contexto);
            var cliente = new Cliente();
            var nomeCliente = string.Empty;

            // Cadastro de Cliente
            Console.WriteLine("Digite o nome do Cliente: ");
            cliente.Nome = Console.ReadLine();

            Console.WriteLine("Digite o Email do Cliente: ");
            cliente.Email = Console.ReadLine();

            clienteRepositorio.AdicionarCliente(cliente);

            Console.WriteLine("Cliente adicionado com Sucesso!");

            // Busca de Clientes
            Console.WriteLine("Digite o Nome do usuário que deseja consultar");
            nomeCliente = Console.ReadLine();

            var ClienteDoBanco = clienteRepositorio.ObterClientePorNome(nomeCliente);

            if (ClienteDoBanco != null)
            {
                Console.WriteLine($"Cliente encontrado com sucesso! O cliente {ClienteDoBanco.Nome}, possui o E-mail: {ClienteDoBanco.Email}");

                // Atualização de Cliente
                Console.WriteLine("Digite o novo Email");
                var novoEmail = Console.ReadLine();

                ClienteDoBanco.Email = novoEmail;

                clienteRepositorio.AtualizarCliente(ClienteDoBanco);

                Console.WriteLine("Cliente foi atualizado com sucesso!");

                // Remover Cliente
                // clienteRepositorio.RemoverCliente(ClienteDoBanco);
                // Console.WriteLine("Cliente foi Removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Cliente não encontrado");
            }
        }
    }
}
