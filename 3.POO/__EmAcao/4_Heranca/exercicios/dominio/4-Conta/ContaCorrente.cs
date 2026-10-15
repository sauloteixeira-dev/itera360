class ContaCorrente : Conta
{
    public decimal Limite { get; set; }

    public ContaCorrente(int num, decimal saldo, decimal lim) : base(num, saldo)
    {
        Limite = lim;
    }

    public override void Sacar(decimal valor)
    {
        if (valor <= Saldo + Limite)
        {
            Saldo -= valor;
        }
        else
        {
            System.Console.WriteLine($"Saldo insuficiente! Para o saque de: {valor:C} Limite de saque: {Saldo + Limite:C} ");
        }
    }
}