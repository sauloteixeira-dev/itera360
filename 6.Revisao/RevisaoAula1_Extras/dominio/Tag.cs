public class Tag
{
    private string _id;
    private decimal _saldo;

    public string Id { get { return _id; } private set { _id = value; } }
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
        if (valor > 0)
        {
            _saldo += valor;
        }
        else
        {
            Console.WriteLine("\nValor Inválido! Insira um valor Positivo!\n");
        }
    }

    public decimal ObterSaldo()
    {
        return _saldo;
    }

    public void DescontarSaldo(decimal valor)
    {
        if (_saldo >= 2.90m)
        {
            _saldo -= valor;
        }
        else
        {
            Console.WriteLine("\nSaldo Insuficiente! Recarrege sua TAG\n");
        }
    }
}