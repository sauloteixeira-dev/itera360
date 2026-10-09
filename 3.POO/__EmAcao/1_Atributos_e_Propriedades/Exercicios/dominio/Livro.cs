class Livro
{
    #region Atributos
    private string _titulo;
    private string _autor;
    private int _numeroPaginas;
    #endregion

    #region Props
    public string Titulo
    {
        get { return _titulo; }
        protected set
        {   //_titulo != "" || _titulo != null
            if (string.IsNullOrWhiteSpace(value))
            {
                System.Console.WriteLine("Titulo é nulo ou está vazio!");
            }
            else
            {
                _titulo = value;
            }
        }
    }
    public string Autor
    {
        get { return _autor; }
        protected set
        {   //_titulo != "" || _titulo != null
            if (string.IsNullOrWhiteSpace(value))
            {
                System.Console.WriteLine("Autor é nulo ou está vazio!");
            }
            else
            {
                _autor = value;
            }
        }
    }
    public int NumeroPaginas
    {
        get { return _numeroPaginas; }
        set { _numeroPaginas = value; }
    }
    #endregion

    #region Construtores
    #endregion
}