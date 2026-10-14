using System.Diagnostics.Contracts;

internal class Program
{
    private static void Main(string[] args)
    {

        //1 - Funcionário
        // var funcionario1 = new Funcionario("Saulo", 100, "Dev");

        // // funcionario1._salario(); //erro
        // // funcionario1.Salario(); //erro

        // funcionario1.AumentarSalario(8);

        // System.Console.WriteLine($"O novo salário do {funcionario1.Nome} é de {funcionario1.Salario}");

        //--------------------------------------------------------------------------------------------------

        //2 - ContaBancária
        // var conta1 = new ContaBancaria(123, 0, "Saulo");

        // System.Console.WriteLine($"Nome: {conta1.Titular}, Saldo: {conta1.VerificarSaldo()}");

        // conta1.Depositar(500);

        // System.Console.WriteLine($"Nome: {conta1.Titular}, Saldo: {conta1.VerificarSaldo()}");

        // conta1.Sacar(250);
        // System.Console.WriteLine("Após o saque: ");
        // System.Console.WriteLine($"Nome: {conta1.Titular}, Saldo: {conta1.VerificarSaldo()}");

        //--------------------------------------------------------------------------------------------------

        //3 - Estudante
        // var est1 = new Estudante("Saulo");

        // // est1.AdicionarNota(101);//erro
        // // est1.AdicionarNota(-1);//erro
        // est1.AdicionarNota(100);//erro

        // System.Console.WriteLine($"Nome: {est1.Nome}, tem a nota: {est1.Notas}");

        //--------------------------------------------------------------------------------------------------

        //4 - Cliente
        // var cli = new Cliente("Saulo", "rua lala");
        // System.Console.WriteLine($"Nome: {cli.Nome}, Telefone: {cli.Telefone}");
        // cli.AdicionarTelefone(35984315);

        // cli.MostrarTelefone();
        // System.Console.WriteLine($"Nome: {cli.Nome}, Telefone: {cli.Telefone}");
        // cli.AdicionarTelefone(8855);
        // System.Console.WriteLine($"Nome: {cli.Nome}, Telefone: {cli.Telefone}");

        //--------------------------------------------------------------------------------------------------
        
        //5 - Produto
        // var prod = new Produto("SmartTV", 88.88, 900);

        // System.Console.WriteLine($"Produto:{prod.Nome}, Preço: R${prod.Preco}, Estoque: {prod.Quantidade} ");


    }
}