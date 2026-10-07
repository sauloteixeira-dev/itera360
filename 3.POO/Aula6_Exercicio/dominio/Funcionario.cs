

class Funcionario
{
    int matAleatorio = Random.Shared.Next(10, 100);

    #region Atributos
    public string _nome;
    private int _matricula;
    private decimal _salario;
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
    }

    public Funcionario(string nome)
    {
        Nome = nome;
        _matricula = matAleatorio;
        _salario = 0;
    }

    public Funcionario()
    {
        _matricula = matAleatorio;
        _salario = 0;
    }

    public void AumentarSalario()
    {
        _salario += 1000;
    }

    public void DiminuirSalario()
    {
        _salario -= 1000;
    }
    #endregion
}
