internal class Program
{
    private static void Main(string[] args)
    {
        var func1 = new Funcionario("Saulo", 4000.00m, "Contratado");
        var func4 = new Funcionario("Funcionario 2", 2000.00m, "Contratado");

        //testes
        // var func2 = new Gerente("João", "RH", 1000.00m, "Demitido");
        // var func3 = new Gerente("Gerente 2", "RH", 1000.00m, "Contratado");
        


        System.Console.WriteLine("\nObjeto Criado:");
        System.Console.WriteLine($"O Funcionário 1\nNome: {func1.Nome} - Salário: R${func1.Salario} - Matricula: {func1.Matricula} - Situação: {func1.Situacao}\n");
        func1.DarAumento(10);
        func1.Demitir();
        System.Console.WriteLine($"O Funcionário 1\nNome: {func1.Nome} - Salário: R${func1.Salario} - Matricula: {func1.Matricula} - Situação: {func1.Situacao}\n");
        

        System.Console.WriteLine($"O Funcionário 2\nNome: {func4.Nome} - Salário: R${func4.Salario} - Matricula: {func4.Matricula} - Situação é: {func4.Situacao}\n");
        func4.DarAumento(1000);
        func4.Demitir();
        System.Console.WriteLine($"O Funcionário 2\nNome: {func4.Nome} - Salário: R${func4.Salario} - Matricula: {func4.Matricula} - Situação é: {func4.Situacao}\n");


        // System.Console.WriteLine($"O Gerente 1\nNome: {func2.Nome} - Departamento: {func2.Departamento} - Salário: R${func2.Salario} - Matrícula: {func2.Matricula} - Situação: {func2.Situacao}\n");
        // func2.DarAumento(8);
        // func2.Demitir();
        // System.Console.WriteLine($"O Gerente 1\nNome: {func2.Nome} - Departamento: {func2.Departamento} - Salário: R${func2.Salario} - Matrícula: {func2.Matricula} - Situação: {func2.Situacao}\n");


        // System.Console.WriteLine($"O Gerente 2\nNome: {func3.Nome} - Departamento {func3.Departamento} - Salário: R${func3.Salario} -  Matricula: {func3.Matricula} - Situação: {func3.Situacao}\n");
        // func3.DarAumento(300);
        // func3.Demitir();
        // System.Console.WriteLine($"O Gerente 2\nNome: {func3.Nome} - Departamento {func3.Departamento} - Salário: R${func3.Salario} -  Matricula: {func3.Matricula} - Situação: {func3.Situacao}\n");


    }
}