class CarroDeCarga : Carro
{
    #region Props
    public double PesoSuportado { get; set; }

    #endregion

    #region Construtor
    #endregion

    #region Comportamentos
    public override void Acelerar()
    {
        Velocidade += 5;
    }

    public override void Frear()
    {
        Velocidade -= 5;
    }
    #endregion
}