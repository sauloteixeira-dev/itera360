public class Jogador
{
    private string _nome;
    private int _vitorias;
    private int _derrotas;


    public string Nome
    {
        get { return _nome; }
        private set { _nome = value; }
    }
    public int Vitorias
    {
        get { return _vitorias; }
        set { _vitorias = value; }
    }
    public int Derrotas
    {
        get { return _derrotas; }
        set { _derrotas = value; }
    }

    public Jogador()
    {

    }

    public Jogador(string nome)
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
    }
}