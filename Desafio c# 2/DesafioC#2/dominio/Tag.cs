public class Tag
{
    private string _id;
    private decimal _saldo;

    public string Id { get { return _id; } set { _id = value; } }
    public decimal Saldo { get { return _saldo; } private set { _saldo = value; } }

    public Tag()
    {

    }
    public Tag(string id)
    {
        _id = id;
        _saldo = 0;
    }

    public void RecarregarTag(decimal valor)
    {
        _saldo += valor;
    }

    public decimal ObterSaldo()
    {
        return _saldo;
    }

    public void DescontarSaldo(decimal valor)
    {
        _saldo -= valor;
    }
}
