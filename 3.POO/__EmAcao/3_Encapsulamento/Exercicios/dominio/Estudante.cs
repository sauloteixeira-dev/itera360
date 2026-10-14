class Estudante
{
    #region Atrib
    private string _nome;
    private decimal _nota;
    #endregion

    #region Props
    public string Nome { get { return _nome; } set { _nome = value; } }
    public decimal Notas
    {
        get { return _nota; }
        private set
        {
            if (value >= 0 && value <= 100)
            {
                _nota = value;

            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(value), value, "A nota deve estar entre 1 e 100.");
            }
        }
    }
    #endregion

    #region Const
    public Estudante(string nome)
    {
        Nome = nome;
        Notas = 0;
    }
    #endregion

    public void AdicionarNota(decimal valor)
    {
        Notas = valor;
    }
}