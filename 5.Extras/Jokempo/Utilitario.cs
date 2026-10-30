static class Utilitario
{
    private static int registroVitoria;

    private static int registroDerrota;

    public static int RegistroVitoria { get { return registroVitoria; } }

    public static int RegistroDerrota { get { return registroDerrota; } }

    // static string CalcularResultado(Jogada jogador, Jogada computador)
    // {



    // }

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