class Estudante
{
    #region Atrib
    private string _nome;
    private int _nota;
    #endregion

    #region Props
    public string Nome { get { return _nome; } set { _nome = value; } }
    public int Notas
    {
        get { return _nota; }
        private set
        {
            if (value > 0 && value <= 100)
            {
                _nota = value;
                
            }else{
                System.Console.WriteLine("Valor incorreto!");
            }
        }
    }
    #endregion

    #region Const
    public Estudante(string nome, int notas)
    {
        Nome = nome;
        Notas = notas;
    }
    #endregion
}