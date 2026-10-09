class Pessoa
{
    #region Atributos
    private string _nome;
    private int _idade;
    #endregion

    #region Props
    public string Nome { get { return _nome; } set { _nome = value; } }
    public int Idade { get { return _idade; } set { _idade = value; } }
    #endregion

    #region Construtores
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
    #endregion
}