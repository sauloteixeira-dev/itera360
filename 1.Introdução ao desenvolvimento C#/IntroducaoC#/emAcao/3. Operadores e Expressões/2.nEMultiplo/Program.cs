int a, b, eMult;

Console.WriteLine("Informe o primeiro numero:");
a = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo numero:");
b = int.Parse(Console.ReadLine());

eMult = a / b;

if (eMult % 2 == 0 || eMult % 3 == 0)
{
    Console.WriteLine($"{a} é multiplo de {b}");
}
else
{
    Console.WriteLine($"{a} NÃO é multiplo de {b}");
}