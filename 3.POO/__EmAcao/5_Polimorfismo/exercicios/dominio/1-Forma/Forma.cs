using System.Formats.Asn1;

abstract class Forma
{
    public string _nome;
    private decimal _area;

    public decimal Area { get { return _area; } set { _area = value; } }


    public Forma(string nome)
    {
        _nome = nome;
        Area = 0;

    }

    public virtual void CalcularArea(decimal a, decimal b)
    {

    }
}