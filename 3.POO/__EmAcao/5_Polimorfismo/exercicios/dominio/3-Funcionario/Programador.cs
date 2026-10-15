class Programador : Funcionario
{
    private decimal _salario;
    public decimal Salario { get { return _salario; } set { _salario = value; } }
    
    public virtual void CalcularSalario(decimal a, decimal b)
    {
        Salario = (a + b) / 2 * 3;
        System.Console.WriteLine($"O salario é de {Salario:C}");
    }
}