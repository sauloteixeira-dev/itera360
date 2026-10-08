class Funcionario : IFuncionario
{
    #region Atributos
    private string _nome;
    protected decimal _salario;
    private int _matricula;
    private bool _situacao;
    #endregion

    #region props
    public string Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }
    public decimal Salario
    {
        get { return _salario; }
        set { _salario = value; }
    }
    public int Matricula
    {
        get { return _matricula; }
        set { _matricula = value; }
    }
    public bool Situacao
    {
        get { return _situacao; }
        set { _situacao = value; }
    }
    #endregion

    public Funcionario(string nome, decimal salario, bool situacao)
    {
        int r = new Random().Next(1, 1000);
        _matricula = r;
        _nome = nome;
        _salario = salario;
        _situacao = situacao;
    }

    public void DarAumento(decimal valor)
    {
        decimal dezPorcento = Salario * 10 / 100;
        Salario += dezPorcento;
    }
    public void Demitir()
    {
        _situacao = Situacao;
    }
}