class Gerente : Funcionario
{
    #region atributo
    private string _departamento;
    #endregion

    #region Propriedades
    public string Departamento
    {
        get { return _departamento; }
        set { _departamento = value; }
    }
    #endregion

    public Gerente(string nome, string departamento, decimal salario, string situacao) : base(nome, salario, situacao)
    {
        _departamento = departamento;
    }

    public override void DarAumento(decimal valor)
    {
        decimal vinteCincoPorcento = (Salario * 25) / 100;
        Salario += vinteCincoPorcento + valor;
    }

    //vintecincoporcento = 250
    //1000 + 250 + 300
}