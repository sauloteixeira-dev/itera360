

abstract class FuncionarioBase
{

    #region Atributos
    public string _nome;
    private int _matricula;
    private decimal _salario;
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

    public FuncionarioBase(string nome)
    {
        this.Nome = nome;
    }


    public virtual void Demitir()
    {
        _situacao = false;
    }

    public virtual void AumentarSalario()
    {
        _salario += 1000;
    }

    public virtual void DiminuirSalario()
    {
        _salario -= 1000;
    }
    #endregion
}
