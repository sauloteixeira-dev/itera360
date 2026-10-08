class CarroDeCorrida : ICarro
{
    #region Props
    public string Equipe { get; set; }
    public string Motor { get; set; }
    public double Velocidade { get; set; }
    #endregion

    public CarroDeCorrida(string equipe, string motor)
    {
        Equipe = equipe;
        Motor = motor;
    }


    #region Comportamentos
    public void Acelerar()
    {
        Velocidade += 10;
    }

    public void Frear()
    {
        Velocidade -= 10;
    }
    #endregion
}