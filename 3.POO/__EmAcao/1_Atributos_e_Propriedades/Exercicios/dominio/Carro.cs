class Carro
{
    #region Atributos
    private string _marca;
    private string _modelo;
    private int _ano;
    #endregion

    #region Props
    public string Marca
    {
        get { return _marca; }
        set { _marca = value; }
    }
    public string Modelo
    {
        get { return _modelo; }
        set { _modelo = value; }
    }
    public int Ano
    {
        get { return _ano; }
        protected set
        {
            if (_ano <= 2026 && _ano >= 1886)
            {
                _ano = value;
            }
            else
            {
                System.Console.WriteLine("Ano inválido, necessário ser de 1886 a 2026");
            }
        }
    }
    #endregion

    #region Construtores
    #endregion


}