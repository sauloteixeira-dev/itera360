static class Utilitario
{
    private static int registroVitoria;

    private static int registroDerrota;

    public static int RegistroVitoria { get { return registroVitoria; } }

    public static int RegistroDerrota { get { return registroDerrota; } }

    static public string CalcularResultado(Jogada jogador, Jogada computador)
    {
        if (jogador == Jogada.Pedra)
        {
            if (jogador == Jogada.Pedra && computador == Jogada.Tesousa)
            {
                return "Jogador Ganhou";
                // RegistrarVitoria();
            }
            else if (jogador == Jogada.Pedra && computador == Jogada.Pedra)
            {
                return "Empate";
            }
            else if (jogador == Jogada.Pedra && computador == Jogada.Papel)
            {
                return "Computador ganhou";
                // RegistarDerrota();
            }
        }
        else if (jogador == Jogada.Papel)
        {
            if (jogador == Jogada.Papel && computador == Jogada.Pedra)
            {
                return "Jogador Ganhou";
                // RegistrarVitoria();
            }
            else if (jogador == Jogada.Papel && computador == Jogada.Papel)
            {
                return "Empate";
            }
            else if (jogador == Jogada.Papel && computador == Jogada.Tesousa)
            {
                return "Computador ganhou";
                // RegistarDerrota();
            }
            else if (jogador == Jogada.Tesousa)
            {
                if (jogador == Jogada.Tesousa && computador == Jogada.Pedra)
                {

                    return "Computador ganhou";
                    // RegistrarVitoria();
                }
                else if (jogador == Jogada.Tesousa && computador == Jogada.Papel)
                {
                    return "Jogador Ganhou";
                }
                else if (jogador == Jogada.Tesousa && computador == Jogada.Tesousa)
                {

                    return "Empate";
                    // RegistarDerrota();
                }
            }

        }
        return;

    }

    static Utilitario()
    {
        registroVitoria = 0;
        registroDerrota = 0;
    }

    //preciso fazer o if else para decidir qm ganhou no jogo...


}



/* public Jogador(string nome)
    {
        _nome = nome;
        _vitorias = 0;
        _derrotas = 0;
    }


    public void RegistrarVitoria()
    {
        _vitorias += 1;
    }

    public void RegistarDerrota()
    {
        _derrotas += 1;
    }*/