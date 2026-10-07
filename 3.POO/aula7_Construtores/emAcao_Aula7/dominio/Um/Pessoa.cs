class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Nacionalidade { get; set; }

    public Pessoa(string nome)
    {
        this.Nome = nome;
    }

    public Pessoa(string nome, int idade) : this(nome)
    {
        this.Idade = idade;
    }

    public Pessoa(string nome, int idade, string nacionalidade) : this(nome, idade)
    {
        this.Nacionalidade = nacionalidade;
    }
}