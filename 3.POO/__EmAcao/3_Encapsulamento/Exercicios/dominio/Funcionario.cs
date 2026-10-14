class Funcionario
{
    #region Atrib
    private string _nome;
    private decimal _salario;
    private string _cargo;
    #endregion

    #region Props
    public string Nome { get { return _nome; } set { _nome = value; } }
    public decimal Salario { get { return _salario; } protected set { _salario = value; } }
    public string Cargo { get { return _cargo; } set { _cargo = value; } }
    #endregion

    #region Const
    public Funcionario(string n, decimal s, string c)
    {
        Nome = n;
        Salario = s;
        Cargo = c;

    }
    #endregion

    public void AumentarSalario(decimal valor)
    {
        Salario += valor;
    }
}