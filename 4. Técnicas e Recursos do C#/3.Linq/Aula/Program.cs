internal class Program
{
    public static void Main(string[] args)
    {
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        var pares = numeros.Where(numero => numero % 2 == 0);
        // foreach (var numeroPar in pares)
        // {
        //     Console.WriteLine($"Par: {numeroPar}");
        // }

        var numeroDecrescente = numeros.OrderByDescending(numero => numero);
        // foreach (var numeroDec in numeroDecrescente)
        // {
        //     Console.WriteLine($"Número: {numeroDec}");
        // }

        var numero3 = numeros.FirstOrDefault(numero => numero == 3);
        Console.WriteLine($"Encontrado o numero: {numero3}");
    }
}

