public class Passagem
{
    // ALTERADO: agora são propriedades que guardam os dados da cobrança
    public Veiculo Veiculo { get; set; }
    public DateTime DataHora { get; set; }
    public decimal ValorPedagio { get; set; }

    // ALTERADO: o construtor recebe os dados, em vez de tentar ler um veículo que ainda é null
    public Passagem(Veiculo veiculo, decimal valorPedagio)
    {
        Veiculo = veiculo;
        DataHora = DateTime.Now;   // data e hora exata da cobrança
        ValorPedagio = valorPedagio;
    }

    // REMOVIDO: contadores estáticos e PassouSucesso().
    // Para contar, use Pedagio.Passagens.Count; para exibir, o relatório.
}