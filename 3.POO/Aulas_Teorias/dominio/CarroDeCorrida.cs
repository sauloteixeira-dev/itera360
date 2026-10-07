class CarroDeCorrida : Carro
{
    #region Atributos
    private string _equipe;
    #endregion

    #region Propriedades
    public string Equipe { get; set; }
    public string Motor { get; set; }
    #endregion

    public CarroDeCorrida(string equipe, string motor) : base()
    {
        Equipe = equipe;
        Motor = motor;

    }
}

