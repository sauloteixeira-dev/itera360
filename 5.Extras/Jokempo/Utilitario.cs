static class Utilitario
{
    public static string Vitoria = "Vitória";
    public static string Derrota = "Derrota";
    public static string Empate = "Empate";

    public static string CalcularResultado(Jogada jogador, Jogada computador)
    {
        if (jogador == computador)
        {
            return Empate;
        }

        bool jogadorGanhou =
            (jogador == Jogada.Pedra && computador == Jogada.Tesousa)
            || (jogador == Jogada.Tesousa && computador == Jogada.Papel)
            || (jogador == Jogada.Papel && computador == Jogada.Pedra);

        if (jogadorGanhou)
        {
            return Vitoria;
        }

        return Derrota;
    }

    
}
