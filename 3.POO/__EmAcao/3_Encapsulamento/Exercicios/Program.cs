internal class Program
{
    private static void Main(string[] args)
    {

        var nome1 = new Cliente("aa", "bb");

        nome1.AdicionarTelefone(321456789);

        System.Console.WriteLine($"Nome: {nome1.Nome} Endereço: {nome1.Endereco} Tel: {nome1.Telefone}");
        nome1.MostrarTelefone();

        // var estudante1 = new Estudante("jj", 101);

        // System.Console.WriteLine($"Nome: {estudante1.Nome}, nota: {estudante1.Notas}");

        // var Funcion = new Funcionario("joao", 89088, "bb");

        // System.Console.WriteLine($"{Funcion.Nome}, , {Funcion.Cargo}");
        // // System.Console.WriteLine($"{Funcion.Salario}");


    }
}