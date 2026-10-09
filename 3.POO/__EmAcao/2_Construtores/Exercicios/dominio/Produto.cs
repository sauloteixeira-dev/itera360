class Produto
{
    #region Atributos
    public string _nome;
    public decimal _preco;
    public int _quantidade;
    #endregion

    #region Props
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public int Quantidade { get; set; }
    #endregion

    #region Construores
    public Produto(string nome, decimal preco, int quantidade)
    {
        quantidade = 0;
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }
    #endregion
}