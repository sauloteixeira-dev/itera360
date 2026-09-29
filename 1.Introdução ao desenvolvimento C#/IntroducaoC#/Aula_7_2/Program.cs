string seeMenu;
string escolha;
float arroz = 80;
float feijao = 50;
float carnePanela = 100;

Console.WriteLine("\nBem vindo ao Restaurante X\n");
Console.WriteLine("\n\n 1- Cardápio\n 0 - Sair\n");
seeMenu = Console.ReadLine();


switch (seeMenu)
{
    case "1":
        Console.WriteLine("Escolha um item para verificar os preços:");
        Console.WriteLine("\n 1 - Arroz Temperado");
        Console.WriteLine("\n 2 - Feijão com Bacon");
        Console.WriteLine("\n 3 - Carne de Panela\n");
        // Console.WriteLine("\n 0 - Voltar ao menu anterior"); //verificar (while?)
        escolha = Console.ReadLine();
        switch (escolha)
        {
            case "1":
                Console.WriteLine($"\nArroz Temperado: R${arroz.ToString("f")}\n");
                break;
            case "2":
                Console.WriteLine($"\nFeijão com Bacon: R${feijao.ToString("f")}\n");
                break;
            case "3":
                Console.WriteLine($"\nCarne de Panela: R${carnePanela.ToString("f")}\n");
                break;
            default:
                Console.WriteLine("\nOpção incorreta, fim do progama!\n");
                break;

        }
        break;
    case "0":
        Console.WriteLine("\nVocê Saiu");
        break;
    default:
        Console.WriteLine("\nOpção incorreta, fim do progama!\n");
        break;
}