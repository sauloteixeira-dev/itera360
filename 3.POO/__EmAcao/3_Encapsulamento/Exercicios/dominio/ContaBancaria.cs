class ContaBancaria
{
    #region Atrib
    private int _numeroConta;
    private float _salario;
    private string _cargo;
    #endregion

    #region Props
    public int NumeroConta { get { return _numeroConta; } set { _numeroConta = value; } }
    protected float Salario { get{return _salario;}  } 
    public string Cargo { get { return _cargo; } set { _cargo = value; } }
    #endregion

    public ContaBancaria(int numConta, float salario, string cargo)
    {
        NumeroConta = numConta;
        _salario = salario;
        Cargo = cargo;
    }

    public void Depositar(float valor)
    {
        _salario += valor;
    }
    public void Sacar(float valor)
    {
        _salario -= valor;
    }
    public float VerificarSaldo()
    {
        return _salario;
    }
}