public class TentativaPassagem : Passagem
{
    // NOVO: o campo extra que o exercício pede
    public string Motivo { get; set; }

    // ALTERADO: ": base(...)" repassa veículo e valor para a classe Passagem (herança)
    public TentativaPassagem(Veiculo veiculo, decimal valorPedagio, string motivo)
        : base(veiculo, valorPedagio)
    {
        Motivo = motivo;
    } 
}