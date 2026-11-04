using System.Dynamic;

public class Passagem
{
    public Veiculo Veiculo { get; set; }
    public DateTime dataHora { get; set; }
    public decimal ValorPedagio { get; set; }

    public Passagem(Veiculo automovel, decimal valorPedagio)
    {
        Veiculo = automovel;
        dataHora = DateTime.Now;
        ValorPedagio = valorPedagio;
    }

}