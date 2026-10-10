class Cachorro : Animal
{
    public Cachorro(string nome, int idade) : base(nome, idade)
    {

    }

    public override void EmitirSom()
    {
        System.Console.WriteLine("AU-AU");
    }
}