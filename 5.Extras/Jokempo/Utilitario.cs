static class Utilitario
{
    private static int registroVitoria;

    private static int registroDerrota;

    public static int RegistroVitoria { get { return registroVitoria; } }

    public static int RegistroDerrota { get { return registroDerrota; } }

//void ou string ou o que??????????
    static public void CalcularResultado(Jogada jogador, Jogada computador)
    {
        string empate = "Empate";
        string derrota = "Derrota";
        string vitoria = "Vitória";


        if (jogador == Jogada.Pedra)
        {
            if (jogador == Jogada.Pedra && computador == Jogada.Tesousa)
            {

                return vitoria;
                // RegistrarVitoria();
            }
            else if (jogador == Jogada.Pedra && computador == Jogada.Pedra)
            {
                return empate;
            }
            else if (jogador == Jogada.Pedra && computador == Jogada.Papel)
            {
                return derrota;
                // RegistarDerrota();
            }
        }
        else if (jogador == Jogada.Papel)
        {
            if (jogador == Jogada.Papel && computador == Jogada.Pedra)
            {
                return vitoria;
                // RegistrarVitoria();
            }
            else if (jogador == Jogada.Papel && computador == Jogada.Papel)
            {
                return empate;
            }
            else if (jogador == Jogada.Papel && computador == Jogada.Tesousa)
            {
                return derrota;
                // RegistarDerrota();
            }
        }
        else
        {
            if (jogador == Jogada.Tesousa)
            {
                if (jogador == Jogada.Tesousa && computador == Jogada.Pedra)
                {

                    return derrota;
                    // RegistrarVitoria();
                }
                else if (jogador == Jogada.Tesousa && computador == Jogada.Papel)
                {
                    return vitoria;
                }
                else if (jogador == Jogada.Tesousa && computador == Jogada.Tesousa)
                {

                    return empate;
                    // RegistarDerrota();
                }
            }
        }
    }
    return;
}

// static Utilitario()
// {
//     registroVitoria = 0;
//     registroDerrota = 0;
// }



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