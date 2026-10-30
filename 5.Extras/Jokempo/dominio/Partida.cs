
public class Partida
{
    private Jogador _jogador;

    public Partida(Jogador jogador)
    {
        _jogador = jogador;
    }

    public int JogadaJogador()
    {
        int escolhaJogador;
        bool validador;

        do
        {
            Console.WriteLine($"Escolha uma opção: ");
            int i = 1;

            foreach (var jogada in Enum.GetValues(typeof(Jogada)))
            {
                Console.WriteLine($"{i} - {jogada}");
                i++;
            }
            escolhaJogador = int.Parse(Console.ReadLine());

            try
            {
                if (Enum.IsDefined(typeof(Jogada), escolhaJogador))
                {
                    validador = true;

                }
                else
                {
                    Console.WriteLine("Erro: Valor não existe! Digite 1, 2, 3 ou 4");
                }
                switch ((Jogada)escolhaJogador)
                {
                    case Jogada.Pedra:
                        Console.WriteLine($"Escolhido: {Jogada.Pedra}");
                        break;

                    case Jogada.Papel:
                        Console.WriteLine($"Escolhido: {Jogada.Papel}");
                        break;

                    case Jogada.Tesousa:
                        Console.WriteLine($"Escolhido: {Jogada.Tesousa}");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            return escolhaJogador;
        } while (validador == false);
    }

    public int JogadaComputador()
    {
        int escolhaComputador;

        escolhaComputador = new Random().Next(1, 4);
        switch ((Jogada)escolhaComputador)
        {
            case Jogada.Pedra:
                Console.WriteLine($"Escolhido pelo Computador: {Jogada.Pedra}");
                break;

            case Jogada.Papel:
                Console.WriteLine($"Escolhido pelo Computador: {Jogada.Papel}");
                break;

            case Jogada.Tesousa:
                Console.WriteLine($"Escolhido pelo Computador: {Jogada.Tesousa}");
                break;
        }
        return escolhaComputador;
    }

}



//1 perde 3
//3 ganha 2
//2 perde 1





