abstract class Forma
{
    public string _nome;


    public Forma(string nome)
    {
        _nome = nome;

    }

    public virtual void CalcularArea()
    {
        System.Console.WriteLine("A area é calculada...");
    }
}