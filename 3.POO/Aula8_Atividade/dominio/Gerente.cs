class Gerente : FuncionarioBase
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

    public override void DarAumento(decimal salario)
    {
        decimal vinteCincoPorcento = (Salario * 25) / 100;
        Salario += vinteCincoPorcento + salario;
    }

    public Gerente(string nome, string departamento, decimal salario) : base(nome, salario)
    {        
        _departamento = departamento;
    }
}