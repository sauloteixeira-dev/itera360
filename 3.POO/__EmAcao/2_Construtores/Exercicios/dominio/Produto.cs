class Produto
{
    #region Atributos
    public string _nome;
    public decimal _preco;
    public int _quantidade;
    #endregion

    #region Props
    public string Nome { get { return _nome; } set { _nome = value; } }
    public decimal Preco { get { return _preco; } set { _preco = value; } }
    public int Quantidade { get { return _quantidade; } set { _quantidade = value; } }
    #endregion

    #region Construores
    public Produto(string nome, decimal preco)
    {
        
        Nome = nome;
        Preco = preco;
        Quantidade = 0;
    }
    #endregion
}