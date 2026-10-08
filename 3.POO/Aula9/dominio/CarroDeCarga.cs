class CarroDeCarga : ICarro
{
    #region Props
    public double PesoSuportado { get; set; }
    public double Velocidade { get; set; }
    #endregion

    #region Construtor
    public CarroDeCarga()
    {

    }
    #endregion

    #region Comportamentos
    public void Acelerar()
    {
        Velocidade += 5;
    }

    public void Frear()
    {
        Velocidade -= 5;
    }
    #endregion
}