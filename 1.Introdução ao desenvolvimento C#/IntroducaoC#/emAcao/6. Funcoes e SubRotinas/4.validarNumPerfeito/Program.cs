int n;
int soma = 0;

Console.WriteLine("Informe um numero:");
n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n / 2; i++)
{
    if (n % i == 0)
    {
        soma += i;
    }
}

if (n == soma)
{
    Console.WriteLine("É perfeito");
}
else
{
    Console.WriteLine("Não é perfeito");
}

