class Circulo : Forma
{
    public decimal _pi = 3.14m;
    private decimal _raio;

    public decimal Raio { get { return _raio; } set { _raio = value; } }


    public Circulo(string nome, decimal raio) : base(nome)
    {

        Raio = raio;

    }

    public override void CalcularArea(decimal a, decimal b)
    {
        Area = _pi * Raio * Raio;
    }
}