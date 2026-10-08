class Funcionario : FuncionarioBase
{
    public Funcionario(string nome, decimal salario) : base(nome, salario) { }

    public override void DarAumento(decimal valor)
    {
        decimal dezPorcento = Salario * 10 / 100;
        Salario += dezPorcento;
    }
}