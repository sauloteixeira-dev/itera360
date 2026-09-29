string nome;
double primeiraNota;
double segundaNota;
double media;


Console.WriteLine("Digite seu nome: ");
nome  = Console.ReadLine();

Console.WriteLine("Digite a primeira nota: ");
primeiraNota = double.Parse(Console.ReadLine());


Console.WriteLine("Digite a segunda nota: ");
segundaNota = double.Parse(Console.ReadLine());

media = (primeiraNota + segundaNota) / 2;

Console.WriteLine($"A média final para o aluno {nome} é {media}. O programa terminou");
