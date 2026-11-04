public class Passagem
{
    private static int tentativaPassagem;
    public static int TentativaPassagem
    {
        get { return tentativaPassagem; }
        set { tentativaPassagem = value; }
    }
    private decimal valorPedagio;
    public decimal ValorPedagio { get; set; }
    public DateTime dateTime;
    public Veiculo veiculo;
    private static int passouComSucesso;
    public static int PassouComSucesso
    {
        get { return passouComSucesso; }
    }
    public Passagem()
    {
        passouComSucesso = 0;
        tentativaPassagem = 0;

        if (veiculo.TipoVeiculo == TipoVeiculo.Moto)
        {
            valorPedagio = 1.50m;
        }
        else if (veiculo.TipoVeiculo == TipoVeiculo.Carro)
        {
            valorPedagio = 2.90m;
        }
        else
        {
            ValorPedagio = 18.90m;
        }

    }
    public void PassouSucesso(Veiculo veiculo)
    {
        passouComSucesso++;
        Console.WriteLine($"Veiculo: {veiculo.Id} | Hora: {DateTime.Now} | Valor: {valorPedagio}");
    }
}