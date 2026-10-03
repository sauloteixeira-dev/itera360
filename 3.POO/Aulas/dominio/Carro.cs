class Carro
{
    //atributos
    #region Atributos
    private string _marca;
    private string _modelo;
    private string _cor;

    private double _velocidade;
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
        set { _velocidade = value; }
    }
    public bool Ligado
    {
        get { return _ligado; }
        set { _ligado = value; }
    }
    #endregion
}