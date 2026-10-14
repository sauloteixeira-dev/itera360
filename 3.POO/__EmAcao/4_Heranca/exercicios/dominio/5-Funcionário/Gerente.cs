class Gerente : Funcionario
{
    public string _departamento { get; set; }


    public Gerente(string nome, decimal salario, string dep) : base(nome, salario)
    {
        _departamento = dep;
    }

    public override void CalcularBonus(decimal valor)
    {
        _salario += valor;
    }
}