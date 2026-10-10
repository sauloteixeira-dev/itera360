class Cliente
{
    #region Atrib
    private string _nome;
    private string _endereco;
    private int _telefone;
    #endregion

    #region Props
    public string Nome { get { return _nome; } set { _nome = value; } }
    public string Endereco { get { return _endereco; } set { _endereco = value; } }
    public int Telefone { get; set; }

    #endregion

    #region Const
    public Cliente(string nome, string endereco)
    {
        Nome = nome;
        Endereco = endereco;
    }
    #endregion

    #region Comportamentos
    public void AdicionarTelefone(int tel)
    {
        Telefone = tel;
    }

    public void MostrarTelefone(){
        System.Console.WriteLine($"{Telefone}: Essa é a Propriedade\n {_telefone}: Esse é o atributo");
    }
    #endregion
}