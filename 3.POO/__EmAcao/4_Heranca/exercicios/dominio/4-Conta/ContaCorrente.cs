class ContaCorrente : Conta
{
    private decimal Limite { get; set; }

    public ContaCorrente(int num, decimal saldo, decimal lim) : base(num, saldo)
    {
        Limite = lim;
    }

    public override void Sacar(decimal valor)
    {
        Saldo -= valor;
    }
}