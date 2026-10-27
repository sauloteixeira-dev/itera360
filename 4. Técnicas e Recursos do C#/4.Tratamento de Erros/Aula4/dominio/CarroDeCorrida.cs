class CarroDeCorrida : Carro
{
    // #region Props
    // public string Equipe { get; set; }
    // public string Motor { get; set; }
    // #endregion

    // public CarroDeCorrida(string equipe, string motor) : base()
    // {
    //     Equipe = equipe;
    //     Motor = motor;
    // }


    #region Comportamentos
    public override void Acelerar()
    {
        Velocidade += 10;
    }

    public override void Frear()
    {
        Velocidade -= 10;
    }
    #endregion
}