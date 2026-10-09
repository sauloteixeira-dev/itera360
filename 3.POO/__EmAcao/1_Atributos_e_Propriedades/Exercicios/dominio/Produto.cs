class Produto
{
    #region Atributos
    private string _nome;
    private int _preco;
    private decimal _quantidade;
    #endregion

    #region Propriedades
    public string Nome { get; set; }
    public int Preco
    {
        get { return _preco; }
        protected set
        {
            if (value > 0)
            {
                _preco = value;

            }
            else { System.Console.WriteLine("Valor inválido"); }
        }
    }
    public decimal Quantidade
    {
        get { return _quantidade; }
        protected set
        {
            if (value > 0)
            {
                _quantidade = value;
            }
            else
            {
                System.Console.WriteLine("Valor Inválido");
            }
        }
    }
    #endregion

    #region Construtor
    #endregion
}