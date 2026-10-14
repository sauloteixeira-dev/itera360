class Retangulo : Forma
{
    private int _largura { get; set; }
    private int _altura { get; set; }

    public Retangulo(string nome, int largura, int altura) : base(nome)
    {
        _largura = largura;
        _altura = altura;
    }

    public override void CalcularArea(int largura, int altura) : this(largura, altura)
    {
        
    }
}