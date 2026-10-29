public class MostrarOpcaoDeJogada
{
    public void mostrarOpcaoDeJogada()
    {
        int i = 1;

        foreach (var jogada in Enum.GetValues(typeof(Jogada)))
        {
            Console.WriteLine($"{i} - {jogada}");
            i++;
        }
    }

    public void EscolherPPT()
    {
        var show = new MostrarOpcaoDeJogada();
        int nJogada;
        bool validador = false;

        //preciso criar o jogador em algum lugar para ele vir pra cá pegar a sua jogada... e essa jogada alterar a cada rodada...

        do
        {
            Console.WriteLine("Informe um numero: ");
            show.mostrarOpcaoDeJogada();

            try
            {

                if (int.TryParse(Console.ReadLine(), out nJogada) && Enum.IsDefined(typeof(Jogada), nJogada))
                {
                    validador = true;
                }
                else
                {
                    Console.WriteLine("Erro: Valor não existe! Digite 1, 2 ou 3");
                }
                switch ((Jogada)nJogada)
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

    }


}

