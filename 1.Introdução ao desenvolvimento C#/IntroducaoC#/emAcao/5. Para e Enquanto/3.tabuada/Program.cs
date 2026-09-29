int n, digitado;

Console.WriteLine("Informe um numero: ");
digitado = int.Parse(Console.ReadLine());

for (n = 1; n <= 10; n++)
{
    Console.WriteLine($"{digitado} * {n} = {n * digitado}");
}