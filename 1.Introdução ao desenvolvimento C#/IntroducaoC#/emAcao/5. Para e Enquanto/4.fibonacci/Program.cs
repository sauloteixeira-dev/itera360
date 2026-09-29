int a, b, n;

a = 0;
b = 1;

Console.WriteLine("Informe um numero: ");
n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine(" " + a);
    int temp = a;
    a = b;
    b = temp + b;
}
