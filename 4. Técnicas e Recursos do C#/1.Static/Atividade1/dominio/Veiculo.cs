public class Veiculo
{

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

    public Tag _id;

    public Veiculo()
    {

    }

    public Veiculo(string placa)
    {
        _placa = placa;
    }
    public Veiculo(string placa, string modelo, string marca) : this(placa)
    {
        _modelo = modelo;
        _mcarca = marca;

    }

    public void AssociarTAG(Tag tag)
    {
        _id = tag;
    }
    public void AlterarPlaca(string novaPlaca)
    {
        _placa = novaPlaca;
    }

}