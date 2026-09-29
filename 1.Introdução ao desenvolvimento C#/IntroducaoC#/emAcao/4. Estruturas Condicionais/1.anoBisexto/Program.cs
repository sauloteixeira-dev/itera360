int ano;

Console.WriteLine("Informe um ano: (Ex: 1990)");
ano = int.Parse(Console.ReadLine());

if (ano % 100 == 0 && ano % 400 != 0)
{
    Console.WriteLine("Não é Bissexto ");
}
else if (ano % 4 == 0 || ano % 400 == 0)
{
    Console.WriteLine("certo");
}
else
{
    Console.WriteLine("Não é Bissexto");
}