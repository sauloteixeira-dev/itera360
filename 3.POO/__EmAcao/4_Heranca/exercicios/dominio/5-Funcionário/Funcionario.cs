class Funcionario
{
    private string _nome;
    protected decimal _salario;

    public string Nome { get { return _nome; } set { _nome = value; } }
    public decimal Salario { get { return _salario; } set { _salario = value; } }

    public Funcionario(string nome, decimal salario)
    {
        _nome = nome;
        _salario = salario;
    }

    public virtual void CalcularBonus(decimal valor)
    {
        System.Console.WriteLine($"Calculo do bonus da classe base{valor}");
    }
}