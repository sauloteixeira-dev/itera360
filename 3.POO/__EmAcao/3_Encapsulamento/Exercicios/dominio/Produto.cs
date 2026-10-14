class Produto
{
    private double _preco;
    private int _quantidade;

    public string Nome { get; set; }

    public double Preco
    {
        get { return _preco; }
        protected set { _preco = value; }
    }
    public int Quantidade
    {
        get { return _quantidade; }
       protected set { _quantidade = value; }
    }

    public Produto(string nome, double preco, int qtd)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = qtd;
    }







}