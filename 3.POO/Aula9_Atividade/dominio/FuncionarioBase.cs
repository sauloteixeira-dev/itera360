
class FuncionarioBase : IFuncionario
{


    #region Atributos
    private string _nome;
    private int _matricula;
    protected decimal _salario;
    private bool _situacao;
    #endregion

    #region Propriedades
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

    public FuncionarioBase(string nome, decimal salario, bool situacao)
    {
        int r = new Random().Next(1, 1000);
        _matricula = r;
        _nome = nome;
        _salario = salario;
        _situacao = situacao;
    }

    public virtual void Demitir()
    {
        _situacao = Situacao;
    }

    public virtual void DarAumento(decimal valor)
    {
        _salario += valor;
    }


    #endregion
}
