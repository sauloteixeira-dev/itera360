class Aluno : Pessoa
{
    private int _matricula { get; set; }

    public Aluno(string nome, int idade, int matricula) : base(nome, idade)
    {
        _matricula = matricula;
    }

    public override void Apresentar()
    {
        System.Console.WriteLine($"Olá! meu nome é {Nome}, e tenho {Idade}, anos!");
    }
}