class Produto
{
    private string _nome;
    private double _preco;
    private int _quantidade;

    public string Nome { get; set; }

    protected double Preco
    {
        get { return _preco; }
        set { _preco = value; }
    }
    protected int Quantidade
    {
        get { return _quantidade; }
        set { _quantidade = value; }
    }

    public Produto(string nome, double preco, int qtd)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = qtd;
    }



}