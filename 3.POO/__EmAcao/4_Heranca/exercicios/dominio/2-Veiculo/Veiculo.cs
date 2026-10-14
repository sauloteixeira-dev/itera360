class Veiculo
{
    private string _marca;
    private string _modelo;

    public string Marca { get { return _marca; } set { _marca = value; } }

    public string Modelo { get { return _modelo; } set { _modelo = value; } }

    public Veiculo(string marca, string modelo)
    {
        _marca = marca;
        _modelo = modelo;
    }

    public virtual void MostrarDetalhes()
    {
        System.Console.WriteLine($"alguma coisa lala");
    }

}