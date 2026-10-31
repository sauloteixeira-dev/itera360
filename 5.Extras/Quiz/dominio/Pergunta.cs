public class Pergunta
{
    private string _enunciado;
    public string Enunciado
    {
        get { return _enunciado; }
        set { _enunciado = value; }
    }
    private List<string> _alternativas = new List<string>();
    public List<string> Alternativas
    {
        get { return _alternativas; }
        set { _alternativas = value; }
    }
    private Alternativa _alternativa;

    public Alternativa Alternativa
    {
        get { return _alternativa; }
        set { _alternativa = value; }
    }
    public Pergunta()
    {
        
    }
}

