using System.ComponentModel;

class Onibus
{
    private string _placa;
    private string _modelo;
    private int _capacidade;
    private int _assentosOcupados;

    public string Placa { get { return _placa; } private set { _placa = value; } }
    public string Modelo { get { return _modelo; } set { _modelo = value; } }
    public int Capacidade { get { return _capacidade; } private set { _capacidade = value; } }
    public int AssentosOcupados { get { return _assentosOcupados; } private set { _assentosOcupados = value; } }

    public Onibus(string placa, string modelo, int capacidade)
    {
        Placa = placa;
        Modelo = modelo;
        Capacidade = capacidade;
    }

    public void PossuiAssentoDisponivel()
    {
        if (Capacidade == AssentosOcupados)
        {
            System.Console.WriteLine("O onibus está cheio!");
        }
        else
        {
            System.Console.WriteLine($"Temos :{AssentosOcupados - Capacidade} assentos disponíveis");
        }
    }

    public void OcuparAssento(int numeroAssento)
    {
        if (numeroAssento < AssentosOcupados)
        {
            
        }
    }
}