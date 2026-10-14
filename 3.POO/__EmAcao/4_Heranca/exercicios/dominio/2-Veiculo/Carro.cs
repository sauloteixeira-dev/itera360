class Carro : Veiculo
{
    private int _ano { get; set; }

    public Carro(string marca, string modelo, int ano) : base(marca, modelo)
    {
        _ano = ano;
    }

    public override void MostrarDetalhes()
    {
        System.Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Ano: {_ano}");
    }
}