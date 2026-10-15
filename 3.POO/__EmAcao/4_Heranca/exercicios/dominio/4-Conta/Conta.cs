class Conta
{
    private int _numero;
    private decimal _saldo;
    public int Numero { get { return _numero; } set { _numero = value; } }
    public decimal Saldo { get { return _saldo; } set { _saldo = value; } }

    public Conta(int num, decimal saldo)
    {
        Numero = num;
        Saldo = saldo;
    }

    public void Depositar(decimal valor)
    {
        Saldo += valor;
    }

    public virtual void Sacar(decimal valor)
    {
        System.Console.WriteLine($"Seu saldo é: {Saldo:C}");
    }
}