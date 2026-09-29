int numeroDigitado, numeroMaior = 0, n = 0;


while (n <= 10)
{
    Console.WriteLine("Informe um numero: ");
    numeroDigitado = int.Parse(Console.ReadLine());

    if (numeroDigitado > numeroMaior)
    {
        numeroMaior = numeroDigitado;
    }

    n++;
}
Console.WriteLine($"O numero maior é: {numeroMaior}");