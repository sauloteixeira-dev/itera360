int num;
bool primo = true;

Console.WriteLine("Informe um numero: ");
num = int.Parse(Console.ReadLine());


if (num < 0)
{
    Console.WriteLine("Número inválido.");
}

else if ((num == 0) || (num == 1))
{
    Console.WriteLine($"O número {num} não é primo.");
}

else
{
    for (int i = 2; i <= (num / 2); i++)
    {

        if (num % i == 0)
        {
            primo = false;
            break;
        }
    }

    if (primo)
    {
        Console.WriteLine($"O número {num} é primo");
    }
    else
    {
        Console.WriteLine($"O número {num} não é primo");
    }
}