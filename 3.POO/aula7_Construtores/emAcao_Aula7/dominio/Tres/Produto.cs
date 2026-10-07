class Produto : ProdutoImportado
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public string Categoria { get; set; }

    public Produto(string nome) 
    {
        this.Nome = nome;
    }

    public Produto(string nome, double preco) : this(nome)
    {
        this.Preco = preco;
    }

    public Produto(string nome, double preco, string categoria) : this(nome, preco)
    {
        this.Categoria = categoria;
    }
}