class Gerente : IFuncionario
{
    #region atributo
    private string _nome;
    private string _departamento;
    protected decimal _salario;
    private int _matricula;
    private bool _situacao;
    #endregion
    #region Propriedades

    public string Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }
    public string Departamento
    {
        get { return _departamento; }
        set { _departamento = value; }
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

    public Gerente(string nome, string departamento, decimal salario, bool situacao)
    {
        int r = new Random().Next(1, 1000);
        _matricula = r;
        _nome = nome;
        _departamento = departamento;
        _salario = salario;
        _situacao = situacao;
    }

    public void DarAumento(decimal valor)
    {
        decimal vinteCincoPorcento = (Salario * 25) / 100;
        Salario += vinteCincoPorcento + valor;
    }
    public void Demitir()
    {
        _situacao = Situacao;
    }
}