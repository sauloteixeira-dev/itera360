class ContaBancaria
{
    #region Atrib
    private int _numeroConta;
  
    private decimal _saldo;
    #endregion

    #region Props
    public int NumeroConta { get { return _numeroConta; } set { _numeroConta = value; } }
    public string Titular { get; set; }
    public decimal Salario { get { return _saldo; } private set { _saldo = value; } }
    #endregion

    public ContaBancaria(int numConta, decimal salario, string titular)
    {
        NumeroConta = numConta;
        Salario = salario;
        Titular = titular;
    }

    public void Depositar(decimal valor)
    {
        Salario += valor;
    }
    public void Sacar(decimal valor)
    {
        Salario -= valor;
    }
    public decimal VerificarSaldo()
    {
        return Salario;
    }
}