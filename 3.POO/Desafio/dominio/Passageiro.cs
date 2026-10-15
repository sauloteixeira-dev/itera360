class Passageiro
{
    private string _nome;

    private int _documento;

    public string Nome { get { return _nome; } set { _nome = value; } }
    public int Documento { get { return _documento; } set { _documento = value; } }

    public Passageiro(string nome, int documento)
    {
        Nome = nome;
        Documento = documento;
    }

    public void AlterarNome(string novoNome)
    {
        Nome = novoNome;
    }
    public void ExibirDados()
    {
        System.Console.WriteLine($"Nome: {Nome} - Documento: {Documento}");
    }

}