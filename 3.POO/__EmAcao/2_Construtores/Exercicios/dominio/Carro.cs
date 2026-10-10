class Carro
{
    #region Atrb
    public string _marca;
    public string _modelo;
    public int _ano;
    #endregion

    #region Props
    public string Marca { get { return _marca; } set { _marca = value; } }
    public string Modelo { get { return _modelo; } set { _modelo = value; } }
    public int Ano { get { return _ano; } set { _ano = value; } }
    #endregion

    #region Construc
    public Carro(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }

    public Carro(string marca, string modelo, int ano) : this(marca, modelo)
    {
        Ano = ano;
    }
    #endregion
}