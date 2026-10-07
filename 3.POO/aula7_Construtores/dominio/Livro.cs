class Livro 
{
    public string Autor { get; set; }
    public string Titulo { get; set; }
    public int AnoPublicacao { get; set; }

    public Livro(string titulo): base()//recebe o parametro em LivroBase
    {
        this.Titulo = titulo;
    }

    public Livro(string autor, string titulo) : this(titulo)
    {
        this.Autor = autor;
    }

    public Livro(string autor, string titulo, int AnoPublicacao) : this(autor, titulo)
    {
        this.AnoPublicacao = AnoPublicacao;
    }

}