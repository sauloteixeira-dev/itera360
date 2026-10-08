internal class Program
{
    private static void Main(string[] args)
    {
        var func1 = new Funcionario("Saulo", 4000.00m, false);
        var func2 = new Gerente("João", "RH", 5500.00m, false);
        var func3 = new FuncionarioBase("José", 8000.00m, true);


        System.Console.WriteLine("\n\nObjeto Criado\n");
        System.Console.WriteLine($"O Funcionário 1 é {func1.Nome}, e seu salário é de: R${func1.Salario} com a matricula: {func1.Matricula} \n");
        System.Console.WriteLine($"\nO Gerente é {func2.Nome}, do departamento {func2.Departamento} e seu salário é de: R${func2.Salario} com a matricula: {func2.Matricula}\n\n");
        System.Console.WriteLine($"\nO Funcionário Base é {func3.Nome}, e seu salário é de: R${func3.Salario}, com a matricula: {func3.Matricula}\n\n");

        func1.DarAumento(0);
        func2.DarAumento(1000);
        func3.DarAumento(0);

        System.Console.WriteLine("Após a função dar aumento: \n");
        System.Console.WriteLine($"O Funcionário 1 é {func1.Nome}, e seu salário é de: R${func1.Salario} com a matricula: {func1.Matricula} \n");
        System.Console.WriteLine($"\nO Gerente é {func2.Nome}, do departamento {func2.Departamento} e seu salário é de: R${func2.Salario} com a matricula: {func2.Matricula}\n\n");
        System.Console.WriteLine($"\nO Funcionário Base é {func3.Nome}, e seu salário é de: R${func3.Salario}, com a matricula: {func3.Matricula}\n\n");

    }
}