public class Jogador
{
    private string _nome = string.Empty;
    private int _vitorias;
    private int _derrotas;

    private int _escolha;

    public string Nome
    {
        get { return _nome; }
        set { _nome = value; }
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
    public int Escolha
    {
        get { return _escolha; }
        set { _escolha = value; }
    }//verificar a necessidade disso depois...


    public Jogador()
    {

    }

    public Jogador(string nome)
    {
        Nome = nome;
        Vitorias = 0;
        Derrotas = 0;
    }
    public Jogador(string nome, int escolha) : this(nome)
    {
        Escolha = escolha;
    }//inserir a jogada do usuário no seu próprio objeto?

    public void RegistrarVitoria()
    {
        _vitorias += 1;
    }

    public void RegistarDerrota()
    {
        _derrotas += 1;
    }


}