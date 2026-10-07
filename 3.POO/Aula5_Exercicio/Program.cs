internal class Program
{
    private static void Main(string[] args)
    {
        Funcionario func1 = new Funcionario("Saulo");

        Console.WriteLine("");

        Console.WriteLine(
            $"\nFuncionário 1: {func1.Nome} - Matricula: {func1.Matricula} - Salário Atual: R$ {func1.Salario}"
        );
        func1.AumentarSalario();
        func1.AumentarSalario();

        Console.WriteLine($"\n\nFuncionário 1: {func1.Nome} após aumento: R$ {func1.Salario}");

        Console.WriteLine($"-----------------------------------------");

        var func2 = new Funcionario();

        func2.Nome = "Maria";

        Console.WriteLine(
            $"\n\nFuncionário 2: {func2.Nome} - Matricula: {func2.Matricula} - Salário Atual: R$ {func2.Salario}"
        );

        func2.AumentarSalario();

        Console.WriteLine(
            $"\n\nFuncionário 2: {func2.Nome} - Matricula: {func2.Matricula} - Salário Atual: R$ {func2.Salario}"
        );
    }
}
