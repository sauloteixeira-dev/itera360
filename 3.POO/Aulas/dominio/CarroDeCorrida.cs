class CarroDeCorrida
{
    public string Cor { get; set; }
    public string Categoria { get; set; }
    public string Motor { get; set; }
    public double Velocidade { get; set; }
    public int Potencia { get; set; }
    public bool Ligado { get; set; }

    public void Ligar()
    {
        Ligado = true;
    }
    public void Desligar()
    {
        Ligado = false;
    }
    public void Acelerar()
    {
        Velocidade += 10;
    }
    public void Frear()
    {
        Velocidade -= 10;
    }
    public string Virar(string direcao)
    {
        return direcao;
    }
}