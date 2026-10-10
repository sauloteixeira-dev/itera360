class Funcionario
{
    #region Atrib
    private string _nome;
    private float _salario;
    private string _cargo;
    #endregion

    #region Props
    public string Nome { get { return _nome; } set { _nome = value; } }
    private float Salario { get { return _salario; } set { _salario = value; } }
    public string Cargo { get { return _cargo; } set { _cargo = value; } }
    #endregion

    #region Const
    public Funcionario(string n, float s, string c)
    {
        Nome = n;
        Salario = s;
        Cargo = c;

    }
    #endregion

    public void AumentarSalario(float valor)
    {
        _salario += valor;
    }
}