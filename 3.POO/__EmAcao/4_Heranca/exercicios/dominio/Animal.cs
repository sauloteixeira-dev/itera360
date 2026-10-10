class Animal
{
    private string _nome;
    private int _idade;


    public string Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }
    public int Idade { get { return _idade; } set { _idade = value; } }

    public Animal(string nome, int idade) 
    {
        _nome = nome;
        Idade = idade;
    }

    public virtual void EmitirSom()
    {
        System.Console.WriteLine("Fez um som!");
    }
}