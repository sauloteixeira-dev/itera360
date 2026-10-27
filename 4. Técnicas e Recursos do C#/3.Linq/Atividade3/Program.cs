internal class Program
{
    public static void Main(string[] args)
    {
        //1. Criar lista
        List<int> numeros = new List<int> { 5, 7, 2, 8, 6, 3, 10, 15, 18, 12, 17, 14 };

        Console.WriteLine("2. Números pares:");
        var par = numeros.Where(numero => numero % 2 == 0);
        foreach (var numeroPar in par)
        {
            Console.WriteLine($"Os numeros Pares são: {numeroPar}");
        }

        Console.WriteLine("\n\n");

        Console.WriteLine("3. Impares");
        var impar = numeros.Where(numero => numero % 2 == 1);
        foreach (var numeroImpar in impar)
        {
            Console.WriteLine($"Os numeros Impares são: {numeroImpar}");
        }

        Console.WriteLine("\n\n");

        Console.WriteLine("4.Numeros > 10");
        var nMaiorDez = numeros.Where(numero => numero > 10).OrderByDescending(numero => numero);
         foreach (var numeroMDez in nMaiorDez)
        {
            Console.WriteLine($"Os numeros > 10 são: {numeroMDez}");
        }

        Console.WriteLine("\n\n");

        Console.WriteLine("5.Calcular média de todos numeros da lista");
        var mediaTodos = numeros.Average();
        Console.WriteLine($"A média é: {mediaTodos}");

        Console.WriteLine("\n\n");

        Console.WriteLine("6.Encontrar o Primeiro numero da lista");
        var firstNumber = numeros.First();
        Console.WriteLine($"A O Primeiro nº é: {firstNumber}");

        Console.WriteLine("\n\n");

        Console.WriteLine("7.Encontrar o Ultimo numero da lista");
        var lastNumber = numeros.Last();
        Console.WriteLine($"A O ultimo nº é: {lastNumber}");
        
        Console.WriteLine("\n\n");

        Console.WriteLine("8.Soma > 10");
        var somaMaioresDez = numeros.Where(numero => numero > 10).Sum();
        Console.WriteLine($"A soma dos numeros > Dez: {somaMaioresDez}");




    }
}