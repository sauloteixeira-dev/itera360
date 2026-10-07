class Gerente : Funcionario
{
    #region Atributos
    private string _departamento;
    #endregion

    #region Propriedades
    public string Departamento
    {
        get { return _departamento; }
        set { _departamento = value; }
    }
    #endregion

    public Gerente(string nome, string departamento, decimal salario) : base()
    {
        Nome = nome;
        Departamento = departamento;
        Salario = salario;
    }

    public void PromoverFuncionario(Funcionario qualquerstring)
    {
        Console.WriteLine($"Funcionário {qualquerstring.Nome}, foi promovido");
    }


}