public class Ranking
{
    private List<Jogador> _jogadores = new List<Jogador>();

    public Jogador BuscarJogador(string nome)
    {
        return _jogadores.FirstOrDefault(jogador => jogador.Nome.ToLower() == nome.ToLower());
    }

    public void AdicionarJogador(Jogador novoJogador)
    {
        if (BuscarJogador(novoJogador.Nome) == null)
        {
            _jogadores.Add(novoJogador);
        }
    }

    public void ExibirRanking()
    {
        if (_jogadores.Count == 0)
        {
            Console.WriteLine("Nenhum jogador cadastrado.");
        }
        else
        {
            var jogadoresOrdenados = _jogadores.OrderByDescending(jogador => jogador.Vitorias);

            foreach (var jogador in jogadoresOrdenados)
            {
                Console.WriteLine(
                    $"{jogador.Nome} - Vitórias: {jogador.Vitorias} | Derrotas: {jogador.Derrotas}"
                );
            }
        }
    }
}
