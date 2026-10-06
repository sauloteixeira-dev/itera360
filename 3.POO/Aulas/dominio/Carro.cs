class Carro
{
    //atributos
    #region Atributos
    private string _marca;
    private string _modelo;
    private string _cor;

    private double _velocidade;//==============
    private bool _ligado;
    #endregion

    //Propriedade
    #region Propriedades
    public string Marca
    {
        get { return _marca; }
        set { _marca = value; }
    }
    public string Modelo
    {
        get { return _modelo; }
        set { _modelo = value; }
    }
    public string Cor
    {
        get { return _cor; }
        set { _cor = value; }
    }
    public double Velocidade
    {
        get { return _velocidade; }
    }
    public bool Ligado
    {
        get { return _ligado; }
        set { _ligado = value; }
    }
    #endregion

    public Carro()
    {
        _velocidade = 0;
        Ligado = false;
    }

    public Carro(string marca, string modelo, string cor)
    {
        Marca = marca;
        Modelo = modelo;
        Cor = cor;
        Ligado = false;

        _velocidade = 0;
    }

    public void Acelerar()
    {
        _velocidade +=10;
    }
    public void Frear()
    {
        _velocidade -=10;
    }
}
