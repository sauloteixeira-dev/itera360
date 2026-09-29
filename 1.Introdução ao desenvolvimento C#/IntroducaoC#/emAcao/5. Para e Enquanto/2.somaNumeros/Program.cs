int n, soma = 0;

Console.WriteLine("Insira um numero: ");
n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    soma += i;
}

Console.WriteLine($"A soma total é: {soma}");


