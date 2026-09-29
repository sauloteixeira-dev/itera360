int num;

Console.WriteLine("Informe um numero:");
num = int.Parse(Console.ReadLine());

for (int i = 0; i <= num; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"O numero Informado foi: {num} e seus numeros pares são: {i}");
    }
}
