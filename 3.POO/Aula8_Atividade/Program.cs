internal class Program
{
    private static void Main(string[] args)
    {
        var func1 = new Funcionario("Saulo", 4000.00m);
        var func2 = new Gerente("João", "RH", 5500.00m);

        System.Console.WriteLine("\n\nObjeto Criado\n");
        System.Console.WriteLine($"O Funcionário 1 é {func1.Nome}, matricula: {func1.Matricula} e seu salário é de: R${func1.Salario}\n");
        System.Console.WriteLine($"\nO Gerente é {func2.Nome}, maricula: {func2.Matricula} do departamento {func2.Departamento} e seu salário é de: R${func2.Salario}\n\n");

        func1.DarAumento(0);
        func2.DarAumento(1000);

        System.Console.WriteLine("Após a função dar aumento: \n");
        System.Console.WriteLine($"O Funcionário 1 é {func1.Nome}, matricula: {func1.Matricula} e seu novo salário é de: R${func1.Salario}\n");
        System.Console.WriteLine($"\nO Gerente é {func2.Nome}, maricula: {func2.Matricula} do departamento {func2.Departamento} e seu salário é de: R${func2.Salario}\n\n");

    }
}