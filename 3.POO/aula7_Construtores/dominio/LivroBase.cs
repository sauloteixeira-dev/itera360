abstract class LivroBase
{
    public bool Emprestado { get; set; }
    public LivroBase()
    {
        this.Emprestado = false;
    }
}