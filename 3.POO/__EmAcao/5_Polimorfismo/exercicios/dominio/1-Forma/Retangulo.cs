class Retangulo : Forma
{
    private decimal _largura;
    private decimal _altura;

    public decimal Largura { get { return _largura; } set { _largura = value; } }

    public decimal Altura { get { return _altura; } set { _altura = value; } }

    public Retangulo(string nome, decimal largura, decimal altura) : base(nome)
    {
        Largura = largura;
        Altura = altura;
    }

    public override void CalcularArea(decimal largura, decimal altura)
    {
        Area = this.Altura * this.Largura;
    }
}