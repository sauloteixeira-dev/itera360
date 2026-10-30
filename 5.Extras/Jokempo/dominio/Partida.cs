public class Partida
{
    private Jogador _jogador;

    public Partida(Jogador jogador)
    {
        _jogador = jogador;
    }

    public Jogada JogadaJogador()
    {
        int escolhaJogador = 0;
        bool validador = false;

        do
        {
            Console.WriteLine("==============================");
            Console.WriteLine("          SUA JOGADA          ");
            Console.WriteLine("==============================");

            int i = 1;

            foreach (var jogada in Enum.GetValues(typeof(Jogada)))
            {
                Console.WriteLine($"  {i} - {jogada}");
                i++;
            }

            Console.WriteLine("==============================");
            Console.Write("Escolha uma opção: ");

            try
            {
                if (
                    int.TryParse(Console.ReadLine(), out escolhaJogador)
                    && Enum.IsDefined(typeof(Jogada), escolhaJogador)
                )
                {
                    validador = true;
                }
                else
                {
                    Console.WriteLine("Erro: Valor não existe! Digite 1, 2 ou 3\n\n");
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
        } while (validador == false);
        return (Jogada)escolhaJogador;
    }

    public Jogada JogadaComputador()
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
        return (Jogada)escolhaComputador;
    }

    public void AtualizarPlacar(string resultado)
    {
        if (resultado == Utilitario.Vitoria)
        {
            _jogador.RegistrarVitoria();
        }
        else if (resultado == Utilitario.Derrota)
        {
            _jogador.RegistrarDerrota();
        }
    }
}
