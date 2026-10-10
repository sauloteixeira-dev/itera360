class Livro
{
    #region Atrib
    public string _titulo;
    public string _autor;
    public int _nPaginas;
    #endregion

    #region Props
    public string Titulo { get { return _titulo; } set { _titulo = value; } }
    public string Autor { get { return _autor; } set { _autor = value; } }
    public int Npaginas { get { return _nPaginas; } set { _nPaginas = value; } }
    #endregion

    #region Construc
    public Livro(string titulo, string autor, int nPaginas)
    {
        Titulo = titulo;
        Autor = autor;
        Npaginas = nPaginas;
    }
    #endregion

}