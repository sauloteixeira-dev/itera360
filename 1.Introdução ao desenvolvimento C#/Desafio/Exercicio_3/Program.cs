string nome;
int palpite;
int pontos;
int tentativa;
int opcao;

Console.WriteLine("\n----------------------------------\n");
Console.WriteLine("JOGO DE ADIVINHAÇÃO DE NUMEROS");
Console.WriteLine("\n----------------------------------\n");
Console.WriteLine("\nBem vindo ao jogo de Adivinhação de Numeros!");

Console.WriteLine($"\nTente adivinhar o numero que estou pensando entre 1 e 100.\n");
Console.WriteLine($"Você tem 10 tentativas\n");
Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
Console.ReadKey();

Console.WriteLine("\nInforme seu nome: ");
nome = Console.ReadLine();

Console.WriteLine($"\nOlá {nome}, vamos começar?");

do
{
    Random random = new Random();

    int aleatorio = random.Next(1, 5);
    pontos = 100;

    for (int i = 1; i < 11; i++)
    {
        Console.WriteLine("\n\nInforme seu palpite: ");
        palpite = int.Parse(Console.ReadLine());

        if (palpite > aleatorio)
        {
            Console.WriteLine($"\n\nO número é menor ");
            pontos -= 10;
            tentativa = 10 - i;
            Console.WriteLine($"\nVoce tem {tentativa} tentativas\n\n");
            if (tentativa == 0)
            {
                Console.WriteLine("\nQue pena não foi dessa vez...");
                Console.WriteLine($"\nO numero aleatório: {aleatorio}");
                Console.WriteLine($"\nVoce fez {pontos} pontos");
            }
        }
        else if (palpite < aleatorio)
        {
            Console.WriteLine($"\n\nO número é maior");
            pontos -= 10;
            tentativa = 10 - i;
            Console.WriteLine($"\nVoce tem {tentativa} tentativas");
            if (tentativa == 0)
            {
                Console.WriteLine("\nQue pena não foi dessa vez...");
                Console.WriteLine($"\nO numero aleatório: {aleatorio}");
                Console.WriteLine($"\nVoce fez {pontos} pontos");
            }
        }
        else if (palpite == aleatorio)
        {
            Console.WriteLine($"\nParabéns vc acertou na {i}ª rodada!! Seu palpite foi: {palpite} e o numero é: {aleatorio}\n\n");
            Console.WriteLine($"\nVoce fez {pontos} pontos\n");
            i = 11;
        }

    }
    
    Console.WriteLine("Deseja jogar novamente? \n1 - Sim \n 2 - Não");
    opcao = int.Parse(Console.ReadLine());

} while (opcao == 1);
Console.WriteLine("\nObrigado por jogar! Até a Proxima!");
Console.WriteLine("\n\nDigite qualquer tecla para sair...");
Console.ReadKey();







