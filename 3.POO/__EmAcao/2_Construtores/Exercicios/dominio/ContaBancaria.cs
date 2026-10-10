class ContaBancaria
{

    #region Atrib
    public int _numeroDaConta;
    public string _titular;
    public float _saldo;
    #endregion

    #region Props
    public int NumeroDaConta { get { return _numeroDaConta; } set { _numeroDaConta = value; } }
    public string Titular { get { return _titular; } set { _titular = value; } }
    public float Saldo { get { return _saldo; } set { _saldo = value; } }
    #endregion

    #region Const
    public ContaBancaria(int numConta, string titular)
    {
        NumeroDaConta = numConta;
        Titular = titular;
        Saldo = 0;
    }
    #endregion
}