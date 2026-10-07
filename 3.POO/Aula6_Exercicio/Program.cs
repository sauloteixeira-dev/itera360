internal class Program
{
    private static void Main(string[] args)
    {
        var funcionario1 = new Gerente("Saulo", "RH", 8000);
        Console.WriteLine($"O funcionário {funcionario1.Nome}, recebeu a promoção {funcionario1.Departamento}, com o salario: {funcionario1.Salario}");
        var funcionario2 = new Funcionario("Joao");
        Console.WriteLine($"O funcionário {funcionario2.Nome}, não recebeu promoção"); //{funcionario2.Departamento} não tem a propriedade em Funcionário
    }
}