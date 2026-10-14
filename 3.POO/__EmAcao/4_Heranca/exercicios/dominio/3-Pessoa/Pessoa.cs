class Pessoa
{
    private string _nome;
    private int _idade;

    public string Nome { get { return _nome; } set { _nome = value; } }
    public int Idade { get { return _idade; } set { _idade = value; } }

    public Pessoa(string nome, int idade)
    {
        _nome = nome;
        _idade = idade;
    }

    public virtual void Apresentar()
    {
        System.Console.WriteLine("Apresentação");
    }
}
