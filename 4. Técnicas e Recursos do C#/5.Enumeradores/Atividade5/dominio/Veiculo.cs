public class Veiculo
{
    private TipoVeiculo _tipoVeiculo;

    public TipoVeiculo TipoVeiculo
    {
        get { return _tipoVeiculo; }
        set { _tipoVeiculo = value; }
    }

    private string _placa;
    public string Placa
    {
        get { return _placa; }
        set { _placa = value; }
    }
    private string _modelo;
    public string Modelo
    {
        get { return _modelo; }
        set { _modelo = value; }
    }
    private string _mcarca;
    public string Marca
    {
        get { return _mcarca; }
        set { _mcarca = value; }
    }

    public Tag Id;

    public Veiculo() { }

    public Veiculo(string placa, string modelo, string marca)
    {
        _placa = placa;
        _modelo = modelo;
        _mcarca = marca;
    }

    public Veiculo(string placa, string modelo, string marca, TipoVeiculo veiculo)
        : this(placa, modelo, marca)
    {
        _tipoVeiculo = veiculo;
    }

    public void AssociarTAG(Tag tag)
    {
        Id = tag;
    }

    public void AlterarPlaca(string novaPlaca)
    {
        _placa = novaPlaca;
    }
}
