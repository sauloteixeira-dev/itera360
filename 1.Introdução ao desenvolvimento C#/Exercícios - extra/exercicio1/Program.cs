string nome, local;
double distanciaTotal;
double distanciaAtual;



Console.WriteLine("Bem vindo ao app TX");
Console.WriteLine("\nInforme seu nome: ");
nome = Console.ReadLine();

Console.WriteLine("\nInforme o Local de destino: \n");
local = Console.ReadLine();

Console.WriteLine("Informe a distancia em Metros:\n\n");
distanciaTotal = double.Parse(Console.ReadLine());


for (int i = 0; i <= 100; i++)
{
    
    if (i == 1)
    {
        distanciaAtual = distanciaTotal - (0.01 * distanciaTotal);
        Console.WriteLine($"Olá {nome}! Iniciando sua corrida... faltam {distanciaAtual}m ");
        Console.WriteLine($"{i}% da viagem\n");
    }
    else if (i == 25)
    {
        distanciaAtual = 0.25 * distanciaTotal;
        Console.WriteLine($"\n{nome}, ja foram percorridos: {distanciaAtual}m rumo a: {local}, aproveite a paisagem! ");
        Console.WriteLine($"{i}% da viagem");
    }
    else if (i == 50)
    {
        distanciaAtual = 0.50 * distanciaTotal;
        Console.WriteLine($"\n{nome}! Estamos na metade do caminho! A distância atual é de {distanciaAtual}m ");
        Console.WriteLine($"{i}% da viagem\n");
    }
    else if (i == 75)
    {
        distanciaAtual = 0.75 * distanciaTotal;
        Console.WriteLine($"\nOlá {nome}! Faltam {distanciaTotal - distanciaAtual}m, quase chegando... ");
        Console.WriteLine($"{i}% da viagem\n");
    }
    else if (i == 90)
    {
        distanciaAtual = 0.90 * distanciaTotal;
        Console.WriteLine($"\n{nome}! Distância atual é de {distanciaTotal - distanciaAtual} ");
        Console.WriteLine($"{i}% da viagem\n");
    }
    else if (i == 100)
    {
        Console.WriteLine($"\n{nome}, Chegamos ao {local}, percorridos {distanciaTotal}m \n{i}% do trajeto. ");
    }

}

