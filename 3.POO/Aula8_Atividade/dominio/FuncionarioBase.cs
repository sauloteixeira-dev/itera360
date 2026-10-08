using Microsoft.VisualBasic;

abstract class FuncionarioBase
{


    #region Atributos
    private string _nome;
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

    public FuncionarioBase(string nome, decimal salario)
    {
        int r = new Random().Next(1, 1000);
        _nome = nome;
        _salario = salario;
        _matricula = r;

    }

    public virtual void Demitir()
    {
        _situacao = false;
    }

    public virtual void DarAumento(decimal valor)
    {
        _salario += valor;
    }


    #endregion
}
