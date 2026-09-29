int ano, exp = 0;
string nome;

Console.WriteLine("\nInforme o ano: ");
ano = int.Parse(Console.ReadLine());

Console.WriteLine("\nInforme o nome: ");
nome = Console.ReadLine();

calcularExperiencia(ano);

Console.WriteLine($"\n{nome} tem {exp} de experiência.\n\n");


void calcularExperiencia(int ano)
{

    if (ano <= 1)
    {
        exp = 5;
    }
    else if (ano == 2)
    {
        exp = 8;
    }
    else if (ano >= 3)
    {
        exp = 8 + (ano - 2);
    }

}
