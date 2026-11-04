public class TentativaPassagem : Passagem
{
    public Passagem passagem;
    public void NaoPassouFalha(Veiculo veiculo)
    {
        Passagem.TentativaPassagem++;
        Console.WriteLine($"Veiculo: {veiculo.Id} | Hora: {DateTime.Now} | Valor: {ValorPedagio}\nMotivo: Saldo Insuficiente");
    }
}